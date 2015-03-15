using System.ComponentModel;
using System.Windows.Forms;
using ZedGraphControl = ZedGraph.ZedGraphControl;

namespace GravityTidalCorrection
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainerLeftRight = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupLocation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.num_yPos = new System.Windows.Forms.NumericUpDown();
            this.labelPositionY_unit = new System.Windows.Forms.Label();
            this.numLatMin = new System.Windows.Forms.NumericUpDown();
            this.labelLatMin = new System.Windows.Forms.Label();
            this.numLatSec = new System.Windows.Forms.NumericUpDown();
            this.labelLatSec = new System.Windows.Forms.Label();
            this.cboxLatSign = new System.Windows.Forms.ComboBox();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.num_xPos = new System.Windows.Forms.NumericUpDown();
            this.labelPositionX_unit = new System.Windows.Forms.Label();
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
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerTableInfoWindow = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gmoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gsun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ypos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_elev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPageImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFilegObserved = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readGobsgobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalDegreeInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDegMinSecToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uTMInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTMZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxUTMZones = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainPanel.SuspendLayout();
            this.splitContainerLeftRight.Panel1.SuspendLayout();
            this.splitContainerLeftRight.Panel2.SuspendLayout();
            this.splitContainerLeftRight.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupLocation.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_yPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatSec)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_xPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongSec)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElevation)).BeginInit();
            this.groupTime.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.splitContainerTableInfoWindow.Panel1.SuspendLayout();
            this.splitContainerTableInfoWindow.Panel2.SuspendLayout();
            this.splitContainerTableInfoWindow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
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
            this.groupLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel6.Controls.Add(this.labelPositionY);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel6.Controls.Add(this.labelPositionX);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel6.Controls.Add(this.label14);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel6.Location = new System.Drawing.Point(15, 25);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(220, 147);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPositionY.ImageIndex = 9;
            this.labelPositionY.Location = new System.Drawing.Point(3, 0);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(46, 13);
            this.labelPositionY.TabIndex = 0;
            this.labelPositionY.Text = "Latitude";
            this.labelPositionY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.num_yPos);
            this.flowLayoutPanel3.Controls.Add(this.labelPositionY_unit);
            this.flowLayoutPanel3.Controls.Add(this.numLatMin);
            this.flowLayoutPanel3.Controls.Add(this.labelLatMin);
            this.flowLayoutPanel3.Controls.Add(this.numLatSec);
            this.flowLayoutPanel3.Controls.Add(this.labelLatSec);
            this.flowLayoutPanel3.Controls.Add(this.cboxLatSign);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(217, 30);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // num_yPos
            // 
            this.num_yPos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_yPos.Location = new System.Drawing.Point(3, 3);
            this.num_yPos.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.num_yPos.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.num_yPos.Name = "num_yPos";
            this.num_yPos.Size = new System.Drawing.Size(45, 21);
            this.num_yPos.TabIndex = 0;
            this.num_yPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPositionY_unit
            // 
            this.labelPositionY_unit.AutoSize = true;
            this.labelPositionY_unit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPositionY_unit.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelPositionY_unit.Location = new System.Drawing.Point(48, 3);
            this.labelPositionY_unit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelPositionY_unit.Name = "labelPositionY_unit";
            this.labelPositionY_unit.Size = new System.Drawing.Size(13, 13);
            this.labelPositionY_unit.TabIndex = 1;
            this.labelPositionY_unit.Text = "°";
            this.labelPositionY_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLatMin
            // 
            this.numLatMin.Location = new System.Drawing.Point(64, 3);
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
            this.labelLatMin.Location = new System.Drawing.Point(104, 3);
            this.labelLatMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelLatMin.Name = "labelLatMin";
            this.labelLatMin.Size = new System.Drawing.Size(11, 16);
            this.labelLatMin.TabIndex = 3;
            this.labelLatMin.Text = "\'";
            this.labelLatMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLatSec
            // 
            this.numLatSec.Location = new System.Drawing.Point(118, 3);
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
            this.labelLatSec.Location = new System.Drawing.Point(158, 3);
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
            this.cboxLatSign.Location = new System.Drawing.Point(174, 3);
            this.cboxLatSign.MaxDropDownItems = 2;
            this.cboxLatSign.Name = "cboxLatSign";
            this.cboxLatSign.Size = new System.Drawing.Size(36, 22);
            this.cboxLatSign.TabIndex = 6;
            // 
            // labelPositionX
            // 
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Location = new System.Drawing.Point(3, 49);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(54, 13);
            this.labelPositionX.TabIndex = 2;
            this.labelPositionX.Text = "Longitude";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.num_xPos);
            this.flowLayoutPanel2.Controls.Add(this.labelPositionX_unit);
            this.flowLayoutPanel2.Controls.Add(this.numLongMin);
            this.flowLayoutPanel2.Controls.Add(this.labelLonMin);
            this.flowLayoutPanel2.Controls.Add(this.numLongSec);
            this.flowLayoutPanel2.Controls.Add(this.labelLonSec);
            this.flowLayoutPanel2.Controls.Add(this.cboxLonSign);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(217, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // num_xPos
            // 
            this.num_xPos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_xPos.Location = new System.Drawing.Point(3, 3);
            this.num_xPos.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.num_xPos.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.num_xPos.Name = "num_xPos";
            this.num_xPos.Size = new System.Drawing.Size(45, 21);
            this.num_xPos.TabIndex = 0;
            this.num_xPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPositionX_unit
            // 
            this.labelPositionX_unit.AutoSize = true;
            this.labelPositionX_unit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPositionX_unit.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelPositionX_unit.Location = new System.Drawing.Point(48, 3);
            this.labelPositionX_unit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelPositionX_unit.Name = "labelPositionX_unit";
            this.labelPositionX_unit.Size = new System.Drawing.Size(13, 13);
            this.labelPositionX_unit.TabIndex = 1;
            this.labelPositionX_unit.Text = "°";
            this.labelPositionX_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLongMin
            // 
            this.numLongMin.Location = new System.Drawing.Point(64, 3);
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
            this.labelLonMin.Location = new System.Drawing.Point(104, 3);
            this.labelLonMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.labelLonMin.Name = "labelLonMin";
            this.labelLonMin.Size = new System.Drawing.Size(11, 16);
            this.labelLonMin.TabIndex = 3;
            this.labelLonMin.Text = "\'";
            this.labelLonMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLongSec
            // 
            this.numLongSec.Location = new System.Drawing.Point(118, 3);
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
            this.labelLonSec.Location = new System.Drawing.Point(158, 3);
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
            this.cboxLonSign.Location = new System.Drawing.Point(174, 3);
            this.cboxLonSign.MaxDropDownItems = 2;
            this.cboxLonSign.Name = "cboxLonSign";
            this.cboxLonSign.Size = new System.Drawing.Size(36, 22);
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
            this.groupTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel7.Location = new System.Drawing.Point(15, 25);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(220, 187);
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
            this.numInterval.Size = new System.Drawing.Size(80, 21);
            this.numInterval.TabIndex = 0;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 6);
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
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGo.ImageIndex = 0;
            this.buttonGo.ImageList = this.imageListButton;
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
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "table--arrow.png");
            this.imageListButton.Images.SetKeyName(1, "disk-return-black.png");
            this.imageListButton.Images.SetKeyName(2, "blue-document-copy.png");
            this.imageListButton.Images.SetKeyName(3, "address-book-open.png");
            this.imageListButton.Images.SetKeyName(4, "direction.png");
            this.imageListButton.Images.SetKeyName(5, "alarm-clock-blue.png");
            this.imageListButton.Images.SetKeyName(6, "compass--pencil.png");
            this.imageListButton.Images.SetKeyName(7, "globe-green.png");
            this.imageListButton.Images.SetKeyName(8, "grid.png");
            this.imageListButton.Images.SetKeyName(9, "marker.png");
            this.imageListButton.Images.SetKeyName(10, "zones.png");
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
            this.tabControl1.ImageList = this.tabPageImageList;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 381);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageTable
            // 
            this.tabPageTable.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTable.Controls.Add(this.dgvResult);
            this.tabPageTable.ImageIndex = 0;
            this.tabPageTable.Location = new System.Drawing.Point(4, 23);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(485, 354);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Table";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_date,
            this.col_gmoon,
            this.col_gsun,
            this.col_gtotal,
            this.col_xpos,
            this.col_ypos,
            this.col_elev});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "F4";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(479, 348);
            this.dgvResult.TabIndex = 13;
            this.dgvResult.TabStop = false;
            // 
            // col_date
            // 
            this.col_date.DataPropertyName = "Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd-MMM-yy HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.col_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_date.HeaderText = "Date Time";
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            // 
            // col_gmoon
            // 
            this.col_gmoon.DataPropertyName = "MoonTidal";
            this.col_gmoon.HeaderText = "g Moon (mGal)";
            this.col_gmoon.Name = "col_gmoon";
            this.col_gmoon.ReadOnly = true;
            // 
            // col_gsun
            // 
            this.col_gsun.DataPropertyName = "SunTidal";
            this.col_gsun.HeaderText = "g Sun (mGal)";
            this.col_gsun.Name = "col_gsun";
            this.col_gsun.ReadOnly = true;
            // 
            // col_gtotal
            // 
            this.col_gtotal.DataPropertyName = "CorrectionTotal";
            this.col_gtotal.HeaderText = "g Total (mGal)";
            this.col_gtotal.Name = "col_gtotal";
            this.col_gtotal.ReadOnly = true;
            // 
            // col_xpos
            // 
            this.col_xpos.DataPropertyName = "XPosition";
            this.col_xpos.HeaderText = "X-Position";
            this.col_xpos.Name = "col_xpos";
            this.col_xpos.ReadOnly = true;
            this.col_xpos.Visible = false;
            // 
            // col_ypos
            // 
            this.col_ypos.DataPropertyName = "YPosition";
            this.col_ypos.HeaderText = "Y-Position";
            this.col_ypos.Name = "col_ypos";
            this.col_ypos.ReadOnly = true;
            this.col_ypos.Visible = false;
            // 
            // col_elev
            // 
            this.col_elev.DataPropertyName = "Elevation";
            this.col_elev.HeaderText = "Elevation";
            this.col_elev.Name = "col_elev";
            this.col_elev.ReadOnly = true;
            this.col_elev.Visible = false;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.zedGraphControl1);
            this.tabPageChart.ImageIndex = 1;
            this.tabPageChart.Location = new System.Drawing.Point(4, 23);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(485, 354);
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
            this.zedGraphControl1.Size = new System.Drawing.Size(479, 348);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabPageImageList
            // 
            this.tabPageImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabPageImageList.ImageStream")));
            this.tabPageImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabPageImageList.Images.SetKeyName(0, "table.png");
            this.tabPageImageList.Images.SetKeyName(1, "chart-up.png");
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
            this.groupBox1.Text = "Log Console";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.readGobsgobsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readGobsgobsToolStripMenuItem.Image")));
            this.readGobsgobsToolStripMenuItem.Name = "readGobsgobsToolStripMenuItem";
            this.readGobsgobsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.readGobsgobsToolStripMenuItem.Text = "Read From File";
            this.readGobsgobsToolStripMenuItem.Click += new System.EventHandler(this.readGobsgobsToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalDegreeInputToolStripMenuItem,
            this.useDegMinSecToolStrip,
            this.uTMInputToolStripMenuItem,
            this.uTMZoneToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.inputToolStripMenuItem.Text = "&Coordinate System";
            // 
            // decimalDegreeInputToolStripMenuItem
            // 
            this.decimalDegreeInputToolStripMenuItem.Name = "decimalDegreeInputToolStripMenuItem";
            this.decimalDegreeInputToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.decimalDegreeInputToolStripMenuItem.Text = "Geographic Decimal Degree";
            this.decimalDegreeInputToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.InputCheckStateChanged);
            this.decimalDegreeInputToolStripMenuItem.Click += new System.EventHandler(this.inputModeChange_click);
            // 
            // useDegMinSecToolStrip
            // 
            this.useDegMinSecToolStrip.Checked = true;
            this.useDegMinSecToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDegMinSecToolStrip.Name = "useDegMinSecToolStrip";
            this.useDegMinSecToolStrip.Size = new System.Drawing.Size(273, 22);
            this.useDegMinSecToolStrip.Text = "Geographic Degrees Minutes Seconds";
            this.useDegMinSecToolStrip.CheckStateChanged += new System.EventHandler(this.InputCheckStateChanged);
            this.useDegMinSecToolStrip.Click += new System.EventHandler(this.inputModeChange_click);
            // 
            // uTMInputToolStripMenuItem
            // 
            this.uTMInputToolStripMenuItem.Name = "uTMInputToolStripMenuItem";
            this.uTMInputToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.uTMInputToolStripMenuItem.Text = "Universal Transverse Mercator";
            this.uTMInputToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.InputCheckStateChanged);
            this.uTMInputToolStripMenuItem.Click += new System.EventHandler(this.inputModeChange_click);
            // 
            // uTMZoneToolStripMenuItem
            // 
            this.uTMZoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxUTMZones});
            this.uTMZoneToolStripMenuItem.Name = "uTMZoneToolStripMenuItem";
            this.uTMZoneToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.uTMZoneToolStripMenuItem.Text = "UTM Projection";
            // 
            // toolStripComboBoxUTMZones
            // 
            this.toolStripComboBoxUTMZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxUTMZones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBoxUTMZones.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripComboBoxUTMZones.Name = "toolStripComboBoxUTMZones";
            this.toolStripComboBoxUTMZones.Size = new System.Drawing.Size(150, 21);
            this.toolStripComboBoxUTMZones.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxUTMZones_SelectedIndexChanged);
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
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About GravTC";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "Copy Table";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inputToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(761, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 505);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gravity Tidal Correction";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.num_yPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatSec)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_xPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongSec)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElevation)).EndInit();
            this.groupTime.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.splitContainerTableInfoWindow.Panel1.ResumeLayout(false);
            this.splitContainerTableInfoWindow.Panel2.ResumeLayout(false);
            this.splitContainerTableInfoWindow.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.tabPageChart.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Panel mainPanel;
        private SplitContainer splitContainerLeftRight;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelPositionX;
        private FlowLayoutPanel flowLayoutPanel2;
        private NumericUpDown num_xPos;
        private Label labelPositionX_unit;
        private NumericUpDown numLongMin;
        private NumericUpDown numLongSec;
        private Label labelLonMin;
        private Label labelLonSec;
        private Label label9;
        private DateTimePicker datepickBegin;
        private Label label10;
        private DateTimePicker datepickEnd;
        private Label label11;
        private ComboBox cboxTimeZone;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel4;
        private NumericUpDown numInterval;
        private Label label13;
        private Button buttonGo;
        private Label label14;
        private FlowLayoutPanel flowLayoutPanel5;
        private NumericUpDown numElevation;
        private Label label15;
        
        private SplitContainer splitContainerTableInfoWindow;
        private DataGridView dgvResult;
        private GroupBox groupBox1;
        private TextBox textBoxInfo;
        
       
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFilegObserved;
        private Label labelPositionY;
        private FlowLayoutPanel flowLayoutPanel3;
        private NumericUpDown num_yPos;
        private Label labelPositionY_unit;
        private NumericUpDown numLatMin;
        private Label labelLatMin;
        private NumericUpDown numLatSec;
        private Label labelLatSec;
        private ComboBox cboxLatSign;
        private ComboBox cboxLonSign;
        private TabControl tabControl1;
        private TabPage tabPageTable;
        private TabPage tabPageChart;
        private ZedGraphControl zedGraphControl1;
        private GroupBox groupLocation;
        private FlowLayoutPanel flowLayoutPanel6;
        private GroupBox groupTime;
        private FlowLayoutPanel flowLayoutPanel7;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem readGobsgobsToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem inputToolStripMenuItem;
        private ToolStripMenuItem useDegMinSecToolStrip;
        private ToolStripMenuItem uTMInputToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem decimalDegreeInputToolStripMenuItem;
        private ToolStripMenuItem uTMZoneToolStripMenuItem;
        private ToolStripComboBox toolStripComboBoxUTMZones;
        private DataGridViewTextBoxColumn col_date;
        private DataGridViewTextBoxColumn col_gmoon;
        private DataGridViewTextBoxColumn col_gsun;
        private DataGridViewTextBoxColumn col_gtotal;
        private DataGridViewTextBoxColumn col_xpos;
        private DataGridViewTextBoxColumn col_ypos;
        private DataGridViewTextBoxColumn col_elev;
        private ImageList tabPageImageList;
        private ImageList imageListButton;
    }
}

