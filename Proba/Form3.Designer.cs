namespace Proba
{
    partial class Form3
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
            this.labelAppConfig = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChamberCommands = new System.Windows.Forms.Button();
            this.comboBoxSignalMode = new System.Windows.Forms.ComboBox();
            this.labelTestMode = new System.Windows.Forms.Label();
            this.textBoxChamberSerial = new System.Windows.Forms.TextBox();
            this.textBoxChamberName = new System.Windows.Forms.TextBox();
            this.labelChamberSerial = new System.Windows.Forms.Label();
            this.labelChamberName = new System.Windows.Forms.Label();
            this.labelInstumentSerial = new System.Windows.Forms.Label();
            this.textBoxInstrumentSerial = new System.Windows.Forms.TextBox();
            this.textBoxInstrumentName = new System.Windows.Forms.TextBox();
            this.labelInstrumentName = new System.Windows.Forms.Label();
            this.maskedTextBoxTCPPort = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTCPAddress = new System.Windows.Forms.MaskedTextBox();
            this.labelTCPPort = new System.Windows.Forms.Label();
            this.labelTCPaddress = new System.Windows.Forms.Label();
            this.labelHandshaking = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxHandshaking = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.btnLogFilePath = new System.Windows.Forms.Button();
            this.labelChamberConfig = new System.Windows.Forms.Label();
            this.labelCOMPortConfig = new System.Windows.Forms.Label();
            this.labelLogFileLocation = new System.Windows.Forms.Label();
            this.labelFilePathSettings = new System.Windows.Forms.Label();
            this.labelScanRate = new System.Windows.Forms.Label();
            this.numericUpDownScanRate = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppConfig
            // 
            this.labelAppConfig.AutoSize = true;
            this.labelAppConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAppConfig.Location = new System.Drawing.Point(274, 22);
            this.labelAppConfig.Name = "labelAppConfig";
            this.labelAppConfig.Size = new System.Drawing.Size(279, 26);
            this.labelAppConfig.TabIndex = 6;
            this.labelAppConfig.Text = "Application Configuration";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveSettings.Location = new System.Drawing.Point(278, 567);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(267, 45);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Save Configuration";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.numericUpDownScanRate);
            this.panel1.Controls.Add(this.labelScanRate);
            this.panel1.Controls.Add(this.btnChamberCommands);
            this.panel1.Controls.Add(this.comboBoxSignalMode);
            this.panel1.Controls.Add(this.labelTestMode);
            this.panel1.Controls.Add(this.textBoxChamberSerial);
            this.panel1.Controls.Add(this.textBoxChamberName);
            this.panel1.Controls.Add(this.labelChamberSerial);
            this.panel1.Controls.Add(this.labelChamberName);
            this.panel1.Controls.Add(this.labelInstumentSerial);
            this.panel1.Controls.Add(this.textBoxInstrumentSerial);
            this.panel1.Controls.Add(this.textBoxInstrumentName);
            this.panel1.Controls.Add(this.labelInstrumentName);
            this.panel1.Controls.Add(this.maskedTextBoxTCPPort);
            this.panel1.Controls.Add(this.maskedTextBoxTCPAddress);
            this.panel1.Controls.Add(this.labelTCPPort);
            this.panel1.Controls.Add(this.labelTCPaddress);
            this.panel1.Controls.Add(this.labelHandshaking);
            this.panel1.Controls.Add(this.labelParity);
            this.panel1.Controls.Add(this.labelStopBits);
            this.panel1.Controls.Add(this.labelDataBits);
            this.panel1.Controls.Add(this.labelBaudRate);
            this.panel1.Controls.Add(this.labelComPort);
            this.panel1.Controls.Add(this.comboBoxHandshaking);
            this.panel1.Controls.Add(this.comboBoxParity);
            this.panel1.Controls.Add(this.comboBoxStopBits);
            this.panel1.Controls.Add(this.comboBoxDataBits);
            this.panel1.Controls.Add(this.comboBoxBaudRate);
            this.panel1.Controls.Add(this.comboBoxComPort);
            this.panel1.Controls.Add(this.btnLogFilePath);
            this.panel1.Controls.Add(this.labelChamberConfig);
            this.panel1.Controls.Add(this.labelCOMPortConfig);
            this.panel1.Controls.Add(this.labelLogFileLocation);
            this.panel1.Controls.Add(this.labelFilePathSettings);
            this.panel1.Location = new System.Drawing.Point(31, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 509);
            this.panel1.TabIndex = 8;
            // 
            // btnChamberCommands
            // 
            this.btnChamberCommands.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChamberCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChamberCommands.Location = new System.Drawing.Point(391, 383);
            this.btnChamberCommands.Name = "btnChamberCommands";
            this.btnChamberCommands.Size = new System.Drawing.Size(287, 60);
            this.btnChamberCommands.TabIndex = 44;
            this.btnChamberCommands.Text = "Chamber commands configuration";
            this.btnChamberCommands.UseVisualStyleBackColor = false;
            this.btnChamberCommands.Click += new System.EventHandler(this.btnChamberCommands_Click);
            // 
            // comboBoxSignalMode
            // 
            this.comboBoxSignalMode.FormattingEnabled = true;
            this.comboBoxSignalMode.Items.AddRange(new object[] {
            "Timer",
            "Chamber controlled"});
            this.comboBoxSignalMode.Location = new System.Drawing.Point(539, 330);
            this.comboBoxSignalMode.Name = "comboBoxSignalMode";
            this.comboBoxSignalMode.Size = new System.Drawing.Size(139, 21);
            this.comboBoxSignalMode.TabIndex = 42;
            this.comboBoxSignalMode.Text = "Chamber controlled";
            // 
            // labelTestMode
            // 
            this.labelTestMode.AutoSize = true;
            this.labelTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTestMode.Location = new System.Drawing.Point(387, 330);
            this.labelTestMode.Name = "labelTestMode";
            this.labelTestMode.Size = new System.Drawing.Size(84, 17);
            this.labelTestMode.TabIndex = 41;
            this.labelTestMode.Text = "Test mode";
            // 
            // textBoxChamberSerial
            // 
            this.textBoxChamberSerial.Location = new System.Drawing.Point(539, 303);
            this.textBoxChamberSerial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChamberSerial.Name = "textBoxChamberSerial";
            this.textBoxChamberSerial.Size = new System.Drawing.Size(139, 20);
            this.textBoxChamberSerial.TabIndex = 40;
            // 
            // textBoxChamberName
            // 
            this.textBoxChamberName.Location = new System.Drawing.Point(539, 276);
            this.textBoxChamberName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChamberName.Name = "textBoxChamberName";
            this.textBoxChamberName.Size = new System.Drawing.Size(139, 20);
            this.textBoxChamberName.TabIndex = 39;
            // 
            // labelChamberSerial
            // 
            this.labelChamberSerial.AutoSize = true;
            this.labelChamberSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChamberSerial.Location = new System.Drawing.Point(387, 303);
            this.labelChamberSerial.Name = "labelChamberSerial";
            this.labelChamberSerial.Size = new System.Drawing.Size(109, 17);
            this.labelChamberSerial.TabIndex = 38;
            this.labelChamberSerial.Text = "Serial number";
            // 
            // labelChamberName
            // 
            this.labelChamberName.AutoSize = true;
            this.labelChamberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChamberName.Location = new System.Drawing.Point(387, 276);
            this.labelChamberName.Name = "labelChamberName";
            this.labelChamberName.Size = new System.Drawing.Size(116, 17);
            this.labelChamberName.TabIndex = 37;
            this.labelChamberName.Text = "Chamber name";
            // 
            // labelInstumentSerial
            // 
            this.labelInstumentSerial.AutoSize = true;
            this.labelInstumentSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstumentSerial.Location = new System.Drawing.Point(64, 410);
            this.labelInstumentSerial.Name = "labelInstumentSerial";
            this.labelInstumentSerial.Size = new System.Drawing.Size(109, 17);
            this.labelInstumentSerial.TabIndex = 36;
            this.labelInstumentSerial.Text = "Serial number";
            // 
            // textBoxInstrumentSerial
            // 
            this.textBoxInstrumentSerial.Location = new System.Drawing.Point(195, 407);
            this.textBoxInstrumentSerial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInstrumentSerial.Name = "textBoxInstrumentSerial";
            this.textBoxInstrumentSerial.Size = new System.Drawing.Size(122, 20);
            this.textBoxInstrumentSerial.TabIndex = 35;
            // 
            // textBoxInstrumentName
            // 
            this.textBoxInstrumentName.Location = new System.Drawing.Point(195, 383);
            this.textBoxInstrumentName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInstrumentName.Name = "textBoxInstrumentName";
            this.textBoxInstrumentName.Size = new System.Drawing.Size(122, 20);
            this.textBoxInstrumentName.TabIndex = 34;
            // 
            // labelInstrumentName
            // 
            this.labelInstrumentName.AutoSize = true;
            this.labelInstrumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstrumentName.Location = new System.Drawing.Point(64, 382);
            this.labelInstrumentName.Name = "labelInstrumentName";
            this.labelInstrumentName.Size = new System.Drawing.Size(128, 17);
            this.labelInstrumentName.TabIndex = 33;
            this.labelInstrumentName.Text = "Instrument name";
            // 
            // maskedTextBoxTCPPort
            // 
            this.maskedTextBoxTCPPort.Location = new System.Drawing.Point(539, 249);
            this.maskedTextBoxTCPPort.Name = "maskedTextBoxTCPPort";
            this.maskedTextBoxTCPPort.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBoxTCPPort.TabIndex = 32;
            // 
            // maskedTextBoxTCPAddress
            // 
            this.maskedTextBoxTCPAddress.Location = new System.Drawing.Point(539, 222);
            this.maskedTextBoxTCPAddress.Name = "maskedTextBoxTCPAddress";
            this.maskedTextBoxTCPAddress.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBoxTCPAddress.TabIndex = 31;
            // 
            // labelTCPPort
            // 
            this.labelTCPPort.AutoSize = true;
            this.labelTCPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTCPPort.Location = new System.Drawing.Point(387, 249);
            this.labelTCPPort.Name = "labelTCPPort";
            this.labelTCPPort.Size = new System.Drawing.Size(135, 17);
            this.labelTCPPort.TabIndex = 30;
            this.labelTCPPort.Text = "TCP port address";
            // 
            // labelTCPaddress
            // 
            this.labelTCPaddress.AutoSize = true;
            this.labelTCPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTCPaddress.Location = new System.Drawing.Point(387, 222);
            this.labelTCPaddress.Name = "labelTCPaddress";
            this.labelTCPaddress.Size = new System.Drawing.Size(145, 17);
            this.labelTCPaddress.TabIndex = 29;
            this.labelTCPaddress.Text = "TCP client address";
            // 
            // labelHandshaking
            // 
            this.labelHandshaking.AutoSize = true;
            this.labelHandshaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHandshaking.Location = new System.Drawing.Point(64, 357);
            this.labelHandshaking.Name = "labelHandshaking";
            this.labelHandshaking.Size = new System.Drawing.Size(102, 17);
            this.labelHandshaking.TabIndex = 28;
            this.labelHandshaking.Text = "Handshaking";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParity.Location = new System.Drawing.Point(64, 330);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(50, 17);
            this.labelParity.TabIndex = 27;
            this.labelParity.Text = "Parity";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStopBits.Location = new System.Drawing.Point(64, 303);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(73, 17);
            this.labelStopBits.TabIndex = 26;
            this.labelStopBits.Text = "Stop Bits";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDataBits.Location = new System.Drawing.Point(64, 276);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(74, 17);
            this.labelDataBits.TabIndex = 25;
            this.labelDataBits.Text = "Data Bits";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBaudRate.Location = new System.Drawing.Point(64, 249);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(84, 17);
            this.labelBaudRate.TabIndex = 24;
            this.labelBaudRate.Text = "Buad Rate";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComPort.Location = new System.Drawing.Point(64, 222);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(74, 17);
            this.labelComPort.TabIndex = 23;
            this.labelComPort.Text = "Com Port";
            // 
            // comboBoxHandshaking
            // 
            this.comboBoxHandshaking.FormattingEnabled = true;
            this.comboBoxHandshaking.Location = new System.Drawing.Point(196, 357);
            this.comboBoxHandshaking.Name = "comboBoxHandshaking";
            this.comboBoxHandshaking.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHandshaking.TabIndex = 22;
            this.comboBoxHandshaking.Text = "XOnXOff";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(196, 330);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 21;
            this.comboBoxParity.Text = "None";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(196, 303);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopBits.TabIndex = 20;
            this.comboBoxStopBits.Text = "One";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(196, 276);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataBits.TabIndex = 19;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(196, 249);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(122, 21);
            this.comboBoxBaudRate.TabIndex = 18;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(197, 221);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 17;
            this.comboBoxComPort.Text = "Com Port";
            // 
            // btnLogFilePath
            // 
            this.btnLogFilePath.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogFilePath.Location = new System.Drawing.Point(45, 99);
            this.btnLogFilePath.Name = "btnLogFilePath";
            this.btnLogFilePath.Size = new System.Drawing.Size(243, 45);
            this.btnLogFilePath.TabIndex = 16;
            this.btnLogFilePath.Text = "Change test Log location";
            this.btnLogFilePath.UseVisualStyleBackColor = false;
            this.btnLogFilePath.Click += new System.EventHandler(this.btnLogFilePath_Click);
            // 
            // labelChamberConfig
            // 
            this.labelChamberConfig.AutoSize = true;
            this.labelChamberConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChamberConfig.Location = new System.Drawing.Point(444, 186);
            this.labelChamberConfig.Name = "labelChamberConfig";
            this.labelChamberConfig.Size = new System.Drawing.Size(191, 20);
            this.labelChamberConfig.TabIndex = 13;
            this.labelChamberConfig.Text = "Chamber configuration";
            // 
            // labelCOMPortConfig
            // 
            this.labelCOMPortConfig.AutoSize = true;
            this.labelCOMPortConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCOMPortConfig.Location = new System.Drawing.Point(41, 186);
            this.labelCOMPortConfig.Name = "labelCOMPortConfig";
            this.labelCOMPortConfig.Size = new System.Drawing.Size(196, 20);
            this.labelCOMPortConfig.TabIndex = 12;
            this.labelCOMPortConfig.Text = "COM Port configuration";
            // 
            // labelLogFileLocation
            // 
            this.labelLogFileLocation.AutoSize = true;
            this.labelLogFileLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelLogFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogFileLocation.Location = new System.Drawing.Point(386, 111);
            this.labelLogFileLocation.Name = "labelLogFileLocation";
            this.labelLogFileLocation.Size = new System.Drawing.Size(28, 20);
            this.labelLogFileLocation.TabIndex = 11;
            this.labelLogFileLocation.Text = "C:\\";
            // 
            // labelFilePathSettings
            // 
            this.labelFilePathSettings.AutoSize = true;
            this.labelFilePathSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilePathSettings.Location = new System.Drawing.Point(41, 43);
            this.labelFilePathSettings.Name = "labelFilePathSettings";
            this.labelFilePathSettings.Size = new System.Drawing.Size(148, 20);
            this.labelFilePathSettings.TabIndex = 9;
            this.labelFilePathSettings.Text = "File path settings";
            // 
            // labelScanRate
            // 
            this.labelScanRate.AutoSize = true;
            this.labelScanRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanRate.Location = new System.Drawing.Point(64, 433);
            this.labelScanRate.Name = "labelScanRate";
            this.labelScanRate.Size = new System.Drawing.Size(125, 17);
            this.labelScanRate.TabIndex = 45;
            this.labelScanRate.Text = "Scan Rate (sec)";
            // 
            // numericUpDownScanRate
            // 
            this.numericUpDownScanRate.Location = new System.Drawing.Point(195, 433);
            this.numericUpDownScanRate.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownScanRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownScanRate.Name = "numericUpDownScanRate";
            this.numericUpDownScanRate.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownScanRate.TabIndex = 46;
            this.numericUpDownScanRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.labelAppConfig);
            this.Name = "Form3";
            this.Text = "Application Configuration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppConfig;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFilePathSettings;
        private System.Windows.Forms.Label labelChamberConfig;
        private System.Windows.Forms.Label labelCOMPortConfig;
        private System.Windows.Forms.Label labelLogFileLocation;
        private System.Windows.Forms.Button btnLogFilePath;
        private System.Windows.Forms.ComboBox comboBoxHandshaking;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelHandshaking;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTCPAddress;
        private System.Windows.Forms.Label labelTCPPort;
        private System.Windows.Forms.Label labelTCPaddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTCPPort;
        private System.Windows.Forms.TextBox textBoxChamberSerial;
        private System.Windows.Forms.TextBox textBoxChamberName;
        private System.Windows.Forms.Label labelChamberSerial;
        private System.Windows.Forms.Label labelChamberName;
        private System.Windows.Forms.Label labelInstumentSerial;
        private System.Windows.Forms.TextBox textBoxInstrumentSerial;
        private System.Windows.Forms.TextBox textBoxInstrumentName;
        private System.Windows.Forms.Label labelInstrumentName;
        private System.Windows.Forms.ComboBox comboBoxSignalMode;
        private System.Windows.Forms.Label labelTestMode;
        private System.Windows.Forms.Button btnChamberCommands;
        private System.Windows.Forms.NumericUpDown numericUpDownScanRate;
        private System.Windows.Forms.Label labelScanRate;
    }
}