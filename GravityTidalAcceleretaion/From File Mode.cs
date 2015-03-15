using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileHelpers;
using JR.Utils.GUI.Forms;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace GravityTidalCorrection
{
    public partial class FromFileMode : Form
    {
        private List<TidalCorrection> _corrections;
        public FromFileMode()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _corrections = new List<TidalCorrection>();

                var engine = new FileHelperEngine(typeof(TidalCorrection));
                engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

                Cursor.Current = Cursors.WaitCursor;
                Enabled = false;
                var tides = engine.ReadFile(openFileDialog.FileName) as TidalCorrection[];

                Enabled = true;
                Cursor.Current = DefaultCursor;

                if (engine.ErrorManager.HasErrors)
                {
                    if (engine.ErrorManager.ErrorCount > 99)
                    {
                        MessageBox.Show(string.Format("Found {0} errors at reading the file, check error.log for detailed information.", engine.ErrorManager.ErrorCount), @"File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        engine.ErrorManager.SaveErrors("error.log");
                    }

                    else
                    {
                        string error =
                            string.Format(
                                "Possible format violation occured. There are {0} errors out of {1} records.\n\n",
                                engine.ErrorManager.ErrorCount, engine.TotalRecords);

                        foreach (ErrorInfo err in engine.ErrorManager.Errors)
                        {
                            error += string.Format("Line {0:00}: {1}{2}", err.LineNumber,
                                err.ExceptionInfo.Message, Environment.NewLine);
                        }

                        FlexibleMessageBox.MAX_HEIGHT_FACTOR = 0.3;
                        FlexibleMessageBox.Show(error, "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (tides != null) _corrections = tides.ToList();

                dgvFileMode.DataSource = _corrections;
                Width -= 122;
                var dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var writer = new StreamWriter(saveFileDialog.FileName);

                    writer.WriteLine("# ------------------------------------------------------");
                    writer.WriteLine("# Output from Grav-TC : Tidal Correction");
                    writer.WriteLine("# ------------------------------------------------------");
                if (tsComboBoxTimeZone.ComboBox != null)
                {
                    var selectedTimeZone = tsComboBoxTimeZone.ComboBox.SelectedItem as TimeZoneInfo;
                    if (selectedTimeZone != null) writer.WriteLine("# Time Zone\t: {0}", selectedTimeZone.DisplayName);
                }
                writer.WriteLine("# ------------------------------------------------------");
                    writer.WriteLine("# Date Time, X-Position, Y-Position g Moon (mGal), g Sun (mGal), g Total (mGal)");
                

                var items = new List<string>();

                foreach (var corr in _corrections)
                {
                    // the first is a date column
                    items.Add(String.Format("{0:dd-MMM-yyyy HH:mm:ss}", corr.Date));
                    items.Add(String.Format("{0,10:F6}",corr.XPosition));
                    items.Add(String.Format("{0,10:F6}", corr.YPosition));
                    items.Add(String.Format("{0,7:F2}",corr.Elevation));
                    items.Add(String.Format("{0,10:F7}", corr.MoonTidal));
                    items.Add(String.Format("{0,10:F7}", corr.SunTidal));
                    items.Add(String.Format("{0,10:F7}", corr.CorrectionTotal));

                    writer.WriteLine(String.Join("\t", items.ToArray()));
                    items.Clear();
                }

                writer.Flush();
                MessageBox.Show(@"File saved successfully", @"Save Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void FromFileMode_Load(object sender, EventArgs e)
        {
            tsComboBoxCoordSystem.Items.Add("WGS84 Geographic");
            tsComboBoxCoordSystem.Items.Add("WGS84 UTM");
            tsComboBoxCoordSystem.SelectedIndex = 0;

            var timeZones = TimeZoneInfo.GetSystemTimeZones();

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

        private void toolStripButtonGenerate_Click(object sender, EventArgs e)
        {
            if (dgvFileMode.Rows.Count == 0) return;

            switch (tsComboBoxCoordSystem.SelectedIndex)
            {
                case 0:
                   foreach (var tidalCorrection in _corrections)
                    {
                        if (tsComboBoxTimeZone.ComboBox != null)
                        {
                            var dateInUtc = TimeZoneInfo.ConvertTime(tidalCorrection.Date,
                                TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                                TimeZoneInfo.Utc);

                            var utcOffset =
                                TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString())
                                    .GetUtcOffset(tidalCorrection.Date)
                                    .TotalHours;

                            var fmjd = TidalAcceleration.UTC2ModifiedJulian(dateInUtc);
                        
                            var result = TidalAcceleration.Calculate(fmjd, tidalCorrection.YPosition,
                                tidalCorrection.XPosition, tidalCorrection.Elevation, utcOffset);

                            tidalCorrection.MoonTidal = result.MoonTidal;
                            tidalCorrection.SunTidal = result.SunTidal;
                            tidalCorrection.CorrectionTotal = result.CorrectionTotal;
                        }
                    }
                    break;

                case 1:
                    foreach (var tidalCorrection in _corrections)
                    {
                        // Set the date to UTC and converting it to Modified Julian Date
                        if (tsComboBoxTimeZone.ComboBox != null)
                        {
                            var dateInUtc = TimeZoneInfo.ConvertTime(tidalCorrection.Date,
                                TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                                TimeZoneInfo.Utc);

                            var utcOffset =
                                TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString())
                                    .GetUtcOffset(tidalCorrection.Date)
                                    .TotalHours;

                            var fmjd = TidalAcceleration.UTC2ModifiedJulian(dateInUtc);

                            // Projection of coordinates

                            if (tsComboBoxUTMZone.ComboBox != null)
                            {
                                var  utmZone = tsComboBoxUTMZone.ComboBox.SelectedItem as UTMZone;
                                IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
                                if (utmZone != null)
                                {
                                    IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM( utmZone.Zone,
                                        utmZone.IsNorthHemisphere);
                                    var coordinateTransformationFactory = new CoordinateTransformationFactory();
                                    ICoordinateTransformation trans = coordinateTransformationFactory.CreateFromCoordinateSystems(utm, geo);

                                    double[] longlat = {tidalCorrection.XPosition, tidalCorrection.YPosition};
                                    double[] eastNorth = trans.MathTransform.Transform(longlat);

                                    Debug.WriteLine(string.Format("{0}\t{1}",eastNorth[0],eastNorth[1]));

                                    // Calculating tidal correction
                                    var result = TidalAcceleration.Calculate(fmjd, eastNorth[1],
                                        eastNorth[0], tidalCorrection.Elevation, utcOffset);

                                    tidalCorrection.MoonTidal = result.MoonTidal;
                                    tidalCorrection.SunTidal = result.SunTidal;
                                    tidalCorrection.CorrectionTotal = result.CorrectionTotal;
                                }
                            }
                        }
                    }

                    break;
            }

            dgvFileMode.DataSource = _corrections;
            Width += 122;
            var dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = true;
        }

        private void tsComboBoxCoordSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsComboBoxCoordSystem.SelectedIndex == 0)
            {
               
                tsComboBoxUTMZone.Enabled = false;
                var gridViewColumn = dgvFileMode.Columns["col_xPos"];
                if (gridViewColumn != null)
                {
                    gridViewColumn.HeaderText = @"Longitude";
                    gridViewColumn.DefaultCellStyle.Format = "0.000000";
                }
                var dataGridViewColumn = dgvFileMode.Columns["col_yPos"];
                if (dataGridViewColumn != null)
                {
                    dataGridViewColumn.HeaderText = @"Latitude";
                    dataGridViewColumn.DefaultCellStyle.Format = "0.000000";
                }
            }

            else
            {
                tsComboBoxUTMZone.Enabled = true;
                var gridViewColumn = dgvFileMode.Columns["col_xPos"];
                if (gridViewColumn != null)
                {
                    gridViewColumn.HeaderText = @"Easting";
                    gridViewColumn.DefaultCellStyle.Format = "0.00";
                }
                var dataGridViewColumn = dgvFileMode.Columns["col_yPos"];
                if (dataGridViewColumn != null)
                {
                    dataGridViewColumn.HeaderText = @"Northing";
                    dataGridViewColumn.DefaultCellStyle.Format = "0.00";
                }
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            dgvFileMode.SelectAll();
            DataObject dataObj = dgvFileMode.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            MessageBox.Show(@"Table copied to clipboard.", @"Copy Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
