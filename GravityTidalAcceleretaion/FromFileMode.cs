using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileHelpers;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;
using JR.Utils.GUI.Forms;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace GravityTidalCorrection
{
  public partial class FromFileMode : Form
  {
    private static int _windowId;
    private List<TidalRecord> _corrections;

    public FromFileMode()
    {
      _windowId++;
      InitializeComponent();
      Text = string.Format(@"GravTC - Read From File #{0:00}", _windowId);
    }

    private void OnCopyToolStripButtonClick(object sender, EventArgs e)
    {
      if (dgvFileMode.Rows.Count == 0)
      {
        MessageBox.Show(@"The table is empty.",
                        @"Data Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        return;
      }

      DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
      if (dataGridViewColumn != null && dataGridViewColumn.Visible == false)
      {
        MessageBox.Show(@"You have to click [Generate] first.",
                        @"Unable to Copy",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        return;
      }

      dgvFileMode.SelectAll();
      DataObject dataObj = dgvFileMode.GetClipboardContent();
      if (dataObj != null)
        Clipboard.SetDataObject(dataObj);
      MessageBox.Show(@"Table has been copied to clipboard.", @"Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void OnFromFileModeLoad(object sender, EventArgs e)
    {
      Debug.WriteLine("Width of column: ");
      Debug.WriteLine(dgvFileMode.Columns[0].Width);
      tsComboBoxCoordSystem.Items.Add("WGS84 Geographic");
      tsComboBoxCoordSystem.Items.Add("WGS84 UTM");
      tsComboBoxCoordSystem.SelectedIndex = 0;

      ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();

      if (tsComboBoxUTMZone.ComboBox != null)
      {
        tsComboBoxUTMZone.ComboBox.BindingContext = BindingContext;
        tsComboBoxUTMZone.ComboBox.DataSource = UTMZoneInfo.GetAllZones();
        tsComboBoxUTMZone.ComboBox.DisplayMember = "DisplayName";
        tsComboBoxUTMZone.ComboBox.ValueMember = "DisplayName";
        tsComboBoxUTMZone.ComboBox.SelectedValue = "WGS84 UTM Zone 49S";
      }

      if (tsComboBoxTimeZone.ComboBox != null)
      {
        tsComboBoxTimeZone.ComboBox.BindingContext = BindingContext;
        tsComboBoxTimeZone.ComboBox.DataSource = timeZones;
        tsComboBoxTimeZone.ComboBox.ValueMember = "Id";
        tsComboBoxTimeZone.ComboBox.DisplayMember = "DisplayName";
        tsComboBoxTimeZone.ComboBox.SelectedValue = TimeZoneInfo.Local.Id;
      }
    }

    private void OnOpenToolStripButtonClick(object sender, EventArgs e)
    {
      DialogResult result = openFileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        _corrections = new List<TidalRecord>();

        FileHelperEngine engine = new FileHelperEngine(typeof(TidalRecord));
        engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

        Cursor.Current = Cursors.WaitCursor;
        Enabled = false;
        TidalRecord[] tides = engine.ReadFile(openFileDialog.FileName) as TidalRecord[];
        if (tides != null) _corrections = tides.ToList();
        dgvFileMode.DataSource = _corrections;
        Enabled = true;
        Cursor.Current = DefaultCursor;

        Text = string.Format(@"GravTC - Read From File #{0:00} [{1}]", _windowId, openFileDialog.SafeFileName);
        Width -= 130;

        DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
        if (dataGridViewColumn != null)
          dataGridViewColumn.Visible = false;

        if (engine.ErrorManager.HasErrors)
        {
          if (engine.ErrorManager.ErrorCount > 50)
          {
            MessageBox.Show(string.Format("Found {0} errors while reading the file, please check error.log for detailed information.", engine.ErrorManager.ErrorCount), @"File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            engine.ErrorManager.SaveErrors("error.log");
          }

          else
          {
            string error =
              string.Format(
                "Format violation occured. Found {0} errors:\n\n",
                engine.ErrorManager.ErrorCount);

            foreach (ErrorInfo err in engine.ErrorManager.Errors)
              error += string.Format("(Line: {0:00}) {1}{2}",
                                     err.LineNumber,
                                     err.ExceptionInfo.Message,
                                     Environment.NewLine);

            FlexibleMessageBox.MAX_HEIGHT_FACTOR = 0.5;
            FlexibleMessageBox.Show(error, "Error(s) found", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

          FlexibleMessageBox.Show(
            string.Format("There are {0} records successfully imported, {1} records failed and {2} records ignored.",
                          tides.Count(),
                          engine.ErrorManager.ErrorCount,
                          engine.TotalRecords - tides.Count() - engine.ErrorManager.ErrorCount),
            "Read Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        else
        {
          FlexibleMessageBox.Show(string.Format("Read complete, {0} records has been added.", tides.Count()), "Read Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void OnSaveToolStripButtonClick(object sender, EventArgs e)
    {
      if (dgvFileMode.Rows.Count == 0)
      {
        MessageBox.Show(@"The table is empty.",
                        @"Unable to Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        return;
      }

      DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
      if (dataGridViewColumn != null && dataGridViewColumn.Visible == false)
      {
        MessageBox.Show(@"You have to click [Generate] first.",
                        @"Unable to Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        return;
      }

      DialogResult result = saveFileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

        writer.WriteLine("# ------------------------------------------------------");
        writer.WriteLine("# Output from Grav-TC : Tidal Corrections");
        writer.WriteLine("# ------------------------------------------------------");
        if (tsComboBoxTimeZone.ComboBox != null)
        {
          TimeZoneInfo selectedTimeZone = tsComboBoxTimeZone.ComboBox.SelectedItem as TimeZoneInfo;
          if (selectedTimeZone != null) writer.WriteLine("# Time Zone\t: {0}", selectedTimeZone.DisplayName);
        }

        if (tsComboBoxCoordSystem.ComboBox != null && tsComboBoxUTMZone.ComboBox != null && tsComboBoxCoordSystem.ComboBox.SelectedIndex == 1) writer.WriteLine("# Projection\t: {0}", tsComboBoxUTMZone.ComboBox.SelectedValue);
        writer.WriteLine("# ------------------------------------------------------");
        writer.WriteLine("# Date Time, X-Position, Y-Position g Moon (mGal), g Sun (mGal), g Total (mGal)");


        List<string> items = new List<string>();

        foreach (TidalRecord corr in _corrections)
        {
          // the first is a date column
          items.Add(string.Format("{0:dd-MMM-yyyy HH:mm:ss}", corr.Date));
          items.Add(string.Format("{0,10:F6}", corr.XPosition));
          items.Add(string.Format("{0,10:F6}", corr.YPosition));
          items.Add(string.Format("{0,7:F2}", corr.Elevation));
          items.Add(string.Format("{0,10:F7}", corr.gMoon));
          items.Add(string.Format("{0,10:F7}", corr.gSun));
          items.Add(string.Format("{0,10:F7}", corr.gTotal));

          writer.WriteLine(string.Join("\t", items.ToArray()));
          items.Clear();
        }

        writer.Flush();
        writer.Close();
        saveFileDialog.FileName = null;
        MessageBox.Show(@"File has been saved successfully",
                        @"Save Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
      }
    }

    private void OnToolStripButtonGenerateClick(object sender, EventArgs e)
    {
      if (dgvFileMode.Rows.Count == 0)
      {
        MessageBox.Show("The table is empty.",
                        "Data Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        return;
      }

      switch (tsComboBoxCoordSystem.SelectedIndex)
      {
        case 0:
          foreach (TidalRecord tidalCorrection in _corrections)
            if (tsComboBoxTimeZone.ComboBox != null)
            {
              TidalRecord result = Longman1959.Compute(tidalCorrection.Date,
                                                       TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                                                       tidalCorrection.YPosition,
                                                       tidalCorrection.XPosition,
                                                       tidalCorrection.Elevation);

              tidalCorrection.gMoon = result.gMoon;
              tidalCorrection.gSun = result.gSun;
              tidalCorrection.gTotal = result.gTotal;
            }

          break;

        case 1:
          foreach (TidalRecord tidalCorrection in _corrections)
            // Set the date to UTC and converting it to Modified Julian Date
            if (tsComboBoxTimeZone.ComboBox != null)
              if (tsComboBoxUTMZone.ComboBox != null)
              {
                UTMZone utmZone = tsComboBoxUTMZone.ComboBox.SelectedItem as UTMZone;
                IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
                if (utmZone != null)
                {
                  IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmZone.Zone,
                                                                                       utmZone.IsNorthHemisphere);
                  CoordinateTransformationFactory coordinateTransformationFactory = new CoordinateTransformationFactory();
                  ICoordinateTransformation trans = coordinateTransformationFactory.CreateFromCoordinateSystems(utm, geo);

                  double[] longlat = {tidalCorrection.XPosition, tidalCorrection.YPosition};
                  double[] eastNorth = trans.MathTransform.Transform(longlat);

                  Debug.WriteLine("{0}\t{1}", eastNorth[0], eastNorth[1]);

                  // Calculating tidal correction
                  TidalRecord result = Longman1959.Compute(tidalCorrection.Date,
                                                           TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                                                           eastNorth[1],
                                                           eastNorth[0],
                                                           tidalCorrection.Elevation);

                  tidalCorrection.gMoon = result.gMoon;
                  tidalCorrection.gSun = result.gSun;
                  tidalCorrection.gTotal = result.gTotal;
                }
              }

          break;
      }

      dgvFileMode.DataSource = _corrections;
      Width += 130;
      DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
      if (dataGridViewColumn != null)
        dataGridViewColumn.Visible = true;
    }

    private void OnTsComboBoxCoordSystemSelectedIndexChanged(object sender, EventArgs e)
    {
      Width -= 130;
      DataGridViewColumn GridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
      if (GridViewColumn != null)
        GridViewColumn.Visible = false;
      if (tsComboBoxCoordSystem.SelectedIndex == 0)
      {
        tsComboBoxUTMZone.Enabled = false;
        DataGridViewColumn gridViewColumn = dgvFileMode.Columns["col_xPos"];
        if (gridViewColumn != null)
        {
          gridViewColumn.HeaderText = @"Longitude";
          gridViewColumn.DefaultCellStyle.Format = "0.000000";
        }

        DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_yPos"];
        if (dataGridViewColumn != null)
        {
          dataGridViewColumn.HeaderText = @"Latitude";
          dataGridViewColumn.DefaultCellStyle.Format = "0.000000";
        }
      }

      else
      {
        tsComboBoxUTMZone.Enabled = true;
        DataGridViewColumn gridViewColumn = dgvFileMode.Columns["col_xPos"];
        if (gridViewColumn != null)
        {
          gridViewColumn.HeaderText = @"Easting";
          gridViewColumn.DefaultCellStyle.Format = "0.00";
        }

        DataGridViewColumn dataGridViewColumn = dgvFileMode.Columns["col_yPos"];
        if (dataGridViewColumn != null)
        {
          dataGridViewColumn.HeaderText = @"Northing";
          dataGridViewColumn.DefaultCellStyle.Format = "0.00";
        }
      }
    }
  }
}