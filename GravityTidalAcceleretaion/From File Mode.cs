using System;
using System.Collections.Generic;
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
        private List<TidalDatePosition> tdateDatePositions; 
        public FromFileMode()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            tdateDatePositions = new List<TidalDatePosition>();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                tdateDatePositions.Clear();
                FileHelperEngine engine = new FileHelperEngine(typeof(TidalDatePosition));
                TidalDatePosition[] tides = engine.ReadFile(openFileDialog.FileName) as TidalDatePosition[];
                if (tides != null) tdateDatePositions = tides.ToList();

                dgvFileMode.DataSource = tdateDatePositions;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void FromFileMode_Load(object sender, EventArgs e)
        {
            toolStripComboBoxCoordSystem.SelectedIndex = 0;
        }
    }
}
