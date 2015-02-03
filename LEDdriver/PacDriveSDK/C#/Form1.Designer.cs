namespace PacDriveDemo
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvwDevices = new System.Windows.Forms.ListView();
			this.colDeviceType = new System.Windows.Forms.ColumnHeader();
			this.colVendorId = new System.Windows.Forms.ColumnHeader();
			this.colProductId = new System.Windows.Forms.ColumnHeader();
			this.colVersionNumber = new System.Windows.Forms.ColumnHeader();
			this.colVendorName = new System.Windows.Forms.ColumnHeader();
			this.colProductName = new System.Windows.Forms.ColumnHeader();
			this.colSerialNumber = new System.Windows.Forms.ColumnHeader();
			this.colDevicePath = new System.Windows.Forms.ColumnHeader();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.LEDGroup = new System.Windows.Forms.NumericUpDown();
			this.Random = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.rdoSeconds_0_5 = new System.Windows.Forms.RadioButton();
			this.rdoSeconds_1 = new System.Windows.Forms.RadioButton();
			this.rdoSeconds_2 = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.rdoAlwaysOn = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.Intensity = new System.Windows.Forms.TrackBar();
			this.LEDNumber = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.ProgUHID = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ScriptStepDelay = new System.Windows.Forms.TrackBar();
			this.FadeTime = new System.Windows.Forms.TrackBar();
			this.RunScript = new System.Windows.Forms.Button();
			this.ClearFlash = new System.Windows.Forms.Button();
			this.StopRecording = new System.Windows.Forms.Button();
			this.StartRecording = new System.Windows.Forms.Button();
			this.SetDeviceID = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.DeviceId = new System.Windows.Forms.NumericUpDown();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.lblState = new System.Windows.Forms.Label();
			this.GetState = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.butReleased = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.butPressed = new System.Windows.Forms.Button();
			this.SetTemporary = new System.Windows.Forms.Button();
			this.SetPerminent = new System.Windows.Forms.Button();
			this.Url = new System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LEDGroup)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LEDNumber)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ScriptStepDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FadeTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeviceId)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 383);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(481, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvwDevices);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(481, 383);
			this.splitContainer1.SplitterDistance = 115;
			this.splitContainer1.TabIndex = 5;
			// 
			// lvwDevices
			// 
			this.lvwDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDeviceType,
            this.colVendorId,
            this.colProductId,
            this.colVersionNumber,
            this.colVendorName,
            this.colProductName,
            this.colSerialNumber,
            this.colDevicePath});
			this.lvwDevices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvwDevices.FullRowSelect = true;
			this.lvwDevices.GridLines = true;
			this.lvwDevices.HideSelection = false;
			this.lvwDevices.Location = new System.Drawing.Point(0, 0);
			this.lvwDevices.Name = "lvwDevices";
			this.lvwDevices.Size = new System.Drawing.Size(481, 115);
			this.lvwDevices.TabIndex = 2;
			this.lvwDevices.UseCompatibleStateImageBehavior = false;
			this.lvwDevices.View = System.Windows.Forms.View.Details;
			this.lvwDevices.SelectedIndexChanged += new System.EventHandler(this.lvwDevices_SelectedIndexChanged);
			// 
			// colDeviceType
			// 
			this.colDeviceType.Text = "Device Type";
			this.colDeviceType.Width = 83;
			// 
			// colVendorId
			// 
			this.colVendorId.Text = "Vendor Id";
			this.colVendorId.Width = 100;
			// 
			// colProductId
			// 
			this.colProductId.Text = "Product Id";
			this.colProductId.Width = 100;
			// 
			// colVersionNumber
			// 
			this.colVersionNumber.Text = "Version Number";
			this.colVersionNumber.Width = 100;
			// 
			// colVendorName
			// 
			this.colVendorName.Text = "Vendor Name";
			this.colVendorName.Width = 100;
			// 
			// colProductName
			// 
			this.colProductName.Text = "Product Name";
			this.colProductName.Width = 100;
			// 
			// colSerialNumber
			// 
			this.colSerialNumber.Text = "Serial Number";
			this.colSerialNumber.Width = 100;
			// 
			// colDevicePath
			// 
			this.colDevicePath.Text = "Device Path";
			this.colDevicePath.Width = 100;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(481, 264);
			this.tabControl1.TabIndex = 20;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.LEDGroup);
			this.tabPage1.Controls.Add(this.Random);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(473, 238);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "State";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// LEDGroup
			// 
			this.LEDGroup.Location = new System.Drawing.Point(269, 33);
			this.LEDGroup.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.LEDGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LEDGroup.Name = "LEDGroup";
			this.LEDGroup.ReadOnly = true;
			this.LEDGroup.Size = new System.Drawing.Size(71, 20);
			this.LEDGroup.TabIndex = 20;
			this.LEDGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Random
			// 
			this.Random.Location = new System.Drawing.Point(125, 64);
			this.Random.Name = "Random";
			this.Random.Size = new System.Drawing.Size(215, 32);
			this.Random.TabIndex = 22;
			this.Random.Text = "All LEDs Light Random";
			this.Random.UseVisualStyleBackColor = true;
			this.Random.Click += new System.EventHandler(this.Random_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Group:";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(42, 119);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 79);
			this.panel1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.rdoSeconds_0_5);
			this.tabPage2.Controls.Add(this.rdoSeconds_1);
			this.tabPage2.Controls.Add(this.rdoSeconds_2);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.rdoAlwaysOn);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.Intensity);
			this.tabPage2.Controls.Add(this.LEDNumber);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(473, 238);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Intensity";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// rdoSeconds_0_5
			// 
			this.rdoSeconds_0_5.AutoSize = true;
			this.rdoSeconds_0_5.Location = new System.Drawing.Point(207, 200);
			this.rdoSeconds_0_5.Name = "rdoSeconds_0_5";
			this.rdoSeconds_0_5.Size = new System.Drawing.Size(85, 17);
			this.rdoSeconds_0_5.TabIndex = 20;
			this.rdoSeconds_0_5.Text = "0.5 Seconds";
			this.rdoSeconds_0_5.UseVisualStyleBackColor = true;
			this.rdoSeconds_0_5.CheckedChanged += new System.EventHandler(this.FlashSpeed_CheckedChanged);
			// 
			// rdoSeconds_1
			// 
			this.rdoSeconds_1.AutoSize = true;
			this.rdoSeconds_1.Location = new System.Drawing.Point(207, 177);
			this.rdoSeconds_1.Name = "rdoSeconds_1";
			this.rdoSeconds_1.Size = new System.Drawing.Size(71, 17);
			this.rdoSeconds_1.TabIndex = 19;
			this.rdoSeconds_1.Text = "1 Second";
			this.rdoSeconds_1.UseVisualStyleBackColor = true;
			this.rdoSeconds_1.CheckedChanged += new System.EventHandler(this.FlashSpeed_CheckedChanged);
			// 
			// rdoSeconds_2
			// 
			this.rdoSeconds_2.AutoSize = true;
			this.rdoSeconds_2.Location = new System.Drawing.Point(207, 154);
			this.rdoSeconds_2.Name = "rdoSeconds_2";
			this.rdoSeconds_2.Size = new System.Drawing.Size(76, 17);
			this.rdoSeconds_2.TabIndex = 18;
			this.rdoSeconds_2.Text = "2 Seconds";
			this.rdoSeconds_2.UseVisualStyleBackColor = true;
			this.rdoSeconds_2.CheckedChanged += new System.EventHandler(this.FlashSpeed_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(122, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Flash Speed:";
			// 
			// rdoAlwaysOn
			// 
			this.rdoAlwaysOn.AutoSize = true;
			this.rdoAlwaysOn.Checked = true;
			this.rdoAlwaysOn.Location = new System.Drawing.Point(207, 131);
			this.rdoAlwaysOn.Name = "rdoAlwaysOn";
			this.rdoAlwaysOn.Size = new System.Drawing.Size(75, 17);
			this.rdoAlwaysOn.TabIndex = 16;
			this.rdoAlwaysOn.TabStop = true;
			this.rdoAlwaysOn.Text = "Always On";
			this.rdoAlwaysOn.UseVisualStyleBackColor = true;
			this.rdoAlwaysOn.CheckedChanged += new System.EventHandler(this.FlashSpeed_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Intensity:";
			// 
			// Intensity
			// 
			this.Intensity.AutoSize = false;
			this.Intensity.Location = new System.Drawing.Point(99, 80);
			this.Intensity.Maximum = 255;
			this.Intensity.Name = "Intensity";
			this.Intensity.Size = new System.Drawing.Size(330, 31);
			this.Intensity.TabIndex = 13;
			this.Intensity.TickFrequency = 8;
			this.Intensity.Scroll += new System.EventHandler(this.Intensity_Scroll);
			// 
			// LEDNumber
			// 
			this.LEDNumber.Location = new System.Drawing.Point(250, 34);
			this.LEDNumber.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.LEDNumber.Name = "LEDNumber";
			this.LEDNumber.ReadOnly = true;
			this.LEDNumber.Size = new System.Drawing.Size(71, 20);
			this.LEDNumber.TabIndex = 14;
			this.LEDNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(126, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "LED Number (0 = All):";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.ProgUHID);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.ScriptStepDelay);
			this.tabPage3.Controls.Add(this.FadeTime);
			this.tabPage3.Controls.Add(this.RunScript);
			this.tabPage3.Controls.Add(this.ClearFlash);
			this.tabPage3.Controls.Add(this.StopRecording);
			this.tabPage3.Controls.Add(this.StartRecording);
			this.tabPage3.Controls.Add(this.SetDeviceID);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.DeviceId);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(473, 238);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// ProgUHID
			// 
			this.ProgUHID.Location = new System.Drawing.Point(302, 171);
			this.ProgUHID.Name = "ProgUHID";
			this.ProgUHID.Size = new System.Drawing.Size(140, 33);
			this.ProgUHID.TabIndex = 34;
			this.ProgUHID.Text = "Program UHID";
			this.ProgUHID.UseVisualStyleBackColor = true;
			this.ProgUHID.Click += new System.EventHandler(this.ProgUHID_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(80, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Script Step Delay";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(92, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Fade Time";
			// 
			// ScriptStepDelay
			// 
			this.ScriptStepDelay.AutoSize = false;
			this.ScriptStepDelay.Location = new System.Drawing.Point(20, 116);
			this.ScriptStepDelay.Maximum = 255;
			this.ScriptStepDelay.Name = "ScriptStepDelay";
			this.ScriptStepDelay.Size = new System.Drawing.Size(198, 29);
			this.ScriptStepDelay.TabIndex = 28;
			this.ScriptStepDelay.TickFrequency = 8;
			this.ScriptStepDelay.Scroll += new System.EventHandler(this.ScriptStepDelay_Scroll);
			// 
			// FadeTime
			// 
			this.FadeTime.AutoSize = false;
			this.FadeTime.Location = new System.Drawing.Point(21, 171);
			this.FadeTime.Maximum = 255;
			this.FadeTime.Name = "FadeTime";
			this.FadeTime.Size = new System.Drawing.Size(197, 29);
			this.FadeTime.TabIndex = 27;
			this.FadeTime.TickFrequency = 8;
			this.FadeTime.Scroll += new System.EventHandler(this.FadeTime_Scroll);
			// 
			// RunScript
			// 
			this.RunScript.Location = new System.Drawing.Point(131, 79);
			this.RunScript.Name = "RunScript";
			this.RunScript.Size = new System.Drawing.Size(87, 23);
			this.RunScript.TabIndex = 26;
			this.RunScript.Text = "RunScript";
			this.RunScript.UseVisualStyleBackColor = true;
			this.RunScript.Click += new System.EventHandler(this.RunScript_Click);
			// 
			// ClearFlash
			// 
			this.ClearFlash.Location = new System.Drawing.Point(20, 79);
			this.ClearFlash.Name = "ClearFlash";
			this.ClearFlash.Size = new System.Drawing.Size(105, 23);
			this.ClearFlash.TabIndex = 25;
			this.ClearFlash.Text = "Clear Flash";
			this.ClearFlash.UseVisualStyleBackColor = true;
			this.ClearFlash.Click += new System.EventHandler(this.ClearFlash_Click);
			// 
			// StopRecording
			// 
			this.StopRecording.Location = new System.Drawing.Point(20, 49);
			this.StopRecording.Name = "StopRecording";
			this.StopRecording.Size = new System.Drawing.Size(198, 24);
			this.StopRecording.TabIndex = 24;
			this.StopRecording.Text = "Stop Recording Script to Flash";
			this.StopRecording.UseVisualStyleBackColor = true;
			this.StopRecording.Click += new System.EventHandler(this.StopRecording_Click);
			// 
			// StartRecording
			// 
			this.StartRecording.Location = new System.Drawing.Point(20, 20);
			this.StartRecording.Name = "StartRecording";
			this.StartRecording.Size = new System.Drawing.Size(198, 23);
			this.StartRecording.TabIndex = 23;
			this.StartRecording.Text = "Start Recording Script to Flash";
			this.StartRecording.UseVisualStyleBackColor = true;
			this.StartRecording.Click += new System.EventHandler(this.StartRecording_Click);
			// 
			// SetDeviceID
			// 
			this.SetDeviceID.Location = new System.Drawing.Point(303, 49);
			this.SetDeviceID.Name = "SetDeviceID";
			this.SetDeviceID.Size = new System.Drawing.Size(140, 33);
			this.SetDeviceID.TabIndex = 21;
			this.SetDeviceID.Text = "Set Device ID";
			this.SetDeviceID.UseVisualStyleBackColor = true;
			this.SetDeviceID.Click += new System.EventHandler(this.SetDeviceID_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(300, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Device Id:";
			// 
			// DeviceId
			// 
			this.DeviceId.Location = new System.Drawing.Point(371, 23);
			this.DeviceId.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.DeviceId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DeviceId.Name = "DeviceId";
			this.DeviceId.ReadOnly = true;
			this.DeviceId.Size = new System.Drawing.Size(71, 20);
			this.DeviceId.TabIndex = 19;
			this.DeviceId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.lblState);
			this.tabPage4.Controls.Add(this.GetState);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.butReleased);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Controls.Add(this.butPressed);
			this.tabPage4.Controls.Add(this.SetTemporary);
			this.tabPage4.Controls.Add(this.SetPerminent);
			this.tabPage4.Controls.Add(this.Url);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(473, 238);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "USB Button";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(366, 82);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(52, 13);
			this.lblState.TabIndex = 8;
			this.lblState.Text = "Released";
			// 
			// GetState
			// 
			this.GetState.Location = new System.Drawing.Point(285, 77);
			this.GetState.Name = "GetState";
			this.GetState.Size = new System.Drawing.Size(75, 23);
			this.GetState.TabIndex = 7;
			this.GetState.Text = "Get State";
			this.GetState.UseVisualStyleBackColor = true;
			this.GetState.Click += new System.EventHandler(this.GetState_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(207, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Released";
			// 
			// butReleased
			// 
			this.butReleased.BackColor = System.Drawing.Color.Red;
			this.butReleased.Location = new System.Drawing.Point(211, 58);
			this.butReleased.Name = "butReleased";
			this.butReleased.Size = new System.Drawing.Size(43, 42);
			this.butReleased.TabIndex = 5;
			this.butReleased.UseVisualStyleBackColor = false;
			this.butReleased.Click += new System.EventHandler(this.butReleased_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(78, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Pressed";
			// 
			// butPressed
			// 
			this.butPressed.BackColor = System.Drawing.Color.Lime;
			this.butPressed.Location = new System.Drawing.Point(78, 58);
			this.butPressed.Name = "butPressed";
			this.butPressed.Size = new System.Drawing.Size(43, 42);
			this.butPressed.TabIndex = 3;
			this.butPressed.UseVisualStyleBackColor = false;
			this.butPressed.Click += new System.EventHandler(this.butPressed_Click);
			// 
			// SetTemporary
			// 
			this.SetTemporary.Location = new System.Drawing.Point(263, 178);
			this.SetTemporary.Name = "SetTemporary";
			this.SetTemporary.Size = new System.Drawing.Size(126, 29);
			this.SetTemporary.TabIndex = 2;
			this.SetTemporary.Text = "Set Temporary";
			this.SetTemporary.UseVisualStyleBackColor = true;
			this.SetTemporary.Click += new System.EventHandler(this.SetTemporary_Click);
			// 
			// SetPerminent
			// 
			this.SetPerminent.Location = new System.Drawing.Point(78, 178);
			this.SetPerminent.Name = "SetPerminent";
			this.SetPerminent.Size = new System.Drawing.Size(126, 29);
			this.SetPerminent.TabIndex = 1;
			this.SetPerminent.Text = "Set Perminent";
			this.SetPerminent.UseVisualStyleBackColor = true;
			this.SetPerminent.Click += new System.EventHandler(this.SetPerminent_Click);
			// 
			// Url
			// 
			this.Url.Location = new System.Drawing.Point(40, 128);
			this.Url.Name = "Url";
			this.Url.Size = new System.Drawing.Size(394, 20);
			this.Url.TabIndex = 0;
			this.Url.Text = "This is a test";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 405);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PacDrive Test";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LEDGroup)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LEDNumber)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ScriptStepDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FadeTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeviceId)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwDevices;
        private System.Windows.Forms.ColumnHeader colVendorId;
        private System.Windows.Forms.ColumnHeader colProductId;
        private System.Windows.Forms.ColumnHeader colVersionNumber;
        private System.Windows.Forms.ColumnHeader colVendorName;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colSerialNumber;
        private System.Windows.Forms.ColumnHeader colDevicePath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LEDNumber;
        private System.Windows.Forms.TrackBar Intensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LEDGroup;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.TrackBar ScriptStepDelay;
        internal System.Windows.Forms.TrackBar FadeTime;
        internal System.Windows.Forms.Button RunScript;
        internal System.Windows.Forms.Button ClearFlash;
        internal System.Windows.Forms.Button StopRecording;
        internal System.Windows.Forms.Button StartRecording;
        private System.Windows.Forms.Button SetDeviceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DeviceId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ProgUHID;
        private System.Windows.Forms.ColumnHeader colDeviceType;
        private System.Windows.Forms.RadioButton rdoSeconds_0_5;
        private System.Windows.Forms.RadioButton rdoSeconds_1;
        private System.Windows.Forms.RadioButton rdoSeconds_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoAlwaysOn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.Button SetTemporary;
        private System.Windows.Forms.Button SetPerminent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butReleased;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butPressed;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button GetState;

    }
}

