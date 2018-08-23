using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DotNetPerls;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;
using GravityTidalCorrection.Properties;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using ZedGraph;

namespace GravityTidalCorrection
{
  public partial class MainForm : Form
  {
    private const string VersionNumber = @"2.0";
    private DateTime _beginInUtc;
    private double _duration;
    private double _elev;
    private DateTime _endInUtc;
    private bool _onLoadDone;
    private BindingList<TidalRecord> _tidalRecords;
    private double _timeInterval;
    private double _utcOffset;
    private ReadOnlyCollection<UTMZone> _utmZones;
    private double _xPos;
    private double _yPos;

    public MainForm()
    {
      InitializeComponent();
    }

    private void CopyTableToClipBoard()
    {
      dgvResult.SelectAll();
      DataObject dataObj = dgvResult.GetClipboardContent();
      if (dataObj != null)
        Clipboard.SetDataObject(dataObj);
      WriteLineConsoleLog("Table has been copied to clipboard.");
    }

    private static void DrawGraph(ZedGraphControl zgc,
                                  IEnumerable<TidalRecord> corrlist,
                                  string xAxisTitle,
                                  string yAxisTitle,
                                  string legend,
                                  Color clr,
                                  bool symbol)
    {
      GraphPane myPane = zgc.GraphPane;

      // clear previous graph
      myPane.CurveList.Clear();
      myPane.GraphObjList.Clear();
      zgc.Invalidate();

      myPane.Title.IsVisible = false;
      myPane.XAxis.Title.Text = xAxisTitle;
      myPane.YAxis.Title.Text = yAxisTitle;
      myPane.XAxis.Type = AxisType.Date;

      PointPairList plotList = new PointPairList();

      foreach (TidalRecord corr in corrlist) plotList.Add(corr.Date.ToOADate(), corr.gTotal);

      LineItem myCurve = myPane.AddCurve(legend, plotList, clr, SymbolType.Square);
      zgc.AxisChange();

      myCurve.Symbol.IsVisible = symbol;
      myCurve.Symbol.Size = 5;
      myCurve.Line.Width = 1.5f;
      myCurve.Line.IsSmooth = true;
      myCurve.Line.IsAntiAlias = true;

      zgc.Refresh();
    }

    public void Export(TextWriter writer, bool includeHeaders)
    {
      if (includeHeaders)
      {
        writer.WriteLine("# ------------------------------------------------------");
        writer.WriteLine("# Output from Grav-TC : Tidal Correction");
        writer.WriteLine("# ------------------------------------------------------");
        writer.WriteLine("# Time Zone\t: {0} (UTC{1:'+'00;'-'00})", cboxTimeZone.SelectedValue, _utcOffset);
        writer.WriteLine("# Begin\t\t: {0:dd-MMM-yyyy HH:mm:ss}", datepickBegin.Value);
        writer.WriteLine("# End\t\t: {0:dd-MMM-yyyy HH:mm:ss}\t", datepickEnd.Value);
        writer.WriteLine("# Interval\t: {0:F2} minutes", _timeInterval);
        writer.WriteLine("# Time Span\t: {0:F2} minutes", _duration);
        writer.WriteLine("# Latitude\t: {0:F4}", _yPos);
        writer.WriteLine("# Longitude\t: {0:F4}", _xPos);
        writer.WriteLine("# Elevation\t: {0:F2} meters", _elev);
        writer.WriteLine("# ------------------------------------------------------");
        writer.WriteLine("# Date Time, g Moon (mGal), g Sun (mGal), g Total (mGal)");
      }

      List<string> items = new List<string>();
      foreach (TidalRecord record in _tidalRecords)
      {
        // the first is a date column
        items.Add($"{record.Date:dd-MMM-yyyy HH:mm:ss}");
        items.Add($"{record.gMoon,10:F7}");
        items.Add($"{record.gSun,10:F7}");
        items.Add($"{record.gTotal,10:F7}");

        writer.WriteLine(string.Join("\t", items.ToArray()));
        items.Clear();
      }

      writer.Flush();
    }

