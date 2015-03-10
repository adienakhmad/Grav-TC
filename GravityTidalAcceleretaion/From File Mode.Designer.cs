namespace GravityTidalCorrection
{
    partial class FromFileMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromFileMode));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxCoordSystem = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGenerate = new System.Windows.Forms.ToolStripButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dgvFileMode = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_yPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gTotalTidal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileMode)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxCoordSystem,
            this.toolStripSeparator2,
            this.toolStripButtonGenerate});
            this.toolStrip1.Location = new System.Drawing.Point(10, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "Coordinates";
            // 
            // toolStripComboBoxCoordSystem
            // 
            this.toolStripComboBoxCoordSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCoordSystem.Items.AddRange(new object[] {
            "WGS84 Geographic",
            "WGS84 UTM"});
            this.toolStripComboBoxCoordSystem.Name = "toolStripComboBoxCoordSystem";
            this.toolStripComboBoxCoordSystem.Size = new System.Drawing.Size(130, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonGenerate
            // 
            this.toolStripButtonGenerate.Image = global::GravityTidalCorrection.Properties.Resources.aboutIcon;
            this.toolStripButtonGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerate.Name = "toolStripButtonGenerate";
            this.toolStripButtonGenerate.Size = new System.Drawing.Size(74, 22);
            this.toolStripButtonGenerate.Text = "Generate";
            // 
            // dgvFileMode
            // 
            this.dgvFileMode.AllowUserToAddRows = false;
            this.dgvFileMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileMode.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFileMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFileMode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Date,
            this.col_xPos,
            this.col_yPos,
            this.col_gTotalTidal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileMode.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFileMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileMode.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileMode.Location = new System.Drawing.Point(10, 28);
            this.dgvFileMode.Name = "dgvFileMode";
            this.dgvFileMode.Size = new System.Drawing.Size(554, 419);
            this.dgvFileMode.TabIndex = 3;
            // 
            // col_Date
            // 
            this.col_Date.DataPropertyName = "Date";
            this.col_Date.HeaderText = "Date Time";
            this.col_Date.Name = "col_Date";
            // 
            // col_xPos
            // 
            this.col_xPos.DataPropertyName = "XPosition";
            this.col_xPos.HeaderText = "X-Position";
            this.col_xPos.Name = "col_xPos";
            // 
            // col_yPos
            // 
            this.col_yPos.DataPropertyName = "YPosition";
            this.col_yPos.HeaderText = "Y-Position";
            this.col_yPos.Name = "col_yPos";
            // 
            // col_gTotalTidal
            // 
            this.col_gTotalTidal.DataPropertyName = "CorrectionTotal";
            dataGridViewCellStyle1.Format = "N5";
            dataGridViewCellStyle1.NullValue = null;
            this.col_gTotalTidal.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_gTotalTidal.HeaderText = "g Total (mGal)";
            this.col_gTotalTidal.Name = "col_gTotalTidal";
            // 
            // FromFileMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 457);
            this.Controls.Add(this.dgvFileMode);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FromFileMode";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.Text = "From_File_Mode";
            this.Load += new System.EventHandler(this.FromFileMode_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCoordSystem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerate;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvFileMode;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_xPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_yPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gTotalTidal;
    }
}