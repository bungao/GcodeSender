namespace GrblOutput {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rowsInFileLbl = new System.Windows.Forms.Label();
            this.sentRowsLbl = new System.Windows.Forms.Label();
            this.stopPrintBtn = new System.Windows.Forms.Button();
            this.serialResponseList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.speedOverrideNumber = new System.Windows.Forms.NumericUpDown();
            this.overrideSpeedChkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollOutputChkbox = new System.Windows.Forms.CheckBox();
            this.settingsBox1 = new System.Windows.Forms.ListView();
            this.Setting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddSettingTextBox = new System.Windows.Forms.TextBox();
            this.AddSettingButton1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LoadDeviceSettingsButton = new System.Windows.Forms.Button();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(231, 32);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 24);
            this.BrowseBtn.TabIndex = 0;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(102, 61);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 24);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Open";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 2;
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(183, 61);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 24);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Close";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(6, 59);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(52, 24);
            this.PrintBtn.TabIndex = 8;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // rowsInFileLbl
            // 
            this.rowsInFileLbl.AutoSize = true;
            this.rowsInFileLbl.Location = new System.Drawing.Point(112, 93);
            this.rowsInFileLbl.Name = "rowsInFileLbl";
            this.rowsInFileLbl.Size = new System.Drawing.Size(46, 13);
            this.rowsInFileLbl.TabIndex = 12;
            this.rowsInFileLbl.Text = "Rows: 0";
            // 
            // sentRowsLbl
            // 
            this.sentRowsLbl.AutoSize = true;
            this.sentRowsLbl.Location = new System.Drawing.Point(6, 93);
            this.sentRowsLbl.Name = "sentRowsLbl";
            this.sentRowsLbl.Size = new System.Drawing.Size(66, 13);
            this.sentRowsLbl.TabIndex = 13;
            this.sentRowsLbl.Text = "Sent rows: 0";
            // 
            // stopPrintBtn
            // 
            this.stopPrintBtn.Enabled = false;
            this.stopPrintBtn.Location = new System.Drawing.Point(64, 59);
            this.stopPrintBtn.Name = "stopPrintBtn";
            this.stopPrintBtn.Size = new System.Drawing.Size(52, 24);
            this.stopPrintBtn.TabIndex = 14;
            this.stopPrintBtn.Text = "Stop";
            this.stopPrintBtn.UseVisualStyleBackColor = true;
            this.stopPrintBtn.Click += new System.EventHandler(this.stopPrintBtn_Click);
            // 
            // serialResponseList
            // 
            this.serialResponseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialResponseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serialResponseList.FormattingEnabled = true;
            this.serialResponseList.Location = new System.Drawing.Point(12, 132);
            this.serialResponseList.Name = "serialResponseList";
            this.serialResponseList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.serialResponseList.Size = new System.Drawing.Size(584, 329);
            this.serialResponseList.TabIndex = 15;
            this.serialResponseList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.serialResponseList_DrawItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.ReloadBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(214, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "\\r\\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(164, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "\\n\\r";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Command";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Image = global::GrblOutput.Properties.Resources.reload_icon1;
            this.ReloadBtn.Location = new System.Drawing.Point(73, 61);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(24, 24);
            this.ReloadBtn.TabIndex = 11;
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.speedOverrideNumber);
            this.groupBox2.Controls.Add(this.overrideSpeedChkbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.BrowseBtn);
            this.groupBox2.Controls.Add(this.PrintBtn);
            this.groupBox2.Controls.Add(this.stopPrintBtn);
            this.groupBox2.Controls.Add(this.rowsInFileLbl);
            this.groupBox2.Controls.Add(this.sentRowsLbl);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 114);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File transfer";
            // 
            // speedOverrideNumber
            // 
            this.speedOverrideNumber.Location = new System.Drawing.Point(122, 61);
            this.speedOverrideNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speedOverrideNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedOverrideNumber.Name = "speedOverrideNumber";
            this.speedOverrideNumber.Size = new System.Drawing.Size(66, 20);
            this.speedOverrideNumber.TabIndex = 18;
            this.speedOverrideNumber.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // overrideSpeedChkbox
            // 
            this.overrideSpeedChkbox.AutoSize = true;
            this.overrideSpeedChkbox.Location = new System.Drawing.Point(194, 64);
            this.overrideSpeedChkbox.Name = "overrideSpeedChkbox";
            this.overrideSpeedChkbox.Size = new System.Drawing.Size(98, 17);
            this.overrideSpeedChkbox.TabIndex = 17;
            this.overrideSpeedChkbox.Text = "Override speed";
            this.overrideSpeedChkbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "File";
            // 
            // scrollOutputChkbox
            // 
            this.scrollOutputChkbox.AutoSize = true;
            this.scrollOutputChkbox.Checked = true;
            this.scrollOutputChkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollOutputChkbox.Location = new System.Drawing.Point(18, 109);
            this.scrollOutputChkbox.Name = "scrollOutputChkbox";
            this.scrollOutputChkbox.Size = new System.Drawing.Size(124, 17);
            this.scrollOutputChkbox.TabIndex = 18;
            this.scrollOutputChkbox.Text = "Scroll output window";
            this.scrollOutputChkbox.UseVisualStyleBackColor = true;
            // 
            // settingsBox1
            // 
            this.settingsBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Setting,
            this.Description});
            this.settingsBox1.FullRowSelect = true;
            this.settingsBox1.LabelEdit = true;
            this.settingsBox1.LabelWrap = false;
            this.settingsBox1.Location = new System.Drawing.Point(6, 61);
            this.settingsBox1.Name = "settingsBox1";
            this.settingsBox1.Size = new System.Drawing.Size(306, 355);
            this.settingsBox1.TabIndex = 19;
            this.settingsBox1.UseCompatibleStateImageBehavior = false;
            this.settingsBox1.View = System.Windows.Forms.View.Details;
            this.settingsBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsBox1_MouseClick);
            this.settingsBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.settingsBox1_MouseDoubleClick);
            // 
            // Setting
            // 
            this.Setting.Text = "Setting";
            this.Setting.Width = 136;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 216;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddSettingTextBox
            // 
            this.AddSettingTextBox.Location = new System.Drawing.Point(6, 38);
            this.AddSettingTextBox.Name = "AddSettingTextBox";
            this.AddSettingTextBox.Size = new System.Drawing.Size(97, 20);
            this.AddSettingTextBox.TabIndex = 20;
            this.AddSettingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddSettingTextBox_KeyPress);
            // 
            // AddSettingButton1
            // 
            this.AddSettingButton1.Location = new System.Drawing.Point(6, 11);
            this.AddSettingButton1.Name = "AddSettingButton1";
            this.AddSettingButton1.Size = new System.Drawing.Size(97, 21);
            this.AddSettingButton1.TabIndex = 21;
            this.AddSettingButton1.Text = "Add Setting";
            this.AddSettingButton1.UseVisualStyleBackColor = true;
            this.AddSettingButton1.Click += new System.EventHandler(this.AddSettingButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.LoadDeviceSettingsButton);
            this.groupBox3.Controls.Add(this.ApplySettingsButton);
            this.groupBox3.Controls.Add(this.AddSettingTextBox);
            this.groupBox3.Controls.Add(this.AddSettingButton1);
            this.groupBox3.Controls.Add(this.settingsBox1);
            this.groupBox3.Location = new System.Drawing.Point(614, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 442);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // LoadDeviceSettingsButton
            // 
            this.LoadDeviceSettingsButton.Location = new System.Drawing.Point(109, 10);
            this.LoadDeviceSettingsButton.Name = "LoadDeviceSettingsButton";
            this.LoadDeviceSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDeviceSettingsButton.TabIndex = 23;
            this.LoadDeviceSettingsButton.Text = "Load Device Settings";
            this.LoadDeviceSettingsButton.UseVisualStyleBackColor = true;
            this.LoadDeviceSettingsButton.Click += new System.EventHandler(this.LoadDeviceSettingsButton_Click);
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplySettingsButton.Location = new System.Drawing.Point(6, 415);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(62, 21);
            this.ApplySettingsButton.TabIndex = 22;
            this.ApplySettingsButton.Text = "Apply";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.scrollOutputChkbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serialResponseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "G-code sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BrowseBtn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button PrintBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ReloadBtn;
		private System.Windows.Forms.Label rowsInFileLbl;
		private System.Windows.Forms.Label sentRowsLbl;
		private System.Windows.Forms.Button stopPrintBtn;
		private System.Windows.Forms.ListBox serialResponseList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckBox scrollOutputChkbox;
		private System.Windows.Forms.CheckBox overrideSpeedChkbox;
		private System.Windows.Forms.NumericUpDown speedOverrideNumber;
        private System.Windows.Forms.ListView settingsBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AddSettingTextBox;
        private System.Windows.Forms.Button AddSettingButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ApplySettingsButton;
        private System.Windows.Forms.Button LoadDeviceSettingsButton;
        private System.Windows.Forms.ColumnHeader Setting;
        private System.Windows.Forms.ColumnHeader Description;
	}
}

