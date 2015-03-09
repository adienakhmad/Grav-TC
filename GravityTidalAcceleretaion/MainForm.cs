using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DotNetPerls;
using GravityTidalCorrection.Properties;
using ZedGraph;

namespace GravityTidalCorrection
{
    public partial class MainForm : Form
    {
        private bool _onLoadDone;
        private double _lat;
        private double _lon;
        private double _elev;
        private double _duration;
        private DateTime _beginInUtc;
        private DateTime _endInUtc;
        private double _utcOffset;
        private double _timeInterval;
        private List<TidalCorrection> corrections;
 
       public MainForm()
        {
            InitializeComponent();
        }

        private void DrawGraph(ZedGraphControl zgc, List<TidalCorrection> corrlist,  double multiplier, int xCol, int yCol,
               string xAxisTitle, string yAxisTitle, string legend, Color clr, bool symbol)
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

               foreach ( TidalCorrection corr in corrlist )
               {
                   plotList.Add(corr.Date.ToOADate(),corr.TotalTidal);
               }

               LineItem myCurve = myPane.AddCurve(legend, plotList, clr, SymbolType.Square);
               zgc.AxisChange();

               myCurve.Symbol.IsVisible = symbol;
               myCurve.Symbol.Size = 5;
               myCurve.Line.Width = 1.5f;
               myCurve.Line.IsSmooth = true;
               myCurve.Line.IsAntiAlias = true;

               zgc.Refresh();
         }

        private void SetSize(ZedGraphControl zgc)
        {
               zgc.Location = new Point(10, 10);
               // Leave a small margin around the outside of the control
               zgc.Size = new Size(ClientRectangle.Width - 20,
                                       ClientRectangle.Height - 20);
        }
       

        private bool IsInputInvalid(double elev, double duration, double interval)
        {
            bool valid = true;
            if (Math.Abs(elev) < 5e-6)
            {
                WriteErrorLog("Elevation cannot be zero.");
                
                valid = false;
            }
            if (duration < 0.0)
            {
                WriteErrorLog("End time is earlier than begin time.");
                valid = false;
            }
            if (Math.Abs(interval) < 5e-6)
            {
                WriteErrorLog("Time interval cannot be zero. ");
                valid = false;
            }

            return !valid;
        }

        private void WriteErrorLog(string sentence)
        {
            textBoxInfo.AppendText(string.Format("{2}ERROR: {0}\t({1:yyyy-MM-dd HH:mm:ss})",sentence,DateTime.Now,Environment.NewLine));
        }

        private void WriteLineConsoleLog(string sentence)
        {
            textBoxInfo.AppendText(Environment.NewLine+sentence);
        }

        private void WriteConsoleLog(string sentence)
        {
            textBoxInfo.AppendText(sentence);
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
                writer.WriteLine("# Latitude\t: {0:F4}", _lat);
                writer.WriteLine("# Longitude\t: {0:F4}", _lon);
                writer.WriteLine("# Elevation\t: {0:F2} meters", _elev);
                writer.WriteLine("# ------------------------------------------------------");
                writer.WriteLine("# Date Time, g Moon (mGal), g Sun (mGal), g Total (mGal)");
            }

            List<string> items = new List<string>();
            foreach (TidalCorrection corr in corrections)
            {
                // the first is a date column
                //items.Add(String.Format("{0:dd-MMM-yyyy HH:mm:ss}", corr.Date));
                items.Add(String.Format("{0:dd-MMM-yyyy HH:mm:ss}", corr.Date));
                items.Add(String.Format("{0,10:F7}", corr.MoonTidal));
                items.Add(String.Format("{0,10:F7}", corr.SunTidal));
                items.Add(String.Format("{0,10:F7}", corr.TotalTidal));
                
                writer.WriteLine(String.Join("\t", items.ToArray()));
                items.Clear();
            }

            writer.Flush();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            // Latitude, Longitude, Elevation Informaton
            _lat = Convert.ToDouble(numLatDeg.Value + (numLatMin.Value / (decimal)60.0) + (numLatSec.Value / (decimal)3600.0));
            if (cboxLatSign.SelectedIndex == 1) // if latitude sign is 'S' then apply minus value
            {
                _lat = _lat * -1.0;
            }
            _lon = Convert.ToDouble(numLongDeg.Value + (numLongMin.Value / (decimal)60.0) + (numLongSec.Value / (decimal)3600.0));
            if (cboxLonSign.SelectedIndex == 1) // if longitude sign is 'W' then apply minus value
            {
                _lon = _lon * -1.0;
            }

            // elevation in metres
            _elev = Convert.ToDouble(numElevation.Value);

            // duration in minutes
            _duration = (datepickEnd.Value - datepickBegin.Value).TotalMinutes;

