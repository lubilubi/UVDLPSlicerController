﻿namespace UV_DLP_3D_Printer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinarySTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneSTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeScene = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlSupport1 = new UV_DLP_3D_Printer.GUI.Controls.ctlSupport();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMove = new System.Windows.Forms.TabPage();
            this.txtZTrans = new System.Windows.Forms.TextBox();
            this.cmdZInc = new System.Windows.Forms.Button();
            this.cmdZdec = new System.Windows.Forms.Button();
            this.txtYTrans = new System.Windows.Forms.TextBox();
            this.cmdYInc = new System.Windows.Forms.Button();
            this.cmdYDec = new System.Windows.Forms.Button();
            this.txtXTrans = new System.Windows.Forms.TextBox();
            this.cmdXInc = new System.Windows.Forms.Button();
            this.cmdXDec = new System.Windows.Forms.Button();
            this.cmdCenter = new System.Windows.Forms.Button();
            this.cmdPlace = new System.Windows.Forms.Button();
            this.tbRotate = new System.Windows.Forms.TabPage();
            this.txtRz = new System.Windows.Forms.TextBox();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.cmdYRInc = new System.Windows.Forms.Button();
            this.cmdYRDec = new System.Windows.Forms.Button();
            this.cmdZRInc = new System.Windows.Forms.Button();
            this.cmdZRDec = new System.Windows.Forms.Button();
            this.cmdXRInc = new System.Windows.Forms.Button();
            this.cmdXRDec = new System.Windows.Forms.Button();
            this.tbScale = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdScaleZ = new System.Windows.Forms.Button();
            this.txtScaleZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdScaleY = new System.Windows.Forms.Button();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdScaleX = new System.Windows.Forms.Button();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.cmdScale = new System.Windows.Forms.Button();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.tabView = new System.Windows.Forms.TabPage();
            this.chkSliceHeight = new System.Windows.Forms.CheckBox();
            this.chkAlpha = new System.Windows.Forms.CheckBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.chkWireframe = new System.Windows.Forms.CheckBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabModel1 = new System.Windows.Forms.TabPage();
            this.glControl1 = new OpenTK.GLControl();
            this.tabGCode = new System.Windows.Forms.TabPage();
            this.txtGCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLoadGCode = new System.Windows.Forms.Button();
            this.cmdSaveGCode = new System.Windows.Forms.Button();
            this.tabSliceView = new System.Windows.Forms.TabPage();
            this.picSlice = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdViewLayer = new System.Windows.Forms.Button();
            this.txtLayerNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSliceNum = new System.Windows.Forms.Label();
            this.tabMachineControl = new System.Windows.Forms.TabPage();
            this.machineControl1 = new UV_DLP_3D_Printer.GUI.Controls.ctlMachineControl();
            this.tabMachineConfig = new System.Windows.Forms.TabPage();
            this.ctlMachineConfig1 = new UV_DLP_3D_Printer.GUI.Controls.ctlMachineConfig();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBuild = new System.Windows.Forms.ToolStripButton();
            this.cmdPause = new System.Windows.Forms.ToolStripButton();
            this.cmdStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdConnect = new System.Windows.Forms.ToolStripButton();
            this.cmdDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSlice1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMainMessage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.cmdDonate = new System.Windows.Forms.ToolStripButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.heatTempCtl1 = new UV_DLP_3D_Printer.GUI.Controls.ctlHeatTemp();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdRemoveObject = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbMove.SuspendLayout();
            this.tbRotate.SuspendLayout();
            this.tbScale.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabModel1.SuspendLayout();
            this.tabGCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSliceView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlice)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabMachineControl.SuspendLayout();
            this.tabMachineConfig.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dLPToolStripMenuItem,
            this.buildProfilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBinarySTLToolStripMenuItem,
            this.saveSceneSTLToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadBinarySTLToolStripMenuItem
            // 
            this.loadBinarySTLToolStripMenuItem.Name = "loadBinarySTLToolStripMenuItem";
            this.loadBinarySTLToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadBinarySTLToolStripMenuItem.Text = "Load Model";
            this.loadBinarySTLToolStripMenuItem.Click += new System.EventHandler(this.loadBinarySTLToolStripMenuItem_Click);
            // 
            // saveSceneSTLToolStripMenuItem
            // 
            this.saveSceneSTLToolStripMenuItem.Name = "saveSceneSTLToolStripMenuItem";
            this.saveSceneSTLToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveSceneSTLToolStripMenuItem.Text = "Save Scene STL";
            this.saveSceneSTLToolStripMenuItem.Click += new System.EventHandler(this.saveSceneSTLToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dLPToolStripMenuItem
            // 
            this.dLPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBlankToolStripMenuItem,
            this.showCalibrationToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.dLPToolStripMenuItem.Name = "dLPToolStripMenuItem";
            this.dLPToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.dLPToolStripMenuItem.Text = "DLP";
            // 
            // showBlankToolStripMenuItem
            // 
            this.showBlankToolStripMenuItem.Name = "showBlankToolStripMenuItem";
            this.showBlankToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showBlankToolStripMenuItem.Text = "Show Blank";
            this.showBlankToolStripMenuItem.Click += new System.EventHandler(this.showBlankToolStripMenuItem_Click);
            // 
            // showCalibrationToolStripMenuItem
            // 
            this.showCalibrationToolStripMenuItem.Name = "showCalibrationToolStripMenuItem";
            this.showCalibrationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showCalibrationToolStripMenuItem.Text = "Show Calibration";
            this.showCalibrationToolStripMenuItem.Click += new System.EventHandler(this.showCalibrationToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // buildProfilesToolStripMenuItem
            // 
            this.buildProfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem1,
            this.manageProfilesToolStripMenuItem,
            this.toolStripSeparator6});
            this.buildProfilesToolStripMenuItem.Name = "buildProfilesToolStripMenuItem";
            this.buildProfilesToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.buildProfilesToolStripMenuItem.Text = "Build Profiles";
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            this.propertiesToolStripMenuItem1.Click += new System.EventHandler(this.propertiesToolStripMenuItem1_Click);
            // 
            // manageProfilesToolStripMenuItem
            // 
            this.manageProfilesToolStripMenuItem.Name = "manageProfilesToolStripMenuItem";
            this.manageProfilesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manageProfilesToolStripMenuItem.Text = "Manage Profiles";
            this.manageProfilesToolStripMenuItem.Click += new System.EventHandler(this.manageProfilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(175, 6);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1457, 792);
            this.splitContainer2.SplitterDistance = 667;
            this.splitContainer2.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1457, 641);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 20;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer4.Size = new System.Drawing.Size(310, 637);
            this.splitContainer4.SplitterDistance = 434;
            this.splitContainer4.TabIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(310, 434);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeScene);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scene";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeScene
            // 
            this.treeScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeScene.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeScene.Location = new System.Drawing.Point(3, 3);
            this.treeScene.Name = "treeScene";
            this.treeScene.Size = new System.Drawing.Size(296, 399);
            this.treeScene.TabIndex = 6;
            this.treeScene.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeScene_NodeMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlSupport1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Support Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlSupport1
            // 
            this.ctlSupport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSupport1.Location = new System.Drawing.Point(3, 3);
            this.ctlSupport1.Name = "ctlSupport1";
            this.ctlSupport1.Size = new System.Drawing.Size(296, 399);
            this.ctlSupport1.TabIndex = 0;
            this.ctlSupport1.Load += new System.EventHandler(this.ctlSupport1_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMove);
            this.tabControl1.Controls.Add(this.tbRotate);
            this.tabControl1.Controls.Add(this.tbScale);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 199);
            this.tabControl1.TabIndex = 7;
            // 
            // tbMove
            // 
            this.tbMove.Controls.Add(this.txtZTrans);
            this.tbMove.Controls.Add(this.cmdZInc);
            this.tbMove.Controls.Add(this.cmdZdec);
            this.tbMove.Controls.Add(this.txtYTrans);
            this.tbMove.Controls.Add(this.cmdYInc);
            this.tbMove.Controls.Add(this.cmdYDec);
            this.tbMove.Controls.Add(this.txtXTrans);
            this.tbMove.Controls.Add(this.cmdXInc);
            this.tbMove.Controls.Add(this.cmdXDec);
            this.tbMove.Controls.Add(this.cmdCenter);
            this.tbMove.Controls.Add(this.cmdPlace);
            this.tbMove.Location = new System.Drawing.Point(4, 25);
            this.tbMove.Name = "tbMove";
            this.tbMove.Padding = new System.Windows.Forms.Padding(3);
            this.tbMove.Size = new System.Drawing.Size(302, 170);
            this.tbMove.TabIndex = 0;
            this.tbMove.Text = "Move";
            this.tbMove.UseVisualStyleBackColor = true;
            // 
            // txtZTrans
            // 
            this.txtZTrans.Location = new System.Drawing.Point(88, 177);
            this.txtZTrans.Name = "txtZTrans";
            this.txtZTrans.Size = new System.Drawing.Size(48, 22);
            this.txtZTrans.TabIndex = 12;
            this.txtZTrans.Text = "10";
            this.txtZTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdZInc
            // 
            this.cmdZInc.Location = new System.Drawing.Point(143, 171);
            this.cmdZInc.Name = "cmdZInc";
            this.cmdZInc.Size = new System.Drawing.Size(75, 34);
            this.cmdZInc.TabIndex = 11;
            this.cmdZInc.Text = "Z+";
            this.cmdZInc.UseVisualStyleBackColor = true;
            this.cmdZInc.Click += new System.EventHandler(this.cmdZInc_Click);
            // 
            // cmdZdec
            // 
            this.cmdZdec.Location = new System.Drawing.Point(7, 171);
            this.cmdZdec.Name = "cmdZdec";
            this.cmdZdec.Size = new System.Drawing.Size(75, 34);
            this.cmdZdec.TabIndex = 10;
            this.cmdZdec.Text = "Z-";
            this.cmdZdec.UseVisualStyleBackColor = true;
            this.cmdZdec.Click += new System.EventHandler(this.cmdZdec_Click);
            // 
            // txtYTrans
            // 
            this.txtYTrans.Location = new System.Drawing.Point(88, 130);
            this.txtYTrans.Name = "txtYTrans";
            this.txtYTrans.Size = new System.Drawing.Size(48, 22);
            this.txtYTrans.TabIndex = 9;
            this.txtYTrans.Text = "10";
            this.txtYTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdYInc
            // 
            this.cmdYInc.Location = new System.Drawing.Point(143, 124);
            this.cmdYInc.Name = "cmdYInc";
            this.cmdYInc.Size = new System.Drawing.Size(75, 34);
            this.cmdYInc.TabIndex = 8;
            this.cmdYInc.Text = "Y+";
            this.cmdYInc.UseVisualStyleBackColor = true;
            this.cmdYInc.Click += new System.EventHandler(this.cmdYInc_Click);
            // 
            // cmdYDec
            // 
            this.cmdYDec.Location = new System.Drawing.Point(7, 124);
            this.cmdYDec.Name = "cmdYDec";
            this.cmdYDec.Size = new System.Drawing.Size(75, 34);
            this.cmdYDec.TabIndex = 7;
            this.cmdYDec.Text = "Y-";
            this.cmdYDec.UseVisualStyleBackColor = true;
            this.cmdYDec.Click += new System.EventHandler(this.cmdYDec_Click);
            // 
            // txtXTrans
            // 
            this.txtXTrans.Location = new System.Drawing.Point(88, 83);
            this.txtXTrans.Name = "txtXTrans";
            this.txtXTrans.Size = new System.Drawing.Size(48, 22);
            this.txtXTrans.TabIndex = 6;
            this.txtXTrans.Text = "10";
            this.txtXTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdXInc
            // 
            this.cmdXInc.Location = new System.Drawing.Point(143, 77);
            this.cmdXInc.Name = "cmdXInc";
            this.cmdXInc.Size = new System.Drawing.Size(75, 34);
            this.cmdXInc.TabIndex = 5;
            this.cmdXInc.Text = "X+";
            this.cmdXInc.UseVisualStyleBackColor = true;
            this.cmdXInc.Click += new System.EventHandler(this.cmdXInc_Click);
            // 
            // cmdXDec
            // 
            this.cmdXDec.Location = new System.Drawing.Point(7, 77);
            this.cmdXDec.Name = "cmdXDec";
            this.cmdXDec.Size = new System.Drawing.Size(75, 34);
            this.cmdXDec.TabIndex = 4;
            this.cmdXDec.Text = "X-";
            this.cmdXDec.UseVisualStyleBackColor = true;
            this.cmdXDec.Click += new System.EventHandler(this.cmdXDec_Click);
            // 
            // cmdCenter
            // 
            this.cmdCenter.Location = new System.Drawing.Point(6, 15);
            this.cmdCenter.Name = "cmdCenter";
            this.cmdCenter.Size = new System.Drawing.Size(95, 45);
            this.cmdCenter.TabIndex = 2;
            this.cmdCenter.Text = "Center";
            this.cmdCenter.UseVisualStyleBackColor = true;
            this.cmdCenter.Click += new System.EventHandler(this.cmdCenter_Click);
            // 
            // cmdPlace
            // 
            this.cmdPlace.Location = new System.Drawing.Point(107, 15);
            this.cmdPlace.Name = "cmdPlace";
            this.cmdPlace.Size = new System.Drawing.Size(95, 45);
            this.cmdPlace.TabIndex = 3;
            this.cmdPlace.Text = "Place on Platform";
            this.cmdPlace.UseVisualStyleBackColor = true;
            this.cmdPlace.Click += new System.EventHandler(this.cmdPlace_Click);
            // 
            // tbRotate
            // 
            this.tbRotate.Controls.Add(this.txtRz);
            this.tbRotate.Controls.Add(this.txtRy);
            this.tbRotate.Controls.Add(this.txtRx);
            this.tbRotate.Controls.Add(this.cmdYRInc);
            this.tbRotate.Controls.Add(this.cmdYRDec);
            this.tbRotate.Controls.Add(this.cmdZRInc);
            this.tbRotate.Controls.Add(this.cmdZRDec);
            this.tbRotate.Controls.Add(this.cmdXRInc);
            this.tbRotate.Controls.Add(this.cmdXRDec);
            this.tbRotate.Location = new System.Drawing.Point(4, 25);
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Padding = new System.Windows.Forms.Padding(3);
            this.tbRotate.Size = new System.Drawing.Size(302, 170);
            this.tbRotate.TabIndex = 1;
            this.tbRotate.Text = "Rotate";
            this.tbRotate.UseVisualStyleBackColor = true;
            // 
            // txtRz
            // 
            this.txtRz.Location = new System.Drawing.Point(92, 140);
            this.txtRz.Name = "txtRz";
            this.txtRz.Size = new System.Drawing.Size(48, 22);
            this.txtRz.TabIndex = 9;
            this.txtRz.Text = "90";
            this.txtRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(92, 95);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(48, 22);
            this.txtRy.TabIndex = 8;
            this.txtRy.Text = "90";
            this.txtRy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(92, 50);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(48, 22);
            this.txtRx.TabIndex = 7;
            this.txtRx.Text = "90";
            this.txtRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdYRInc
            // 
            this.cmdYRInc.Location = new System.Drawing.Point(146, 87);
            this.cmdYRInc.Name = "cmdYRInc";
            this.cmdYRInc.Size = new System.Drawing.Size(75, 39);
            this.cmdYRInc.TabIndex = 5;
            this.cmdYRInc.Text = "Y+";
            this.cmdYRInc.UseVisualStyleBackColor = true;
            this.cmdYRInc.Click += new System.EventHandler(this.cmdYRInc_Click);
            // 
            // cmdYRDec
            // 
            this.cmdYRDec.Location = new System.Drawing.Point(7, 87);
            this.cmdYRDec.Name = "cmdYRDec";
            this.cmdYRDec.Size = new System.Drawing.Size(75, 39);
            this.cmdYRDec.TabIndex = 4;
            this.cmdYRDec.Text = "Y-";
            this.cmdYRDec.UseVisualStyleBackColor = true;
            this.cmdYRDec.Click += new System.EventHandler(this.cmdYRDec_Click);
            // 
            // cmdZRInc
            // 
            this.cmdZRInc.Location = new System.Drawing.Point(146, 132);
            this.cmdZRInc.Name = "cmdZRInc";
            this.cmdZRInc.Size = new System.Drawing.Size(75, 39);
            this.cmdZRInc.TabIndex = 3;
            this.cmdZRInc.Text = "Z+";
            this.cmdZRInc.UseVisualStyleBackColor = true;
            this.cmdZRInc.Click += new System.EventHandler(this.cmdZRInc_Click);
            // 
            // cmdZRDec
            // 
            this.cmdZRDec.Location = new System.Drawing.Point(7, 132);
            this.cmdZRDec.Name = "cmdZRDec";
            this.cmdZRDec.Size = new System.Drawing.Size(75, 39);
            this.cmdZRDec.TabIndex = 2;
            this.cmdZRDec.Text = "Z-";
            this.cmdZRDec.UseVisualStyleBackColor = true;
            this.cmdZRDec.Click += new System.EventHandler(this.cmdZRDec_Click);
            // 
            // cmdXRInc
            // 
            this.cmdXRInc.Location = new System.Drawing.Point(146, 42);
            this.cmdXRInc.Name = "cmdXRInc";
            this.cmdXRInc.Size = new System.Drawing.Size(75, 39);
            this.cmdXRInc.TabIndex = 1;
            this.cmdXRInc.Text = "X+";
            this.cmdXRInc.UseVisualStyleBackColor = true;
            this.cmdXRInc.Click += new System.EventHandler(this.cmdXRInc_Click);
            // 
            // cmdXRDec
            // 
            this.cmdXRDec.Location = new System.Drawing.Point(7, 42);
            this.cmdXRDec.Name = "cmdXRDec";
            this.cmdXRDec.Size = new System.Drawing.Size(75, 39);
            this.cmdXRDec.TabIndex = 0;
            this.cmdXRDec.Text = "X-";
            this.cmdXRDec.UseVisualStyleBackColor = true;
            this.cmdXRDec.Click += new System.EventHandler(this.cmdXRDec_Click);
            // 
            // tbScale
            // 
            this.tbScale.Controls.Add(this.groupBox1);
            this.tbScale.Controls.Add(this.cmdScale);
            this.tbScale.Controls.Add(this.txtScale);
            this.tbScale.Location = new System.Drawing.Point(4, 25);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(302, 170);
            this.tbScale.TabIndex = 2;
            this.tbScale.Text = "Scale";
            this.tbScale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmdScaleZ);
            this.groupBox1.Controls.Add(this.txtScaleZ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdScaleY);
            this.groupBox1.Controls.Add(this.txtScaleY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdScaleX);
            this.groupBox1.Controls.Add(this.txtScaleX);
            this.groupBox1.Location = new System.Drawing.Point(7, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scale Individual Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z";
            // 
            // cmdScaleZ
            // 
            this.cmdScaleZ.Location = new System.Drawing.Point(110, 89);
            this.cmdScaleZ.Name = "cmdScaleZ";
            this.cmdScaleZ.Size = new System.Drawing.Size(93, 22);
            this.cmdScaleZ.TabIndex = 12;
            this.cmdScaleZ.Text = "Scale";
            this.cmdScaleZ.UseVisualStyleBackColor = true;
            this.cmdScaleZ.Click += new System.EventHandler(this.cmdScaleZ_Click);
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(36, 89);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(68, 22);
            this.txtScaleZ.TabIndex = 13;
            this.txtScaleZ.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // cmdScaleY
            // 
            this.cmdScaleY.Location = new System.Drawing.Point(110, 61);
            this.cmdScaleY.Name = "cmdScaleY";
            this.cmdScaleY.Size = new System.Drawing.Size(93, 22);
            this.cmdScaleY.TabIndex = 9;
            this.cmdScaleY.Text = "Scale";
            this.cmdScaleY.UseVisualStyleBackColor = true;
            this.cmdScaleY.Click += new System.EventHandler(this.cmdScaleY_Click);
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(36, 61);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(68, 22);
            this.txtScaleY.TabIndex = 10;
            this.txtScaleY.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // cmdScaleX
            // 
            this.cmdScaleX.Location = new System.Drawing.Point(110, 33);
            this.cmdScaleX.Name = "cmdScaleX";
            this.cmdScaleX.Size = new System.Drawing.Size(93, 22);
            this.cmdScaleX.TabIndex = 6;
            this.cmdScaleX.Text = "Scale";
            this.cmdScaleX.UseVisualStyleBackColor = true;
            this.cmdScaleX.Click += new System.EventHandler(this.cmdScaleX_Click);
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(36, 33);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(68, 22);
            this.txtScaleX.TabIndex = 7;
            this.txtScaleX.Text = "1.0";
            // 
            // cmdScale
            // 
            this.cmdScale.Location = new System.Drawing.Point(80, 22);
            this.cmdScale.Name = "cmdScale";
            this.cmdScale.Size = new System.Drawing.Size(93, 34);
            this.cmdScale.TabIndex = 4;
            this.cmdScale.Text = "Scale";
            this.cmdScale.UseVisualStyleBackColor = true;
            this.cmdScale.Click += new System.EventHandler(this.cmdScale_Click);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(6, 28);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(68, 22);
            this.txtScale.TabIndex = 5;
            this.txtScale.Text = "1.0";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.chkSliceHeight);
            this.tabView.Controls.Add(this.chkAlpha);
            this.tabView.Controls.Add(this.lblDebug);
            this.tabView.Controls.Add(this.chkWireframe);
            this.tabView.Location = new System.Drawing.Point(4, 25);
            this.tabView.Name = "tabView";
            this.tabView.Size = new System.Drawing.Size(302, 170);
            this.tabView.TabIndex = 3;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // chkSliceHeight
            // 
            this.chkSliceHeight.AutoSize = true;
            this.chkSliceHeight.Location = new System.Drawing.Point(0, 170);
            this.chkSliceHeight.Name = "chkSliceHeight";
            this.chkSliceHeight.Size = new System.Drawing.Size(159, 21);
            this.chkSliceHeight.TabIndex = 2;
            this.chkSliceHeight.Text = "Show Height of Slice";
            this.chkSliceHeight.UseVisualStyleBackColor = true;
            this.chkSliceHeight.Visible = false;
            // 
            // chkAlpha
            // 
            this.chkAlpha.AutoSize = true;
            this.chkAlpha.Location = new System.Drawing.Point(3, 68);
            this.chkAlpha.Name = "chkAlpha";
            this.chkAlpha.Size = new System.Drawing.Size(267, 21);
            this.chkAlpha.TabIndex = 1;
            this.chkAlpha.Text = "View Models with 50% Alpha Blending";
            this.chkAlpha.UseVisualStyleBackColor = true;
            this.chkAlpha.CheckedChanged += new System.EventHandler(this.chkAlpha_CheckedChanged);
            // 
            // lblDebug
            // 
            this.lblDebug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDebug.Location = new System.Drawing.Point(0, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(302, 65);
            this.lblDebug.TabIndex = 0;
            // 
            // chkWireframe
            // 
            this.chkWireframe.AutoSize = true;
            this.chkWireframe.Location = new System.Drawing.Point(3, 95);
            this.chkWireframe.Name = "chkWireframe";
            this.chkWireframe.Size = new System.Drawing.Size(196, 21);
            this.chkWireframe.TabIndex = 0;
            this.chkWireframe.Text = "View Models as Wireframe";
            this.chkWireframe.UseVisualStyleBackColor = true;
            this.chkWireframe.Visible = false;
            this.chkWireframe.CheckedChanged += new System.EventHandler(this.chkWireframe_CheckedChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabModel1);
            this.tabMain.Controls.Add(this.tabGCode);
            this.tabMain.Controls.Add(this.tabSliceView);
            this.tabMain.Controls.Add(this.tabMachineControl);
            this.tabMain.Controls.Add(this.tabMachineConfig);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(30, 55);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1103, 582);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 18;
            // 
            // tabModel1
            // 
            this.tabModel1.Controls.Add(this.glControl1);
            this.tabModel1.Location = new System.Drawing.Point(4, 25);
            this.tabModel1.Name = "tabModel1";
            this.tabModel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabModel1.Size = new System.Drawing.Size(1095, 553);
            this.tabModel1.TabIndex = 0;
            this.tabModel1.Text = "Model View";
            this.tabModel1.UseVisualStyleBackColor = true;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(3, 3);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1089, 547);
            this.glControl1.TabIndex = 15;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.DoubleClick += new System.EventHandler(this.glControl1_DoubleClick);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            this.glControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.glControl1_KeyPress);
            this.glControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyUp);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseLeave += new System.EventHandler(this.glControl1_MouseLeave);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // tabGCode
            // 
            this.tabGCode.Controls.Add(this.txtGCode);
            this.tabGCode.Controls.Add(this.panel1);
            this.tabGCode.Location = new System.Drawing.Point(4, 25);
            this.tabGCode.Name = "tabGCode";
            this.tabGCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabGCode.Size = new System.Drawing.Size(1095, 553);
            this.tabGCode.TabIndex = 1;
            this.tabGCode.Text = "GCode";
            this.tabGCode.UseVisualStyleBackColor = true;
            // 
            // txtGCode
            // 
            this.txtGCode.AcceptsReturn = true;
            this.txtGCode.BackColor = System.Drawing.Color.White;
            this.txtGCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGCode.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGCode.Location = new System.Drawing.Point(3, 3);
            this.txtGCode.Multiline = true;
            this.txtGCode.Name = "txtGCode";
            this.txtGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGCode.Size = new System.Drawing.Size(1089, 469);
            this.txtGCode.TabIndex = 0;
            this.txtGCode.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdLoadGCode);
            this.panel1.Controls.Add(this.cmdSaveGCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 78);
            this.panel1.TabIndex = 1;
            // 
            // cmdLoadGCode
            // 
            this.cmdLoadGCode.Location = new System.Drawing.Point(164, 17);
            this.cmdLoadGCode.Name = "cmdLoadGCode";
            this.cmdLoadGCode.Size = new System.Drawing.Size(128, 50);
            this.cmdLoadGCode.TabIndex = 2;
            this.cmdLoadGCode.Text = " Load GCode";
            this.cmdLoadGCode.UseVisualStyleBackColor = true;
            this.cmdLoadGCode.Click += new System.EventHandler(this.cmdLoadGCode_Click);
            // 
            // cmdSaveGCode
            // 
            this.cmdSaveGCode.Location = new System.Drawing.Point(17, 17);
            this.cmdSaveGCode.Name = "cmdSaveGCode";
            this.cmdSaveGCode.Size = new System.Drawing.Size(128, 50);
            this.cmdSaveGCode.TabIndex = 0;
            this.cmdSaveGCode.Text = "Save GCode";
            this.cmdSaveGCode.UseVisualStyleBackColor = true;
            this.cmdSaveGCode.Click += new System.EventHandler(this.cmdSaveGCode_Click);
            // 
            // tabSliceView
            // 
            this.tabSliceView.Controls.Add(this.picSlice);
            this.tabSliceView.Controls.Add(this.panel2);
            this.tabSliceView.Location = new System.Drawing.Point(4, 25);
            this.tabSliceView.Name = "tabSliceView";
            this.tabSliceView.Size = new System.Drawing.Size(1095, 553);
            this.tabSliceView.TabIndex = 2;
            this.tabSliceView.Text = "Slice Viewer";
            this.tabSliceView.UseVisualStyleBackColor = true;
            // 
            // picSlice
            // 
            this.picSlice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSlice.Location = new System.Drawing.Point(0, 47);
            this.picSlice.Name = "picSlice";
            this.picSlice.Size = new System.Drawing.Size(1095, 506);
            this.picSlice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSlice.TabIndex = 17;
            this.picSlice.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdViewLayer);
            this.panel2.Controls.Add(this.txtLayerNum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblSliceNum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 47);
            this.panel2.TabIndex = 18;
            // 
            // cmdViewLayer
            // 
            this.cmdViewLayer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewLayer.Location = new System.Drawing.Point(268, 8);
            this.cmdViewLayer.Name = "cmdViewLayer";
            this.cmdViewLayer.Size = new System.Drawing.Size(75, 29);
            this.cmdViewLayer.TabIndex = 3;
            this.cmdViewLayer.Text = "View";
            this.cmdViewLayer.UseVisualStyleBackColor = true;
            this.cmdViewLayer.Click += new System.EventHandler(this.cmdViewLayer_Click);
            // 
            // txtLayerNum
            // 
            this.txtLayerNum.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLayerNum.Location = new System.Drawing.Point(176, 7);
            this.txtLayerNum.Name = "txtLayerNum";
            this.txtLayerNum.Size = new System.Drawing.Size(86, 30);
            this.txtLayerNum.TabIndex = 2;
            this.txtLayerNum.Text = "0";
            this.txtLayerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "View Layer:";
            // 
            // lblSliceNum
            // 
            this.lblSliceNum.AutoSize = true;
            this.lblSliceNum.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSliceNum.Location = new System.Drawing.Point(427, 9);
            this.lblSliceNum.Name = "lblSliceNum";
            this.lblSliceNum.Size = new System.Drawing.Size(180, 27);
            this.lblSliceNum.TabIndex = 0;
            this.lblSliceNum.Text = "Slice 0 of 0";
            // 
            // tabMachineControl
            // 
            this.tabMachineControl.Controls.Add(this.machineControl1);
            this.tabMachineControl.Location = new System.Drawing.Point(4, 25);
            this.tabMachineControl.Name = "tabMachineControl";
            this.tabMachineControl.Size = new System.Drawing.Size(1095, 553);
            this.tabMachineControl.TabIndex = 3;
            this.tabMachineControl.Text = "Machine Control";
            this.tabMachineControl.UseVisualStyleBackColor = true;
            // 
            // machineControl1
            // 
            this.machineControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineControl1.Location = new System.Drawing.Point(0, 0);
            this.machineControl1.Name = "machineControl1";
            this.machineControl1.Size = new System.Drawing.Size(1095, 553);
            this.machineControl1.TabIndex = 0;
            // 
            // tabMachineConfig
            // 
            this.tabMachineConfig.Controls.Add(this.ctlMachineConfig1);
            this.tabMachineConfig.Location = new System.Drawing.Point(4, 25);
            this.tabMachineConfig.Name = "tabMachineConfig";
            this.tabMachineConfig.Size = new System.Drawing.Size(1095, 553);
            this.tabMachineConfig.TabIndex = 4;
            this.tabMachineConfig.Text = "Machine Config";
            this.tabMachineConfig.UseVisualStyleBackColor = true;
            // 
            // ctlMachineConfig1
            // 
            this.ctlMachineConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMachineConfig1.Location = new System.Drawing.Point(0, 0);
            this.ctlMachineConfig1.Name = "ctlMachineConfig1";
            this.ctlMachineConfig1.Size = new System.Drawing.Size(1095, 553);
            this.ctlMachineConfig1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.vScrollBar1.Location = new System.Drawing.Point(0, 55);
            this.vScrollBar1.Maximum = 1000;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 582);
            this.vScrollBar1.TabIndex = 20;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdLoad,
            this.toolStripSeparator3,
            this.cmdBuild,
            this.cmdPause,
            this.cmdStop,
            this.toolStripSeparator1,
            this.cmdConnect,
            this.cmdDisconnect,
            this.toolStripSeparator2,
            this.cmdSlice1,
            this.toolStripSeparator4,
            this.lblMainMessage,
            this.toolStripSeparator5,
            this.lblTime,
            this.cmdDonate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1133, 55);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdLoad
            // 
            this.cmdLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLoad.Image = global::UV_DLP_3D_Printer.Properties.Resources.Load;
            this.cmdLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(52, 52);
            this.cmdLoad.Text = "Load Model";
            this.cmdLoad.Click += new System.EventHandler(this.LoadSTLModel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // cmdBuild
            // 
            this.cmdBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBuild.Image = global::UV_DLP_3D_Printer.Properties.Resources.bfzn_004;
            this.cmdBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBuild.Name = "cmdBuild";
            this.cmdBuild.Size = new System.Drawing.Size(52, 52);
            this.cmdBuild.Text = "Start Build";
            this.cmdBuild.Click += new System.EventHandler(this.cmdStartPrint_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPause.Image = global::UV_DLP_3D_Printer.Properties.Resources.bfzn_003;
            this.cmdPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(52, 52);
            this.cmdPause.Text = "Pause";
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click_1);
            // 
            // cmdStop
            // 
            this.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdStop.Image = global::UV_DLP_3D_Printer.Properties.Resources.bfzn_006;
            this.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(52, 52);
            this.cmdStop.Text = "Stop Build";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // cmdConnect
            // 
            this.cmdConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdConnect.Image = global::UV_DLP_3D_Printer.Properties.Resources.Connect;
            this.cmdConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(52, 52);
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect1_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdDisconnect.Image = global::UV_DLP_3D_Printer.Properties.Resources.Disconnect;
            this.cmdDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(52, 52);
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // cmdSlice1
            // 
            this.cmdSlice1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSlice1.Image = global::UV_DLP_3D_Printer.Properties.Resources.slice;
            this.cmdSlice1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSlice1.Name = "cmdSlice1";
            this.cmdSlice1.Size = new System.Drawing.Size(52, 52);
            this.cmdSlice1.Text = "Slice!";
            this.cmdSlice1.Click += new System.EventHandler(this.cmdSlice1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // lblMainMessage
            // 
            this.lblMainMessage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMessage.Name = "lblMainMessage";
            this.lblMainMessage.Size = new System.Drawing.Size(0, 52);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 52);
            // 
            // cmdDonate
            // 
            this.cmdDonate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdDonate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdDonate.Image = ((System.Drawing.Image)(resources.GetObject("cmdDonate.Image")));
            this.cmdDonate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDonate.Name = "cmdDonate";
            this.cmdDonate.Size = new System.Drawing.Size(52, 52);
            this.cmdDonate.Text = "Please Support Our Program!";
            this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtLog);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.heatTempCtl1);
            this.splitContainer3.Size = new System.Drawing.Size(1457, 121);
            this.splitContainer3.SplitterDistance = 993;
            this.splitContainer3.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(993, 121);
            this.txtLog.TabIndex = 0;
            // 
            // heatTempCtl1
            // 
            this.heatTempCtl1.Location = new System.Drawing.Point(3, 3);
            this.heatTempCtl1.MonitorTemps = false;
            this.heatTempCtl1.Name = "heatTempCtl1";
            this.heatTempCtl1.Size = new System.Drawing.Size(527, 121);
            this.heatTempCtl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRemoveObject});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 26);
            // 
            // cmdRemoveObject
            // 
            this.cmdRemoveObject.Name = "cmdRemoveObject";
            this.cmdRemoveObject.Size = new System.Drawing.Size(178, 22);
            this.cmdRemoveObject.Text = "Remove Object";
            this.cmdRemoveObject.Click += new System.EventHandler(this.cmdRemoveObject_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem1.Text = "Remove All Supports";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 792);
            this.Controls.Add(this.splitContainer2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Creation Workshop - 3D Printer Control and Slicing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbMove.ResumeLayout(false);
            this.tbMove.PerformLayout();
            this.tbRotate.ResumeLayout(false);
            this.tbRotate.PerformLayout();
            this.tbScale.ResumeLayout(false);
            this.tbScale.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabModel1.ResumeLayout(false);
            this.tabGCode.ResumeLayout(false);
            this.tabGCode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabSliceView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSlice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMachineControl.ResumeLayout(false);
            this.tabMachineConfig.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkWireframe;
        private System.Windows.Forms.Button cmdPlace;
        private System.Windows.Forms.Button cmdCenter;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Button cmdScale;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox picSlice;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtGCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBinarySTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdBuild;
        private System.Windows.Forms.ToolStripButton cmdStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdConnect;
        private System.Windows.Forms.ToolStripButton cmdDisconnect;
        private System.Windows.Forms.ToolStripButton cmdSlice1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabModel1;
        private System.Windows.Forms.TabPage tabGCode;
        private System.Windows.Forms.TabPage tabSliceView;
        private System.Windows.Forms.ToolStripButton cmdLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSaveGCode;
        private System.Windows.Forms.TreeView treeScene;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmdRemoveObject;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMove;
        private System.Windows.Forms.TabPage tbRotate;
        private System.Windows.Forms.TextBox txtZTrans;
        private System.Windows.Forms.Button cmdZInc;
        private System.Windows.Forms.Button cmdZdec;
        private System.Windows.Forms.TextBox txtYTrans;
        private System.Windows.Forms.Button cmdYInc;
        private System.Windows.Forms.Button cmdYDec;
        private System.Windows.Forms.TextBox txtXTrans;
        private System.Windows.Forms.Button cmdXInc;
        private System.Windows.Forms.Button cmdXDec;
        private System.Windows.Forms.Button cmdYRInc;
        private System.Windows.Forms.Button cmdYRDec;
        private System.Windows.Forms.Button cmdZRInc;
        private System.Windows.Forms.Button cmdZRDec;
        private System.Windows.Forms.Button cmdXRInc;
        private System.Windows.Forms.Button cmdXRDec;
        private System.Windows.Forms.TabPage tbScale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblMainMessage;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.ToolStripMenuItem dLPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBlankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cmdPause;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem saveSceneSTLToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.ToolStripMenuItem buildProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSliceNum;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox txtRz;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkAlpha;
        private System.Windows.Forms.Button cmdLoadGCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdScaleZ;
        private System.Windows.Forms.TextBox txtScaleZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdScaleY;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdScaleX;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private GUI.Controls.ctlHeatTemp heatTempCtl1;
        private System.Windows.Forms.TabPage tabMachineControl;
        private GUI.Controls.ctlMachineControl machineControl1;
        private System.Windows.Forms.CheckBox chkSliceHeight;
        private System.Windows.Forms.ToolStripButton cmdDonate;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabMachineConfig;
        private GUI.Controls.ctlMachineConfig ctlMachineConfig1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private GUI.Controls.ctlSupport ctlSupport1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdViewLayer;
        private System.Windows.Forms.TextBox txtLayerNum;
    }
}

