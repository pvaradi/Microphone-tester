namespace Proba
{
    partial class Form2
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
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxTestType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericLowerTestLimit = new System.Windows.Forms.NumericUpDown();
            this.numericUpperTestLimit = new System.Windows.Forms.NumericUpDown();
            this.labelLowerTestLimit = new System.Windows.Forms.Label();
            this.labelUpperTestLimit = new System.Windows.Forms.Label();
            this.textBoxTestID = new System.Windows.Forms.TextBox();
            this.labelTestID = new System.Windows.Forms.Label();
            this.labelTestType = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelPartNo = new System.Windows.Forms.Label();
            this.labelPartInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowerTestLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpperTestLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.Location = new System.Drawing.Point(136, 73);
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxPartNumber.TabIndex = 0;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Items.AddRange(new object[] {
            "Airbus",
            "Audi",
            "BMW",
            "DAG",
            "Ferrari",
            "Ford",
            "Geely",
            "GM",
            "IAC",
            "IVECO",
            "JLR",
            "LOEWE",
            "Magna",
            "Maserati",
            "McLaren",
            "Porsche",
            "PSA",
            "SEAT",
            "Volvo"});
            this.comboBoxCustomer.Location = new System.Drawing.Point(136, 114);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomer.TabIndex = 1;
            this.comboBoxCustomer.Text = "Ford";
            // 
            // comboBoxTestType
            // 
            this.comboBoxTestType.FormattingEnabled = true;
            this.comboBoxTestType.Items.AddRange(new object[] {
            "External Test",
            "Internal Test",
            "Product Audit",
            "Qualification",
            "ReQualification",
            "Warranty"});
            this.comboBoxTestType.Location = new System.Drawing.Point(136, 154);
            this.comboBoxTestType.Name = "comboBoxTestType";
            this.comboBoxTestType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTestType.TabIndex = 2;
            this.comboBoxTestType.Text = "Warranty";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.numericLowerTestLimit);
            this.panel1.Controls.Add(this.numericUpperTestLimit);
            this.panel1.Controls.Add(this.labelLowerTestLimit);
            this.panel1.Controls.Add(this.labelUpperTestLimit);
            this.panel1.Controls.Add(this.textBoxTestID);
            this.panel1.Controls.Add(this.labelTestID);
            this.panel1.Controls.Add(this.labelTestType);
            this.panel1.Controls.Add(this.labelCustomer);
            this.panel1.Controls.Add(this.labelPartNo);
            this.panel1.Controls.Add(this.labelPartInfo);
            this.panel1.Controls.Add(this.textBoxPartNumber);
            this.panel1.Controls.Add(this.comboBoxTestType);
            this.panel1.Controls.Add(this.comboBoxCustomer);
            this.panel1.Location = new System.Drawing.Point(30, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 311);
            this.panel1.TabIndex = 4;
            // 
            // numericLowerTestLimit
            // 
            this.numericLowerTestLimit.Location = new System.Drawing.Point(137, 265);
            this.numericLowerTestLimit.Name = "numericLowerTestLimit";
            this.numericLowerTestLimit.Size = new System.Drawing.Size(120, 20);
            this.numericLowerTestLimit.TabIndex = 27;
            this.numericLowerTestLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpperTestLimit
            // 
            this.numericUpperTestLimit.Location = new System.Drawing.Point(136, 230);
            this.numericUpperTestLimit.Name = "numericUpperTestLimit";
            this.numericUpperTestLimit.Size = new System.Drawing.Size(120, 20);
            this.numericUpperTestLimit.TabIndex = 26;
            this.numericUpperTestLimit.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labelLowerTestLimit
            // 
            this.labelLowerTestLimit.AutoSize = true;
            this.labelLowerTestLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLowerTestLimit.Location = new System.Drawing.Point(15, 265);
            this.labelLowerTestLimit.Name = "labelLowerTestLimit";
            this.labelLowerTestLimit.Size = new System.Drawing.Size(100, 20);
            this.labelLowerTestLimit.TabIndex = 25;
            this.labelLowerTestLimit.Text = "Lower Limit";
            // 
            // labelUpperTestLimit
            // 
            this.labelUpperTestLimit.AutoSize = true;
            this.labelUpperTestLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUpperTestLimit.Location = new System.Drawing.Point(15, 230);
            this.labelUpperTestLimit.Name = "labelUpperTestLimit";
            this.labelUpperTestLimit.Size = new System.Drawing.Size(101, 20);
            this.labelUpperTestLimit.TabIndex = 24;
            this.labelUpperTestLimit.Text = "Upper Limit";
            // 
            // textBoxTestID
            // 
            this.textBoxTestID.Enabled = false;
            this.textBoxTestID.Location = new System.Drawing.Point(136, 193);
            this.textBoxTestID.Name = "textBoxTestID";
            this.textBoxTestID.Size = new System.Drawing.Size(121, 20);
            this.textBoxTestID.TabIndex = 23;
            // 
            // labelTestID
            // 
            this.labelTestID.AutoSize = true;
            this.labelTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTestID.Location = new System.Drawing.Point(15, 190);
            this.labelTestID.Name = "labelTestID";
            this.labelTestID.Size = new System.Drawing.Size(63, 20);
            this.labelTestID.TabIndex = 22;
            this.labelTestID.Text = "TestID";
            // 
            // labelTestType
            // 
            this.labelTestType.AutoSize = true;
            this.labelTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTestType.Location = new System.Drawing.Point(15, 154);
            this.labelTestType.Name = "labelTestType";
            this.labelTestType.Size = new System.Drawing.Size(83, 20);
            this.labelTestType.TabIndex = 9;
            this.labelTestType.Text = "Test type";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomer.Location = new System.Drawing.Point(15, 114);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(86, 20);
            this.labelCustomer.TabIndex = 8;
            this.labelCustomer.Text = "Customer";
            // 
            // labelPartNo
            // 
            this.labelPartNo.AutoSize = true;
            this.labelPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPartNo.Location = new System.Drawing.Point(15, 73);
            this.labelPartNo.Name = "labelPartNo";
            this.labelPartNo.Size = new System.Drawing.Size(107, 20);
            this.labelPartNo.TabIndex = 7;
            this.labelPartNo.Text = "Part number";
            // 
            // labelPartInfo
            // 
            this.labelPartInfo.AutoSize = true;
            this.labelPartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPartInfo.Location = new System.Drawing.Point(15, 17);
            this.labelPartInfo.Name = "labelPartInfo";
            this.labelPartInfo.Size = new System.Drawing.Size(137, 20);
            this.labelPartInfo.TabIndex = 6;
            this.labelPartInfo.Text = "Part information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Channel 1 - configuration";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveConfig.Location = new System.Drawing.Point(30, 386);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(267, 45);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 443);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Channel Configuration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowerTestLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpperTestLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxTestType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTestType;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelPartNo;
        private System.Windows.Forms.Label labelPartInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.TextBox textBoxTestID;
        private System.Windows.Forms.Label labelTestID;
        private System.Windows.Forms.NumericUpDown numericLowerTestLimit;
        private System.Windows.Forms.NumericUpDown numericUpperTestLimit;
        private System.Windows.Forms.Label labelLowerTestLimit;
        private System.Windows.Forms.Label labelUpperTestLimit;
    }
}