            // convert input to UTC+00
            _beginInUtc = TimeZoneInfo.ConvertTime(datepickBegin.Value,
                TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()), TimeZoneInfo.Utc);

            _endInUtc = TimeZoneInfo.ConvertTime(datepickEnd.Value,
                TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()), TimeZoneInfo.Utc);

            // offset from UTC in hours
            _utcOffset = TimeZoneInfo.FindSystemTimeZoneById((string)cboxTimeZone.SelectedValue)
                    .GetUtcOffset(datepickBegin.Value)
                    .TotalHours;

            // interval
            _timeInterval = Convert.ToDouble(numInterval.Value);

            // Checks the input, if input is invalid, it return void.
            if (IsInputInvalid(_elev, _duration, _timeInterval))
            {
                dataGridView1.DataSource = null;
                return;
            }


            // Start writing to list and display on gridview

            corrections.Clear();
            double fmjd = VerticalTide.UTC2ModifiedJulian(_beginInUtc);
            double minute = 0;

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            for (var i = 0; minute <= _duration; i++)
            {
                var tidal = VerticalTide.TideCalcGal(fmjd + minute / 1440.0, _lat, _lon, _elev, _utcOffset);
                corrections.Add(tidal);
                minute += _timeInterval;
            }

            // Binding to datagridview
            dataGridView1.DataSource = corrections;

            // plotting the chart

            DrawGraph(zedGraphControl1,corrections,1e3,1,4,"Date Time","g0 (microGals)","Calculated Tides",Color.DeepSkyBlue,false);

            Cursor.Current = Cursors.Default;

            // write to console log
            textBoxInfo.AppendText("Processing . . . .\r\n");
            textBoxInfo.AppendText(string.Format("Time Zone\t: {0} (UTC{1:'+'00;'-'00}) \r\n", cboxTimeZone.SelectedValue, _utcOffset));
            textBoxInfo.AppendText(string.Format("Begin\t\t: {0}\t({1} in UTC+00)\r\n", datepickBegin.Value, _beginInUtc));
            textBoxInfo.AppendText(string.Format("End\t\t: {0}\t({1} in UTC+00) \r\n", datepickEnd.Value, _endInUtc));
            textBoxInfo.AppendText(string.Format("Interval\t: {0:F2} minutes \r\n", _timeInterval));
            textBoxInfo.AppendText(string.Format("Time Span\t: {0:F2} minutes \r\n", _duration));
            textBoxInfo.AppendText(string.Format("Latitude\t: {0:F4}°\r\nLongitude\t: {1:F4}°\r\n", _lat, _lon));
            textBoxInfo.AppendText(string.Format("Elevation\t: {0:F2} meters\r\n", _elev));
            textBoxInfo.AppendText("Completed... ");
            WriteLineConsoleLog(string.Format("{0} data point(s).", dataGridView1.RowCount));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            corrections = new List<TidalCorrection>();
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

            // Tell the other if onload event is finished
            _onLoadDone = true;
            WriteConsoleLog("Welcome...");

        }

        private void cboxTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_onLoadDone)
            {
                string tz = cboxTimeZone.SelectedValue.ToString();
                WriteLineConsoleLog(string.Format("Time Zone changed to {0} (UTC{1:'+'00;'-'00}).", cboxTimeZone.SelectedValue, TimeZoneInfo.FindSystemTimeZoneById(tz).GetUtcOffset(datepickBegin.Value).TotalHours));
            }

        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
            {
                Export(writer, true);
            }

            WriteLineConsoleLog(string.Format("Successfully saved to {0}",saveFileDialog.FileName));
            saveFileDialog.FileName = null;
        }

        private void CopyTableToClipBoard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            WriteLineConsoleLog("Table copied to clipboard.");
        }

        private void saveAsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyTableToClipBoard();
        }

        private void useDegMinSec_Click(object sender, EventArgs e)
        {
            useDegMinSecToolStrip.Checked = !useDegMinSecToolStrip.Checked;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BetterDialog.ShowDialog("About Grav-TC", "Gravity Tidal Correction v1.0",
                "This program can be used to generate tide corrections table for gravity data processing. " +
                "This program is ported from TIDES program by J. L. Ahern which was originally written in QBASIC.\n\nThe algorithm used is that of Longman, I.M., Formulas for Computing the Tidal Acceleration Due to the Moon and the Sun., J. Geoph. Res., 1959.\n\n" +
                "Copyright © 2014 Adien Akhmad\nDepartment of Geophysics, Universitas Gadjah Mada. All rights reserved.", null, "Close",
                (Image)Resources.ResourceManager.GetObject("aboutIcon"));
        }

        private void useDegMinSec_CheckedChanged(object sender, EventArgs e)
        {
            switch (useDegMinSecToolStrip.Checked)
            {
                case false:
                    numLongMin.Visible = false;
                    numLongSec.Visible = false;
                    numLatMin.Visible = false;
                    numLatSec.Visible = false;

                    labelLatMin.Visible = false;
                    labelLatSec.Visible = false;
                    labelLonMin.Visible = false;
                    labelLonSec.Visible = false;

                    numLatDeg.Width += 50;
                    numLongDeg.Width += 50;

                    numLatDeg.DecimalPlaces = 4;
                    numLongDeg.DecimalPlaces = 4;

                    numLongMin.Value = 0;
                    numLongSec.Value = 0;
                    numLatMin.Value = 0;
                    numLatSec.Value = 0;

                    WriteLineConsoleLog("Coordinate input format changed to decimal format.");

                    break;
                default:
                    numLongMin.Visible = true;
                    numLongSec.Visible = true;
                    numLatMin.Visible = true;
                    numLatSec.Visible = true;

                    labelLatMin.Visible = true;
                    labelLatSec.Visible = true;
                    labelLonMin.Visible = true;
                    labelLonSec.Visible = true;

                    numLatDeg.Width -= 50;
                    numLongDeg.Width -= 50;
                    numLatDeg.DecimalPlaces = 0;
                    numLongDeg.DecimalPlaces = 0;

                    // Flooring value after switch back to deg min sec
                    numLatDeg.Value = Decimal.Floor(numLatDeg.Value);
                    numLongDeg.Value = Decimal.Floor(numLongDeg.Value);

                    WriteLineConsoleLog("Coordinate input format changed to degrees minutes seconds format.");
                    break;
            }
        }

        private void readGobsgobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFilegObserved.ShowDialog();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                saveAsToolStripMenuItem.Enabled = false;
                copyTableToolStripMenuItem.Enabled = false;
                zedGraphControl1.Visible = false;
            }

            else
            {
                saveAsToolStripMenuItem.Enabled = true;
                copyTableToolStripMenuItem.Enabled = true;
                zedGraphControl1.Visible = true;
            }
        }
    }
}
