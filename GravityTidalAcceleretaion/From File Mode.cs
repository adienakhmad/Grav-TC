using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DotNetPerls;
using Excel;
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

                FileHelperEngine engine = new FileHelperEngine(typeof(TidalCorrection));
                engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

                Cursor.Current = Cursors.WaitCursor;
                this.Enabled = false;
                TidalCorrection[] tides = engine.ReadFile(openFileDialog.FileName) as TidalCorrection[];

                this.Enabled = true;
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
                var dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
                if (dataGridViewColumn != null)
                    dataGridViewColumn.Visible = false;
            
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void FromFileMode_Load(object sender, EventArgs e)
        {
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

        private void toolStripButtonGenerate_Click(object sender, EventArgs e)
        {
            if (dgvFileMode.Rows.Count == 0) return;

            DataGridViewColumn dataGridViewColumn;
            switch (tsComboBoxCoordSystem.SelectedIndex)
            {
                case 0:
                   foreach (var tidalCorrection in _corrections)
                    {
                        var dateInUtc = TimeZoneInfo.ConvertTime(tidalCorrection.Date,
                            TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                            TimeZoneInfo.Utc);

                       var utcOffset =
                            TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString())
                                .GetUtcOffset(tidalCorrection.Date)
                                .TotalHours;

                       var fmjd = VerticalTide.UTC2ModifiedJulian(dateInUtc);
                        
                        var result = VerticalTide.TideCalcGal(fmjd, tidalCorrection.YPosition,
                            tidalCorrection.XPosition, tidalCorrection.Elevation, utcOffset);

                        tidalCorrection.MoonTidal = result.MoonTidal;
                        tidalCorrection.SunTidal = result.SunTidal;
                        tidalCorrection.CorrectionTotal = result.CorrectionTotal;
                    }

                    dgvFileMode.DataSource = _corrections;
                    dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = true;

                    break;

                case 1:
                    foreach (var tidalCorrection in _corrections)
                    {
                        // Set the date to UTC and converting it to Modified Julian Date
                        var dateInUtc = TimeZoneInfo.ConvertTime(tidalCorrection.Date,
                            TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString()),
                            TimeZoneInfo.Utc);

                        var utcOffset =
                             TimeZoneInfo.FindSystemTimeZoneById(tsComboBoxTimeZone.ComboBox.SelectedValue.ToString())
                                 .GetUtcOffset(tidalCorrection.Date)
                                 .TotalHours;

                        var fmjd = VerticalTide.UTC2ModifiedJulian(dateInUtc);

                        // Projection of coordinates

                        var utmzone = tsComboBoxUTMZone.ComboBox.SelectedItem as UTMZone;
                        IGeographicCoordinateSystem geo = GeographicCoordinateSystem.WGS84;
                        IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone.Zone,
                            utmzone.IsNorthHemisphere);
                        CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();
                        ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(utm, geo);

                        double[] longlat = {tidalCorrection.XPosition, tidalCorrection.YPosition};
                        double[] east_north = trans.MathTransform.Transform(longlat);

                        Debug.WriteLine(string.Format("{0}\t{1}",east_north[0],east_north[1]));

                        // Calculating tidal correction
                        var result = VerticalTide.TideCalcGal(fmjd, east_north[1],
                            east_north[0], tidalCorrection.Elevation, utcOffset);

                        tidalCorrection.MoonTidal = result.MoonTidal;
                        tidalCorrection.SunTidal = result.SunTidal;
                        tidalCorrection.CorrectionTotal = result.CorrectionTotal;
                    }

                    dgvFileMode.DataSource = _corrections;
                    dataGridViewColumn = dgvFileMode.Columns["col_gTotalTidal"];
                    if (dataGridViewColumn != null)
                        dataGridViewColumn.Visible = true;

                    break;
            }
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
    }
}
