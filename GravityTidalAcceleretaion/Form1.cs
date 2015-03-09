using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DotNetPerls;
using GravityTidalCorrection.Properties;
using ZedGraph;

namespace GravityTidalCorrection
{
    public partial class Form1 : Form
    {
        private bool OnLoadDone;
        private DataTable dtable;
        private double lat;
        private double lon;
        private double elev;
        private double duration;
        private DateTime beginInUtc;
        private DateTime endInUtc;
        private double utcOffset;
        private double interval;
       public Form1()
        {
            InitializeComponent();
        }

        private void DrawGraph(ZedGraphControl zgc, DataTable table,double multiplier, int xCol, int yCol, string title,
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

               PointPairList list = new PointPairList();

               foreach (DataRow drow in table.Rows)
               {
                   DateTime date = (DateTime) drow[xCol - 1];
                   list.Add(date.ToOADate(), (double)drow[yCol - 1] * multiplier);
               }

               LineItem myCurve = myPane.AddCurve(legend, list, clr, SymbolType.Square);
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
                WriteErrorLog("Interval cannot be zero. ");
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
                List<string> headerValues = new List<string>();
                foreach (DataColumn column in dtable.Columns)
                {
                    headerValues.Add(column.ColumnName);
                }

                writer.WriteLine("# ------------------------------------------------------");
                writer.WriteLine("# Output from Grav-TC : Tidal Correction");
                writer.WriteLine("# ------------------------------------------------------");
                writer.WriteLine("# Time Zone\t: {0} (UTC{1:'+'00;'-'00})", cboxTimeZone.SelectedValue, utcOffset);
                writer.WriteLine("# Begin\t\t: {0}", datepickBegin.Value);
                writer.WriteLine("# End\t\t: {0}\t", datepickEnd.Value);
                writer.WriteLine("# Interval\t: {0:F2} minutes", interval);
                writer.WriteLine("# Time Span\t: {0:F2} minutes", duration);
                writer.WriteLine("# Latitude\t: {0:F4}", lat);
                writer.WriteLine("# Longitude\t: {0:F4}", lon);
                writer.WriteLine("# Elevation\t: {0:F2} meters", elev);
                writer.WriteLine("# ------------------------------------------------------");
                writer.Write("# ");
                
                writer.WriteLine(String.Join(",", headerValues.ToArray()));
            }

            List<string> items = new List<string>();
            foreach (DataRow row in dtable.Rows)
            {
                // the first is a date column
                string str = String.Format("{0:dd-MM-yyyy HH:mm:ss}", row[0]);
                items.Add(str);
                
                // the rest is number column
                for (int i = 1; i < dtable.Columns.Count; i++)
                {
                    str = String.Format("{0:G7}", double.Parse(row[i].ToString()));
                    items.Add(str);
                }

                writer.WriteLine(String.Join("\t", items.ToArray()));
                items.Clear();
            }

            writer.Flush();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            // Latitude, Longitude, Elevation Informaton
            lat = Convert.ToDouble(numLatDeg.Value + (numLatMin.Value / (decimal)60.0) + (numLatSec.Value / (decimal)3600.0));
            if (cboxLatSign.SelectedIndex == 1) // if latitude sign is 'S' then apply minus value
            {
                lat = lat * -1.0;
            }
            lon = Convert.ToDouble(numLongDeg.Value + (numLongMin.Value / (decimal)60.0) + (numLongSec.Value / (decimal)3600.0));
            if (cboxLonSign.SelectedIndex == 1) // if longitude sign is 'W' then apply minus value
            {
                lon = lon * -1.0;
            }

            // the algorithm used WEST Longitude as positive, so I had to reverse it first
            //lon = -lon;
            elev = Convert.ToDouble(numElevation.Value);

            // duration in minutes
            duration = (datepickEnd.Value - datepickBegin.Value).TotalMinutes;

            // convert input to UTC+00
            beginInUtc = TimeZoneInfo.ConvertTime(datepickBegin.Value,
                TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()), TimeZoneInfo.Utc);