    private bool IsInputInvalid(double elev, double duration, double interval)
    {
      bool valid = true;
      if (Math.Abs(elev) < 5e-6)
      {
        WriteErrorLog("Elevation cannot be zero.\t");

        valid = false;
      }

      if (duration < 0.0)
      {
        WriteErrorLog("End time is earlier than begin time.");
        valid = false;
      }

      if (Math.Abs(interval) < 5e-6)
      {
        WriteErrorLog("Time interval cannot be zero.\t");
        valid = false;
      }

      return !valid;
    }

    private void SetSize(ZedGraphControl zgc)
    {
      zgc.Location = new Point(10, 10);
      // Leave a small margin around the outside of the control
      zgc.Size = new Size(ClientRectangle.Width - 20,
                          ClientRectangle.Height - 20);
    }


    private void OnAboutToolStripMenuItem1Click(object sender, EventArgs e)
    {
      BetterDialog.ShowDialog("About Grav-TC",
                              $"Gravity Tidal Correction v{VersionNumber}",
                              "This program can be used to generate corrections table for measured gravity data.\n\n"
                              + "Value calculated is the UPWARD pull due to the sun and moon. To use as correction to measured gravity data, you would need to ADD these numbers, not subtract them.\n\n"
                              +
                              "The algorithm used is that of Longman, I.M., Formulas for Computing the Tidal Acceleration Due to the Moon and the Sun., J. Geoph. Res., 1959.\n\n"
                              +
                              "Math calculation are ported from TIDES program by J. L. Ahern which was written in QBASIC. Some icons are the work of Yusuke Kamiyamane.\n\n" +
                              "Copyright © 2014-2017 Adien Akhmad\nDepartment of Geophysics, Universitas Gadjah Mada. All rights reserved.",
                              null,
                              "Close",
                              (Image) Resources.ResourceManager.GetObject("Sites_icon"));
    }

    private void OnButtonGoClick(object sender, EventArgs e)
    {
      // elevation in metres
      _elev = Convert.ToDouble(numElevation.Value);
      // duration in minutes
      _duration = (datepickEnd.Value - datepickBegin.Value).TotalMinutes;
      // interval
      _timeInterval = Convert.ToDouble(numInterval.Value);

      // Checks the input, if input is invalid, it return void.
      if (IsInputInvalid(_elev, _duration, _timeInterval)) return;

      if (decimalDegreeInputToolStripMenuItem.CheckState == CheckState.Checked)
      {
        // Latitude, Longitude with decimal degree
        _yPos = Convert.ToDouble(num_yPos.Value);
        if (cboxLatSign.SelectedIndex == 1) // if latitude sign is 'S' then apply minus value
          _yPos = _yPos * -1.0;

        _xPos = Convert.ToDouble(num_xPos.Value);
        if (cboxLonSign.SelectedIndex == 1) // if longitude sign is 'W' then apply minus value
          _xPos = _xPos * -1.0;
      }

      if (useDegMinSecToolStrip.CheckState == CheckState.Checked)
      {
        // Latitude, Longitude with degree minute seconds
        _yPos = Convert.ToDouble(num_yPos.Value + numYMinutes.Value / (decimal) 60.0 +
                                 numYSeconds.Value / (decimal) 3600.0);
        if (cboxLatSign.SelectedIndex == 1) // if latitude sign is 'S' then apply minus value
          _yPos = _yPos * -1.0;

        _xPos = Convert.ToDouble(num_xPos.Value + numXMinutes.Value / (decimal) 60.0 +
                                 numXSeconds.Value / (decimal) 3600.0);
        if (cboxLonSign.SelectedIndex == 1) // if longitude sign is 'W' then apply minus value
          _xPos = _xPos * -1.0;
      }

      if (uTMInputToolStripMenuItem.CheckState == CheckState.Checked)
      {
        // X position and Y position in UTM
        _yPos = Convert.ToDouble(num_yPos.Value);
        _xPos = Convert.ToDouble(num_xPos.Value);

        UTMZone utmzone = _utmZones.ElementAt(toolStripComboBoxUTMZones.SelectedIndex);
        IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
        IProjectedCoordinateSystem utm =
          ProjectedCoordinateSystem.WGS84_UTM(utmzone.Zone, utmzone.IsNorthHemisphere);

        CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();
        ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(utm, geo);

        double[] fromPoint = {_xPos, _yPos};
        double[] toPoint = trans.MathTransform.Transform(fromPoint);

        _xPos = toPoint[0];
        _yPos = toPoint[1];
      }


      // convert input to UTC+00
      _beginInUtc = TimeZoneInfo.ConvertTime(datepickBegin.Value,
                                             TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()),
                                             TimeZoneInfo.Utc);

