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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBoxCoordSystem = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonGenerate = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsLabelTimeZone = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBoxTimeZone = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsComboBoxUTMZone = new System.Windows.Forms.ToolStripComboBox();
            this.dgvFileMode = new System.Windows.Forms.DataGridView();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gmoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gsun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_yPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colElevation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gTotalTidal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileMode)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsComboBoxCoordSystem,
            this.toolStripButtonGenerate});
            this.toolStrip1.Location = new System.Drawing.Point(10, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
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
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(87, 22);
            this.toolStripLabel1.Text = "Coordinates";
            // 
            // tsComboBoxCoordSystem
            // 
            this.tsComboBoxCoordSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsComboBoxCoordSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsComboBoxCoordSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsComboBoxCoordSystem.Name = "tsComboBoxCoordSystem";
            this.tsComboBoxCoordSystem.Size = new System.Drawing.Size(150, 25);
            this.tsComboBoxCoordSystem.SelectedIndexChanged += new System.EventHandler(this.tsComboBoxCoordSystem_SelectedIndexChanged);
            // 
            // toolStripButtonGenerate
            // 
            this.toolStripButtonGenerate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerate.Image")));
            this.toolStripButtonGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerate.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButtonGenerate.Name = "toolStripButtonGenerate";
            this.toolStripButtonGenerate.Size = new System.Drawing.Size(74, 22);
            this.toolStripButtonGenerate.Text = "Generate";
            this.toolStripButtonGenerate.Click += new System.EventHandler(this.toolStripButtonGenerate_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files Tab Delimited (*.txt)|*.txt|DAT Files Tab Delimited (*.dat)|*.dat";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip2.CanOverflow = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelTimeZone,
            this.tsComboBoxTimeZone,
            this.toolStripLabel2,
            this.tsComboBoxUTMZone});
            this.toolStrip2.Location = new System.Drawing.Point(10, 431);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(569, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsLabelTimeZone
            // 
            this.tsLabelTimeZone.Image = ((System.Drawing.Image)(resources.GetObject("tsLabelTimeZone.Image")));
            this.tsLabelTimeZone.Name = "tsLabelTimeZone";
            this.tsLabelTimeZone.Size = new System.Drawing.Size(86, 22);
            this.tsLabelTimeZone.Text = "Time Zone :";
            // 
            // tsComboBoxTimeZone
            // 
            this.tsComboBoxTimeZone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsComboBoxTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsComboBoxTimeZone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsComboBoxTimeZone.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.tsComboBoxTimeZone.Name = "tsComboBoxTimeZone";
            this.tsComboBoxTimeZone.Size = new System.Drawing.Size(220, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "Projection :";
            // 
            // tsComboBoxUTMZone
            // 
            this.tsComboBoxUTMZone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsComboBoxUTMZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsComboBoxUTMZone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsComboBoxUTMZone.Name = "tsComboBoxUTMZone";
            this.tsComboBoxUTMZone.Size = new System.Drawing.Size(160, 25);
            // 
            // dgvFileMode
            // 
            this.dgvFileMode.AllowUserToAddRows = false;
            this.dgvFileMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileMode.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFileMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFileMode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFileMode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileMode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Date,
            this.col_gmoon,
            this.col_gsun,
            this.col_xPos,
            this.col_yPos,
            this.colElevation,
            this.col_gTotalTidal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileMode.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFileMode.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileMode.Location = new System.Drawing.Point(13, 31);
            this.dgvFileMode.Name = "dgvFileMode";
            this.dgvFileMode.Size = new System.Drawing.Size(563, 386);
            this.dgvFileMode.TabIndex = 3;
            // 
            // col_Date
            // 
            this.col_Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "dd-MMM-yy HH:mm";
            this.col_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Date.HeaderText = "Date Time";
            this.col_Date.Name = "col_Date";
            // 
            // col_gmoon
            // 
            this.col_gmoon.DataPropertyName = "MoonTidal";
            this.col_gmoon.HeaderText = "g Moon (mGal)";
            this.col_gmoon.Name = "col_gmoon";
            this.col_gmoon.Visible = false;
            // 
            // col_gsun
            // 
            this.col_gsun.DataPropertyName = "SunTidal";
            this.col_gsun.HeaderText = "g Sun (mGal)";
            this.col_gsun.Name = "col_gsun";
            this.col_gsun.Visible = false;
            // 
            // col_xPos
            // 
            this.col_xPos.DataPropertyName = "XPosition";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.col_xPos.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_xPos.HeaderText = "X-Position";
            this.col_xPos.Name = "col_xPos";
            // 
            // col_yPos
            // 
            this.col_yPos.DataPropertyName = "YPosition";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.col_yPos.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_yPos.HeaderText = "Y-Position";
            this.col_yPos.Name = "col_yPos";
            // 
            // colElevation
            // 
            this.colElevation.DataPropertyName = "Elevation";
            dataGridViewCellStyle5.Format = "0.00";
            this.colElevation.DefaultCellStyle = dataGridViewCellStyle5;
            this.colElevation.HeaderText = "Elevation";
            this.colElevation.Name = "colElevation";
            // 
            // col_gTotalTidal
            // 
            this.col_gTotalTidal.DataPropertyName = "CorrectionTotal";
            dataGridViewCellStyle6.Format = "N5";
            dataGridViewCellStyle6.NullValue = null;
            this.col_gTotalTidal.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_gTotalTidal.HeaderText = "g tide (mGal)";
            this.col_gTotalTidal.Name = "col_gTotalTidal";
            this.col_gTotalTidal.Visible = false;
            // 
            // FromFileMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(589, 466);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvFileMode);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(735, 700);
            this.MinimumSize = new System.Drawing.Size(573, 500);
            this.Name = "FromFileMode";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GravTC - Read From File";
            this.Load += new System.EventHandler(this.FromFileMode_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsComboBoxCoordSystem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsLabelTimeZone;
        private System.Windows.Forms.ToolStripComboBox tsComboBoxTimeZone;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tsComboBoxUTMZone;
        private System.Windows.Forms.DataGridView dgvFileMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gmoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gsun;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_xPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_yPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colElevation;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gTotalTidal;
    }
}