            endInUtc = TimeZoneInfo.ConvertTime(datepickEnd.Value,
                TimeZoneInfo.FindSystemTimeZoneById(cboxTimeZone.SelectedValue.ToString()), TimeZoneInfo.Utc);

            // offset from UTC in hours
            utcOffset = TimeZoneInfo.FindSystemTimeZoneById((string)cboxTimeZone.SelectedValue)
                    .GetUtcOffset(datepickBegin.Value)
                    .TotalHours;

            // interval
            interval = Convert.ToDouble(numInterval.Value);

            // Checks the input, if input is invalid, it return void.
            if (IsInputInvalid(elev, duration, interval))
            {
                dataGridView1.DataSource = null;
                return;
            }


            // writing to datatable

            dtable.Rows.Clear();
            double fmjd = VerticalTide.UtcToModifiedJulian(beginInUtc);
            double minute = 0;

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            for (var i = 0; minute <= duration; i++)
            {
                var workRow = dtable.NewRow();

                var tidal = VerticalTide.TideCalcGal(fmjd + minute / 1440.0, lat, lon, elev, utcOffset);

                workRow[0] = tidal.Date;
                workRow[1] = tidal.MoonTidal;
                workRow[2] = tidal.SunTidal;
                workRow[3] = tidal.TotalTidal;
                dtable.Rows.Add(workRow);

                minute += interval;
            }

            // Binding to datagridview
            dataGridView1.DataSource = dtable;
            dataGridView1.Columns[0].DefaultCellStyle.Format = "dd-MMM-yy HH:mm";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // plotting the chart

            DrawGraph(zedGraphControl1,dtable,1e3,1,4,"Test","Date Time","g0 (microGals)","Calculated Tides",Color.DeepSkyBlue,false);

            Cursor.Current = Cursors.Default;

            // write to console log
            textBoxInfo.Clear();
            textBoxInfo.AppendText("Processing . . . .\r\n");
            textBoxInfo.AppendText(string.Format("Time Zone\t: {0} (UTC{1:'+'00;'-'00}) \r\n", cboxTimeZone.SelectedValue, utcOffset));
            textBoxInfo.AppendText(string.Format("Begin\t\t: {0}\t({1} in UTC+00)\r\n", datepickBegin.Value, beginInUtc));
            textBoxInfo.AppendText(string.Format("End\t\t: {0}\t({1} in UTC+00) \r\n", datepickEnd.Value, endInUtc));
            textBoxInfo.AppendText(string.Format("Interval\t: {0:F2} minutes \r\n", interval));
            textBoxInfo.AppendText(string.Format("Time Span\t: {0:F2} minutes \r\n", duration));
            textBoxInfo.AppendText(string.Format("Latitude\t: {0:F4}°\r\nLongitude\t: {1:F4}°\r\n", lat, lon));
            textBoxInfo.AppendText(string.Format("Elevation\t: {0:F2} meters\r\n", elev));
            textBoxInfo.AppendText("Completed... ");
            WriteLineConsoleLog(string.Format("{0} data point(s).", dataGridView1.RowCount));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSize(zedGraphControl1);
            zedGraphControl1.Visible = false;
            
            // Create Data Table
            dtable = new DataTable();
            
                DataColumn myDataColumn;

                // Create First Column
                myDataColumn = new DataColumn { DataType = Type.GetType("System.DateTime"), ColumnName = "Date Time"};
                dtable.Columns.Add(myDataColumn);

                // Create second column.
                myDataColumn = new DataColumn { DataType = Type.GetType("System.Double"), ColumnName = "g Moon (mGal)" };
                dtable.Columns.Add(myDataColumn);

                // Create third column.
                myDataColumn = new DataColumn { DataType = Type.GetType("System.Double"), ColumnName = "g Sun (mGal)" };
                dtable.Columns.Add(myDataColumn);

                // Create 4th column.
                myDataColumn = new DataColumn { DataType = Type.GetType("System.Double"), ColumnName = "g Total (mGal)" };
                dtable.Columns.Add(myDataColumn);



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
            OnLoadDone = true;
            WriteConsoleLog("Welcome...");

        }

        private void cboxTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnLoadDone)
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
