using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileHelpers;

namespace GravityTidalCorrection
{
    public partial class FromFileMode : Form
    {
        private List<TidalCorrection> tDatePositions; 
        public FromFileMode()
        {
            InitializeComponent();
        }

        public FromFileMode(UTMZone zone)
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            tDatePositions = new List<TidalCorrection>();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tDatePositions.Clear();
                FileHelperEngine engine = new FileHelperEngine(typeof(TidalCorrection));
                TidalCorrection[] tides = engine.ReadFile(openFileDialog.FileName) as TidalCorrection[];
                if (tides != null) tDatePositions = tides.ToList();

                dgvFileMode.DataSource = tDatePositions;
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
            switch (tsComboBoxCoordSystem.SelectedIndex)
            {
                case 1:
                    break;
            }
        }
    }
}
