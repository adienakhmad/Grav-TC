namespace GravityTidalCorrection
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainerLeftRight = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupLocation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.numLatDeg = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLatMin = new System.Windows.Forms.NumericUpDown();
            this.labelLatMin = new System.Windows.Forms.Label();
            this.numLatSec = new System.Windows.Forms.NumericUpDown();
            this.labelLatSec = new System.Windows.Forms.Label();
            this.cboxLatSign = new System.Windows.Forms.ComboBox();
            this.labelLonTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.numLongDeg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numLongMin = new System.Windows.Forms.NumericUpDown();
            this.labelLonMin = new System.Windows.Forms.Label();
            this.numLongSec = new System.Windows.Forms.NumericUpDown();
            this.labelLonSec = new System.Windows.Forms.Label();
            this.cboxLonSign = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.numElevation = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxTimeZone = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datepickBegin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.datepickEnd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.splitContainerTableInfoWindow = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFilegObserved = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readGobsgobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.useDegMinSecToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            
            this.splitContainerLeftRight.Panel1.SuspendLayout();
            this.splitContainerLeftRight.Panel2.SuspendLayout();
            this.splitContainerLeftRight.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupLocation.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            
            this.flowLayoutPanel2.SuspendLayout();
            
            this.flowLayoutPanel5.SuspendLayout();
            
            this.groupTime.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            
            this.splitContainerTableInfoWindow.Panel1.SuspendLayout();
            this.splitContainerTableInfoWindow.Panel2.SuspendLayout();
            this.splitContainerTableInfoWindow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            
            this.tabPageChart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.splitContainerLeftRight);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(761, 481);
            this.mainPanel.TabIndex = 1;
            // 
            // splitContainerLeftRight
            // 
            this.splitContainerLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftRight.IsSplitterFixed = true;
            this.splitContainerLeftRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftRight.Name = "splitContainerLeftRight";
            // 
            // splitContainerLeftRight.Panel1
            // 
            this.splitContainerLeftRight.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainerLeftRight.Panel2
            // 
            this.splitContainerLeftRight.Panel2.Controls.Add(this.splitContainerTableInfoWindow);
            this.splitContainerLeftRight.Size = new System.Drawing.Size(761, 481);
            this.splitContainerLeftRight.SplitterDistance = 264;
            this.splitContainerLeftRight.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.groupLocation);
            this.flowLayoutPanel1.Controls.Add(this.groupTime);
            this.flowLayoutPanel1.Controls.Add(this.buttonGo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 481);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupLocation
            // 
            this.groupLocation.Controls.Add(this.flowLayoutPanel6);
            this.groupLocation.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLocation.Location = new System.Drawing.Point(13, 13);
            this.groupLocation.Name = "groupLocation";
            this.groupLocation.Padding = new System.Windows.Forms.Padding(15, 10, 3, 3);
            this.groupLocation.Size = new System.Drawing.Size(238, 175);
            this.groupLocation.TabIndex = 10;
            this.groupLocation.TabStop = false;
            this.groupLocation.Text = "Location";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel6.Controls.Add(this.labelLonTitle);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel6.Controls.Add(this.label14);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel6.Location = new System.Drawing.Point(15, 23);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(220, 149);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Latitude";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.numLatDeg);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.numLatMin);
            this.flowLayoutPanel3.Controls.Add(this.labelLatMin);
            this.flowLayoutPanel3.Controls.Add(this.numLatSec);
            this.flowLayoutPanel3.Controls.Add(this.labelLatSec);
            this.flowLayoutPanel3.Controls.Add(this.cboxLatSign);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(245, 30);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // numLatDeg
            // 
            this.numLatDeg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLatDeg.Location = new System.Drawing.Point(3, 3);
            this.numLatDeg.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numLatDeg.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numLatDeg.Name = "numLatDeg";
            this.numLatDeg.Size = new System.Drawing.Size(45, 21);
            this.numLatDeg.TabIndex = 0;
            this.numLatDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "°";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLatMin
            // 
            this.numLatMin.Location = new System.Drawing.Point(66, 3);
            this.numLatMin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numLatMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLatMin.Name = "numLatMin";
            this.numLatMin.Size = new System.Drawing.Size(40, 21);
            this.numLatMin.TabIndex = 2;
            this.numLatMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLatMin
            // 
            this.labelLatMin.AutoSize = true;
            this.labelLatMin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelLatMin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatMin.Location = new System.Drawing.Point(106, 3);
            this.labelLatMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelLatMin.Name = "labelLatMin";
            this.labelLatMin.Size = new System.Drawing.Size(11, 16);
            this.labelLatMin.TabIndex = 3;
            this.labelLatMin.Text = "\'";
            this.labelLatMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLatSec
            // 
            this.numLatSec.Location = new System.Drawing.Point(120, 3);
            this.numLatSec.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numLatSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLatSec.Name = "numLatSec";
            this.numLatSec.Size = new System.Drawing.Size(40, 21);
            this.numLatSec.TabIndex = 3;
            this.numLatSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLatSec
            // 
            this.labelLatSec.AutoSize = true;
            this.labelLatSec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelLatSec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatSec.Location = new System.Drawing.Point(160, 3);
            this.labelLatSec.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelLatSec.Name = "labelLatSec";
            this.labelLatSec.Size = new System.Drawing.Size(13, 16);
            this.labelLatSec.TabIndex = 5;
            this.labelLatSec.Text = "\"";
            this.labelLatSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxLatSign
            // 
            this.cboxLatSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLatSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxLatSign.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLatSign.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboxLatSign.FormattingEnabled = true;
            this.cboxLatSign.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cboxLatSign.Location = new System.Drawing.Point(176, 3);
            this.cboxLatSign.MaxDropDownItems = 2;
            this.cboxLatSign.Name = "cboxLatSign";
            this.cboxLatSign.Size = new System.Drawing.Size(33, 22);
            this.cboxLatSign.TabIndex = 6;
            // 
            // labelLonTitle
            // 
            this.labelLonTitle.AutoSize = true;
            this.labelLonTitle.Location = new System.Drawing.Point(3, 49);
            this.labelLonTitle.Name = "labelLonTitle";
            this.labelLonTitle.Size = new System.Drawing.Size(54, 13);
            this.labelLonTitle.TabIndex = 2;
            this.labelLonTitle.Text = "Longitude";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.numLongDeg);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.numLongMin);
            this.flowLayoutPanel2.Controls.Add(this.labelLonMin);
            this.flowLayoutPanel2.Controls.Add(this.numLongSec);
            this.flowLayoutPanel2.Controls.Add(this.labelLonSec);
            this.flowLayoutPanel2.Controls.Add(this.cboxLonSign);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(245, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // numLongDeg
            // 
            this.numLongDeg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLongDeg.Location = new System.Drawing.Point(3, 3);
            this.numLongDeg.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numLongDeg.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numLongDeg.Name = "numLongDeg";
            this.numLongDeg.Size = new System.Drawing.Size(45, 21);
            this.numLongDeg.TabIndex = 0;
            this.numLongDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLongMin
            // 
            this.numLongMin.Location = new System.Drawing.Point(66, 3);
            this.numLongMin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numLongMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLongMin.Name = "numLongMin";
            this.numLongMin.Size = new System.Drawing.Size(40, 21);
            this.numLongMin.TabIndex = 1;
            this.numLongMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLonMin
            // 
            this.labelLonMin.AutoSize = true;
            this.labelLonMin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelLonMin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLonMin.Location = new System.Drawing.Point(106, 3);
            this.labelLonMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelLonMin.Name = "labelLonMin";
            this.labelLonMin.Size = new System.Drawing.Size(11, 16);
            this.labelLonMin.TabIndex = 3;
            this.labelLonMin.Text = "\'";
            this.labelLonMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLongSec
            // 
            this.numLongSec.Location = new System.Drawing.Point(120, 3);
            this.numLongSec.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numLongSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLongSec.Name = "numLongSec";
            this.numLongSec.Size = new System.Drawing.Size(40, 21);
            this.numLongSec.TabIndex = 2;
            this.numLongSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLonSec
            // 
            this.labelLonSec.AutoSize = true;
            this.labelLonSec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelLonSec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLonSec.Location = new System.Drawing.Point(160, 3);
            this.labelLonSec.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelLonSec.Name = "labelLonSec";
            this.labelLonSec.Size = new System.Drawing.Size(13, 16);
            this.labelLonSec.TabIndex = 5;
            this.labelLonSec.Text = "\"";
            this.labelLonSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxLonSign
            // 
            this.cboxLonSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLonSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxLonSign.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLonSign.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboxLonSign.FormattingEnabled = true;
            this.cboxLonSign.Items.AddRange(new object[] {
            "E",
            "W"});
            this.cboxLonSign.Location = new System.Drawing.Point(176, 3);
            this.cboxLonSign.MaxDropDownItems = 2;
            this.cboxLonSign.Name = "cboxLonSign";
            this.cboxLonSign.Size = new System.Drawing.Size(37, 22);
            this.cboxLonSign.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Elevation";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.numElevation);
            this.flowLayoutPanel5.Controls.Add(this.label15);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 114);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(151, 30);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // numElevation
            // 
            this.numElevation.BackColor = System.Drawing.SystemColors.Window;
            this.numElevation.DecimalPlaces = 2;
            this.numElevation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numElevation.Location = new System.Drawing.Point(3, 3);
            this.numElevation.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numElevation.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numElevation.Name = "numElevation";
            this.numElevation.Size = new System.Drawing.Size(80, 21);
            this.numElevation.TabIndex = 0;
            this.numElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(86, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "meters";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupTime
            // 
            this.groupTime.Controls.Add(this.flowLayoutPanel7);
            this.groupTime.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTime.Location = new System.Drawing.Point(13, 194);
            this.groupTime.Name = "groupTime";
            this.groupTime.Padding = new System.Windows.Forms.Padding(15, 10, 3, 3);
            this.groupTime.Size = new System.Drawing.Size(238, 215);
            this.groupTime.TabIndex = 11;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "Time";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label11);
            this.flowLayoutPanel7.Controls.Add(this.cboxTimeZone);
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.datepickBegin);
            this.flowLayoutPanel7.Controls.Add(this.label10);
            this.flowLayoutPanel7.Controls.Add(this.datepickEnd);
            this.flowLayoutPanel7.Controls.Add(this.label12);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel7.Location = new System.Drawing.Point(15, 23);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(220, 189);
            this.flowLayoutPanel7.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Zone";
            // 
            // cboxTimeZone
            // 
            this.cboxTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTimeZone.DropDownWidth = 300;
            this.cboxTimeZone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxTimeZone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTimeZone.FormattingEnabled = true;
            this.cboxTimeZone.Location = new System.Drawing.Point(3, 16);
            this.cboxTimeZone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cboxTimeZone.Name = "cboxTimeZone";
            this.cboxTimeZone.Size = new System.Drawing.Size(208, 21);
            this.cboxTimeZone.TabIndex = 5;
            this.cboxTimeZone.SelectedIndexChanged += new System.EventHandler(this.cboxTimeZone_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Begin";
            // 
            // datepickBegin
            // 
            this.datepickBegin.CustomFormat = "dd MMM yyyy - HH:mm";
            this.datepickBegin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickBegin.Location = new System.Drawing.Point(3, 63);
            this.datepickBegin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.datepickBegin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datepickBegin.Name = "datepickBegin";
            this.datepickBegin.Size = new System.Drawing.Size(151, 21);
            this.datepickBegin.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "End";
            // 
            // datepickEnd
            // 
            this.datepickEnd.CustomFormat = "dd MMM yyyy - HH:mm";
            this.datepickEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickEnd.Location = new System.Drawing.Point(3, 110);
            this.datepickEnd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.datepickEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datepickEnd.Name = "datepickEnd";
            this.datepickEnd.Size = new System.Drawing.Size(151, 21);
            this.datepickEnd.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Interval";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.numInterval);
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 157);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(185, 26);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(3, 3);
            this.numInterval.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numInterval.Maximum = new decimal(new int[] {
            14400,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(49, 21);
            this.numInterval.TabIndex = 0;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "minutes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Image = ((System.Drawing.Image)(resources.GetObject("buttonGo.Image")));
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGo.Location = new System.Drawing.Point(25, 417);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(214, 37);
            this.buttonGo.TabIndex = 9;
            this.buttonGo.Text = "Generate";
            this.buttonGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // splitContainerTableInfoWindow
            // 
            this.splitContainerTableInfoWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTableInfoWindow.IsSplitterFixed = true;
            this.splitContainerTableInfoWindow.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTableInfoWindow.Name = "splitContainerTableInfoWindow";
            this.splitContainerTableInfoWindow.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTableInfoWindow.Panel1
            // 
            this.splitContainerTableInfoWindow.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerTableInfoWindow.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainerTableInfoWindow.Panel2
            // 
            this.splitContainerTableInfoWindow.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerTableInfoWindow.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.splitContainerTableInfoWindow.Size = new System.Drawing.Size(493, 481);
            this.splitContainerTableInfoWindow.SplitterDistance = 381;
            this.splitContainerTableInfoWindow.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTable);
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 381);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageTable
            // 
            this.tabPageTable.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTable.Controls.Add(this.dataGridView1);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(485, 355);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "F4";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(479, 349);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.zedGraphControl1);
            this.tabPageChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(485, 355);
            this.tabPageChart.TabIndex = 1;
            this.tabPageChart.Text = "Chart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(479, 349);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Window";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(3, 16);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(487, 72);
            this.textBoxInfo.TabIndex = 12;
            this.textBoxInfo.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFilegObserved
            // 
            this.openFilegObserved.Filter = "Gravity Observed Data (*.gobs)|*.gobs";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(761, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readGobsgobsToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // readGobsgobsToolStripMenuItem
            // 
            this.readGobsgobsToolStripMenuItem.Enabled = false;
            this.readGobsgobsToolStripMenuItem.Name = "readGobsgobsToolStripMenuItem";
            this.readGobsgobsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.readGobsgobsToolStripMenuItem.Text = "Read g obs (*.gobs)";
            this.readGobsgobsToolStripMenuItem.Visible = false;
            this.readGobsgobsToolStripMenuItem.Click += new System.EventHandler(this.readGobsgobsToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTableToolStripMenuItem,
            this.toolStripSeparator7,
            this.useDegMinSecToolStrip});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyTableToolStripMenuItem
            // 
            this.copyTableToolStripMenuItem.Enabled = false;
            this.copyTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyTableToolStripMenuItem.Image")));
            this.copyTableToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTableToolStripMenuItem.Name = "copyTableToolStripMenuItem";
            this.copyTableToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyTableToolStripMenuItem.Text = "&Copy Table";
            this.copyTableToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(190, 6);
            // 
            // useDegMinSecToolStrip
            // 
            this.useDegMinSecToolStrip.Checked = true;
            this.useDegMinSecToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDegMinSecToolStrip.Name = "useDegMinSecToolStrip";
            this.useDegMinSecToolStrip.Size = new System.Drawing.Size(193, 22);
            this.useDegMinSecToolStrip.Text = "Use Deg Min Sec Input";
            this.useDegMinSecToolStrip.CheckedChanged += new System.EventHandler(this.useDegMinSec_CheckedChanged);
            this.useDegMinSecToolStrip.Click += new System.EventHandler(this.useDegMinSec_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 505);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gravity Tidal Correction v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.splitContainerLeftRight.Panel1.ResumeLayout(false);
            this.splitContainerLeftRight.Panel2.ResumeLayout(false);
          
            this.splitContainerLeftRight.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupLocation.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            
            this.groupTime.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            
            this.splitContainerTableInfoWindow.Panel1.ResumeLayout(false);
            this.splitContainerTableInfoWindow.Panel2.ResumeLayout(false);
            
            this.splitContainerTableInfoWindow.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            
            this.tabPageChart.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainerLeftRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelLonTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numLongDeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLongMin;
        private System.Windows.Forms.NumericUpDown numLongSec;
        private System.Windows.Forms.Label labelLonMin;
        private System.Windows.Forms.Label labelLonSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datepickBegin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datepickEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxTimeZone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numElevation;
        private System.Windows.Forms.Label label15;
        
        private System.Windows.Forms.SplitContainer splitContainerTableInfoWindow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInfo;
        
       
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFilegObserved;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem useDegMinSecToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readGobsgobsToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numLatDeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLatMin;
        private System.Windows.Forms.Label labelLatMin;
        private System.Windows.Forms.NumericUpDown numLatSec;
        private System.Windows.Forms.Label labelLatSec;
        private System.Windows.Forms.ComboBox cboxLatSign;
        private System.Windows.Forms.ComboBox cboxLonSign;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageChart;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    }
}