      _endInUtc = TimeZoneInfo.ConvertTime(datepickEnd.Value,
                                           TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()),
                                           TimeZoneInfo.Utc);

      // offset from UTC in hours
      _utcOffset =
        TimeZoneInfo.FindSystemTimeZoneById((string) cboxTimeZone.SelectedValue).BaseUtcOffset.TotalHours;

      // interval
      _timeInterval = Convert.ToDouble(numInterval.Value);

      // Start writing to list and display on gridview
      _tidalRecords.Clear();
      double minute = 0;

      Cursor.Current = Cursors.WaitCursor;
      WriteLineConsoleLog("Processing . . . .");
      Application.DoEvents();
      for (int i = 0; minute <= _duration; i++)
      {
        TidalRecord tidal = Longman1959.Compute(datepickBegin.Value.AddMinutes(minute),
                                                TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()),
                                                _yPos,
                                                _xPos,
                                                _elev);
        _tidalRecords.Add(tidal);
        minute += _timeInterval;
      }

      DrawGraph(zedGraphControl1,
                _tidalRecords,
                "Date Time",
                "g0 (mGals)",
                "Calculated Tides",
                Color.DeepSkyBlue,
                false);

      Cursor.Current = Cursors.Default;

      // write to console log
      WriteLineConsoleLog($"Time Zone \t: {cboxTimeZone.SelectedValue} (UTC{_utcOffset:'+'00;'-'00}) ");
      WriteLineConsoleLog($"Begin     \t\t: {datepickBegin.Value}\t({_beginInUtc} in UTC+00)");
      WriteLineConsoleLog($"End       \t\t: {datepickEnd.Value}\t({_endInUtc} in UTC+00) ");
      WriteLineConsoleLog($"Interval  \t\t: {_timeInterval:F2} minutes ");
      WriteLineConsoleLog($"Time Span \t: {_duration:F2} minutes ");
      WriteLineConsoleLog($"Latitude  \t: {_yPos:F4}°\r\nLongitude\t: {_xPos:F4}°");
      WriteLineConsoleLog($"Elevation \t: {_elev:F2} meters");
      WriteLineConsoleLog($"Completed...\t{dgvResult.RowCount} data point(s).");

      saveAsToolStripMenuItem.Enabled = true;
      copyToolStripMenuItem.Enabled = true;
      zedGraphControl1.Visible = true;
    }

    private void OnCboxTimeZoneSelectedIndexChanged(object sender, EventArgs e)
    {
      if (_onLoadDone)
      {
        string tz = cboxTimeZone.SelectedValue.ToString();
        WriteLineConsoleLog(
          $"Time Zone changed to {cboxTimeZone.SelectedValue} (UTC{TimeZoneInfo.FindSystemTimeZoneById(tz).GetUtcOffset(datepickBegin.Value).TotalHours:'+'00;'-'00}).");
      }
    }

    private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
    {
      if (dgvResult.Rows.Count == 0)
      {
        MessageBox.Show(@"Table is empty.");
        return;
      }

      CopyTableToClipBoard();

      MessageBox.Show(@"Table has been copied to clipboard.");
    }

    private void OnExitToolStripMenuItem1Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void OnInputCheckStateChanged(object sender, EventArgs e)
    {
      ToolStripMenuItem menu = sender as ToolStripMenuItem;
      if (menu != null && menu.CheckState == CheckState.Checked)
      {
        int index = ((ToolStripMenuItem) menu.OwnerItem).DropDownItems.IndexOf(menu);

        switch (index)
        {
          case 0:
            labelPositionX.Text = @"Longitude";
            labelPositionY.Text = @"Latitude";
            labelPositionX_unit.Visible = true;
            labelPositionY_unit.Visible = true;

            numXMinutes.Visible = false;
            numXSeconds.Visible = false;
            numYMinutes.Visible = false;
            numYSeconds.Visible = false;

            labelLatMin.Visible = false;
            labelLatSec.Visible = false;
            labelLonMin.Visible = false;
            labelLonSec.Visible = false;

            cboxLatSign.Visible = true;
            cboxLonSign.Visible = true;

            num_yPos.Width = 130;
            num_xPos.Width = 130;

            num_yPos.DecimalPlaces = 4;
            num_xPos.DecimalPlaces = 4;

            numXMinutes.Value = 0;
            numXSeconds.Value = 0;
            numYMinutes.Value = 0;
            numYSeconds.Value = 0;

            num_yPos.Maximum = 90;
            num_xPos.Maximum = 180;

            WriteLineConsoleLog("Coord system changed to geographic decimal degree.");
            break;

          case 1:
            labelPositionX.Text = @"Longitude";
            labelPositionY.Text = @"Latitude";
            labelPositionX_unit.Visible = true;
            labelPositionY_unit.Visible = true;

            numXMinutes.Visible = true;
            numXSeconds.Visible = true;
            numYMinutes.Visible = true;
            numYSeconds.Visible = true;

            cboxLatSign.Visible = true;
            cboxLonSign.Visible = true;

            labelLatMin.Visible = true;
            labelLatSec.Visible = true;
            labelLonMin.Visible = true;
            labelLonSec.Visible = true;

            num_yPos.Width = 45;
            num_xPos.Width = 45;
            num_yPos.DecimalPlaces = 0;
            num_xPos.DecimalPlaces = 0;

            num_yPos.Maximum = 90;
            num_xPos.Maximum = 180;

            // Flooring value after switch back to deg min sec
            num_yPos.Value = decimal.Floor(num_yPos.Value);
            num_xPos.Value = decimal.Floor(num_xPos.Value);

            WriteLineConsoleLog("Coord system changed to geographic deg min sec.");
            break;

          case 2:
            labelPositionX.Text = @"Easting";
            labelPositionY.Text = @"Northing";
            labelPositionX_unit.Visible = false;
            labelPositionY_unit.Visible = false;

            numXMinutes.Visible = false;
            numXSeconds.Visible = false;
            numYMinutes.Visible = false;
            numYSeconds.Visible = false;

            cboxLatSign.Visible = false;
            cboxLonSign.Visible = false;

            labelLatMin.Visible = false;
            labelLatSec.Visible = false;
            labelLonMin.Visible = false;
            labelLonSec.Visible = false;

            num_yPos.Maximum = 9300000;
            num_xPos.Maximum = 833000;

            num_yPos.Width = 130;
            num_xPos.Width = 130;

            num_yPos.DecimalPlaces = 2;
            num_xPos.DecimalPlaces = 2;

            numXMinutes.Value = 0;
            numXSeconds.Value = 0;
            numYMinutes.Value = 0;
            numYSeconds.Value = 0;

            UTMZone utmZone = toolStripComboBoxUTMZones.SelectedItem as UTMZone;
            WriteLineConsoleLog($"Coord system changed to {utmZone.DisplayName}");
            break;
        }
      }
    }

    private void OnInputModeChangeClick(object sender, EventArgs e)
    {
      ToolStripMenuItem menu = sender as ToolStripMenuItem;

      if (menu != null && menu.CheckState == CheckState.Unchecked)
      {
        foreach (ToolStripMenuItem tsm in inputToolStripMenuItem.DropDownItems) tsm.CheckState = CheckState.Unchecked;

        menu.CheckState = CheckState.Checked;
      }
    }

    private void OnMainFormLoad(object sender, EventArgs e)
    {
      Text = $@"Gravity Tidal Correction v{VersionNumber}";
      _utmZones = UTMZoneInfo.GetAllZones();
      _tidalRecords = new BindingList<TidalRecord>();
      dgvResult.DataSource = _tidalRecords;
      SetSize(zedGraphControl1);
      zedGraphControl1.Visible = false;

      // Add Time Zones and Set Selected to Local TimeZone
      ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();
      cboxTimeZone.DataSource = zones;
      cboxTimeZone.ValueMember = "Id";
      cboxTimeZone.DisplayMember = "DisplayName";
      cboxTimeZone.SelectedValue = TimeZoneInfo.Local.Id;

      // Setting initial datetime value, begin to today, end to tomorrow
      datepickBegin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
      datepickEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 0, 0, 0);

      // cbox lat long
      cboxLatSign.SelectedIndex = 0;
      cboxLonSign.SelectedIndex = 0;

      if (toolStripComboBoxUTMZones.ComboBox != null)
      {
        toolStripComboBoxUTMZones.ComboBox.BindingContext = BindingContext;
        toolStripComboBoxUTMZones.ComboBox.DataSource = _utmZones;
        toolStripComboBoxUTMZones.ComboBox.ValueMember = "Zone";
        toolStripComboBoxUTMZones.ComboBox.DisplayMember = "DisplayName";
      }

      toolStripComboBoxUTMZones.SelectedIndex = 97; // set default projection to WGS84 UTM Zone 49S


      // Tell the other if onload event is finished
      _onLoadDone = true;
      textBoxInfo.Clear();
      WriteConsoleLog("Welcome...");
    }

    private void OnNumYPosValidated(object sender, EventArgs e)
    {
      if (num_yPos.Value == 90)
      {
        numYMinutes.Maximum = new decimal(0);
        numYSeconds.Maximum = new decimal(0);
      }
      else
      {
        numYMinutes.Maximum = new decimal(59);
        numYSeconds.Maximum = new decimal(59);
      }
    }

    private void OnNumXPosValidated(object sender, EventArgs e)
    {
      if (num_xPos.Value == 180)
      {
        numXMinutes.Maximum = new decimal(0);
        numXSeconds.Maximum = new decimal(0);
      }
      else
      {
        numXMinutes.Maximum = new decimal(59);
        numXSeconds.Maximum = new decimal(59);
      }
    }

    private void OnReadGobsgobsToolStripMenuItemClick(object sender, EventArgs e)
    {
      FromFileMode form1 = new FromFileMode();
      form1.Show();
    }

    private void OnSaveAsToolStripMenuItem1Click1(object sender, EventArgs e)
    {
      saveFileDialog.ShowDialog();
    }

    private void OnSaveFileDialogFileOk(object sender, CancelEventArgs e)
    {
      using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
      {
        Export(writer, true);
      }

      WriteLineConsoleLog($"Successfully saved to {saveFileDialog.FileName}");
      MessageBox.Show(@"File has been saved.");
      saveFileDialog.FileName = null;
    }

    private void OnToolStripComboBoxUtmZonesSelectedIndexChanged(object sender, EventArgs e)
    {
      WriteLineConsoleLog(
        $"UTM Projection is set to {_utmZones.ElementAt(toolStripComboBoxUTMZones.SelectedIndex).DisplayName}");
    }

    private void WriteErrorLog(string sentence)
    {
      textBoxInfo.AppendText(string.Format("{2}ERROR: {0}\t({1:yyyy-MM-dd HH:mm:ss})",
                                           sentence,
                                           DateTime.Now,
                                           Environment.NewLine));
    }

    private void WriteLineConsoleLog(string sentence)
    {
      textBoxInfo.AppendText(Environment.NewLine + sentence);
    }

    private void WriteConsoleLog(string sentence)
    {
      textBoxInfo.AppendText(sentence);
    }
  }
}