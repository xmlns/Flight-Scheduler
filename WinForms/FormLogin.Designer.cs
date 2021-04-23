namespace CovidAirlines
{
    partial class FormLogin
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ErrorMessage = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.labelCreateAccount = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.groupBoxBilling = new System.Windows.Forms.GroupBox();
			this.comboBoxMonth = new System.Windows.Forms.ComboBox();
			this.comboBoxYear = new System.Windows.Forms.ComboBox();
			this.textBoxCSV = new System.Windows.Forms.TextBox();
			this.textBoxCC = new System.Windows.Forms.TextBox();
			this.labelCSV = new System.Windows.Forms.Label();
			this.labelExpiration = new System.Windows.Forms.Label();
			this.labelCC = new System.Windows.Forms.Label();
			this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.labelConfirmPassword = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.numericAge = new System.Windows.Forms.NumericUpDown();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxZipcode = new System.Windows.Forms.TextBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelAge = new System.Windows.Forms.Label();
			this.labelZipcode = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.labelAddress = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBoxBilling.SuspendLayout();
			this.groupBoxContactInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(142, 125);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 207);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 163);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "UserID";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(73, 203);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(1);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(206, 20);
			this.PasswordTextBox.TabIndex = 1;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(73, 160);
			this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(1);
			this.UsernameTextBox.Multiline = true;
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(206, 20);
			this.UsernameTextBox.TabIndex = 0;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(112, 240);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(1);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(102, 29);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ErrorMessage);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.LoginButton);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.UsernameTextBox);
			this.splitContainer1.Panel1.Controls.Add(this.PasswordTextBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.labelResult);
			this.splitContainer1.Panel2.Controls.Add(this.labelCreateAccount);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.buttonSubmit);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxBilling);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxContactInfo);
			this.splitContainer1.Size = new System.Drawing.Size(645, 426);
			this.splitContainer1.SplitterDistance = 304;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer1.TabStop = false;
			// 
			// ErrorMessage
			// 
			this.ErrorMessage.AutoSize = true;
			this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ErrorMessage.Location = new System.Drawing.Point(19, 143);
			this.ErrorMessage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.ErrorMessage.Name = "ErrorMessage";
			this.ErrorMessage.Size = new System.Drawing.Size(125, 13);
			this.ErrorMessage.TabIndex = 7;
			this.ErrorMessage.Text = "Error Messages Here";
			this.ErrorMessage.Visible = false;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResult.Location = new System.Drawing.Point(3, 403);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(269, 13);
			this.labelResult.TabIndex = 10;
			this.labelResult.Text = "Create Account Confirm/Reject Message Here";
			this.labelResult.Visible = false;
			// 
			// labelCreateAccount
			// 
			this.labelCreateAccount.AutoSize = true;
			this.labelCreateAccount.Location = new System.Drawing.Point(125, 11);
			this.labelCreateAccount.Name = "labelCreateAccount";
			this.labelCreateAccount.Size = new System.Drawing.Size(96, 13);
			this.labelCreateAccount.TabIndex = 4;
			this.labelCreateAccount.Text = "Create an Account";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(573, 297);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(9, 8);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSubmit.Location = new System.Drawing.Point(3, 372);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(327, 23);
			this.buttonSubmit.TabIndex = 5;
			this.buttonSubmit.Text = "Create Account";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// groupBoxBilling
			// 
			this.groupBoxBilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxBilling.Controls.Add(this.comboBoxMonth);
			this.groupBoxBilling.Controls.Add(this.comboBoxYear);
			this.groupBoxBilling.Controls.Add(this.textBoxCSV);
			this.groupBoxBilling.Controls.Add(this.textBoxCC);
			this.groupBoxBilling.Controls.Add(this.labelCSV);
			this.groupBoxBilling.Controls.Add(this.labelExpiration);
			this.groupBoxBilling.Controls.Add(this.labelCC);
			this.groupBoxBilling.Location = new System.Drawing.Point(3, 262);
			this.groupBoxBilling.Name = "groupBoxBilling";
			this.groupBoxBilling.Size = new System.Drawing.Size(327, 104);
			this.groupBoxBilling.TabIndex = 4;
			this.groupBoxBilling.TabStop = false;
			this.groupBoxBilling.Text = "Billing Information";
			// 
			// comboBoxMonth
			// 
			this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMonth.FormattingEnabled = true;
			this.comboBoxMonth.Location = new System.Drawing.Point(114, 49);
			this.comboBoxMonth.Name = "comboBoxMonth";
			this.comboBoxMonth.Size = new System.Drawing.Size(49, 21);
			this.comboBoxMonth.TabIndex = 1;
			// 
			// comboBoxYear
			// 
			this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxYear.FormattingEnabled = true;
			this.comboBoxYear.Location = new System.Drawing.Point(179, 49);
			this.comboBoxYear.Name = "comboBoxYear";
			this.comboBoxYear.Size = new System.Drawing.Size(49, 21);
			this.comboBoxYear.TabIndex = 2;
			// 
			// textBoxCSV
			// 
			this.textBoxCSV.Location = new System.Drawing.Point(114, 77);
			this.textBoxCSV.Name = "textBoxCSV";
			this.textBoxCSV.Size = new System.Drawing.Size(49, 20);
			this.textBoxCSV.TabIndex = 3;
			// 
			// textBoxCC
			// 
			this.textBoxCC.Location = new System.Drawing.Point(114, 23);
			this.textBoxCC.Name = "textBoxCC";
			this.textBoxCC.Size = new System.Drawing.Size(197, 20);
			this.textBoxCC.TabIndex = 0;
			// 
			// labelCSV
			// 
			this.labelCSV.AutoSize = true;
			this.labelCSV.Location = new System.Drawing.Point(80, 80);
			this.labelCSV.Name = "labelCSV";
			this.labelCSV.Size = new System.Drawing.Size(28, 13);
			this.labelCSV.TabIndex = 0;
			this.labelCSV.Text = "CSV";
			// 
			// labelExpiration
			// 
			this.labelExpiration.AutoSize = true;
			this.labelExpiration.Location = new System.Drawing.Point(29, 53);
			this.labelExpiration.Name = "labelExpiration";
			this.labelExpiration.Size = new System.Drawing.Size(79, 13);
			this.labelExpiration.TabIndex = 0;
			this.labelExpiration.Text = "Expiration Date";
			// 
			// labelCC
			// 
			this.labelCC.AutoSize = true;
			this.labelCC.Location = new System.Drawing.Point(9, 27);
			this.labelCC.Name = "labelCC";
			this.labelCC.Size = new System.Drawing.Size(99, 13);
			this.labelCC.TabIndex = 0;
			this.labelCC.Text = "Credit Card Number";
			// 
			// groupBoxContactInfo
			// 
			this.groupBoxContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxContactInfo.Controls.Add(this.textBoxConfirmPassword);
			this.groupBoxContactInfo.Controls.Add(this.labelConfirmPassword);
			this.groupBoxContactInfo.Controls.Add(this.labelPassword);
			this.groupBoxContactInfo.Controls.Add(this.textBoxPassword);
			this.groupBoxContactInfo.Controls.Add(this.numericAge);
			this.groupBoxContactInfo.Controls.Add(this.textBoxNumber);
			this.groupBoxContactInfo.Controls.Add(this.textBoxZipcode);
			this.groupBoxContactInfo.Controls.Add(this.textBoxCity);
			this.groupBoxContactInfo.Controls.Add(this.textBoxAddress);
			this.groupBoxContactInfo.Controls.Add(this.labelAge);
			this.groupBoxContactInfo.Controls.Add(this.labelZipcode);
			this.groupBoxContactInfo.Controls.Add(this.textBoxName);
			this.groupBoxContactInfo.Controls.Add(this.labelCity);
			this.groupBoxContactInfo.Controls.Add(this.labelNumber);
			this.groupBoxContactInfo.Controls.Add(this.labelAddress);
			this.groupBoxContactInfo.Controls.Add(this.labelName);
			this.groupBoxContactInfo.Location = new System.Drawing.Point(3, 27);
			this.groupBoxContactInfo.Name = "groupBoxContactInfo";
			this.groupBoxContactInfo.Size = new System.Drawing.Size(327, 229);
			this.groupBoxContactInfo.TabIndex = 3;
			this.groupBoxContactInfo.TabStop = false;
			this.groupBoxContactInfo.Text = "Contact Information";
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(114, 73);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(197, 20);
			this.textBoxConfirmPassword.TabIndex = 2;
			this.textBoxConfirmPassword.UseSystemPasswordChar = true;
			// 
			// labelConfirmPassword
			// 
			this.labelConfirmPassword.AutoSize = true;
			this.labelConfirmPassword.Location = new System.Drawing.Point(17, 76);
			this.labelConfirmPassword.Name = "labelConfirmPassword";
			this.labelConfirmPassword.Size = new System.Drawing.Size(91, 13);
			this.labelConfirmPassword.TabIndex = 5;
			this.labelConfirmPassword.Text = "Confirm Password";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(56, 49);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(53, 13);
			this.labelPassword.TabIndex = 4;
			this.labelPassword.Text = "Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(114, 46);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(197, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// numericAge
			// 
			this.numericAge.Location = new System.Drawing.Point(114, 203);
			this.numericAge.Name = "numericAge";
			this.numericAge.Size = new System.Drawing.Size(49, 20);
			this.numericAge.TabIndex = 7;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(114, 176);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(197, 20);
			this.textBoxNumber.TabIndex = 6;
			// 
			// textBoxZipcode
			// 
			this.textBoxZipcode.Location = new System.Drawing.Point(114, 150);
			this.textBoxZipcode.Name = "textBoxZipcode";
			this.textBoxZipcode.Size = new System.Drawing.Size(197, 20);
			this.textBoxZipcode.TabIndex = 5;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(114, 124);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(197, 20);
			this.textBoxCity.TabIndex = 4;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(114, 98);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(197, 20);
			this.textBoxAddress.TabIndex = 3;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(82, 207);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(26, 13);
			this.labelAge.TabIndex = 0;
			this.labelAge.Text = "Age";
			// 
			// labelZipcode
			// 
			this.labelZipcode.AutoSize = true;
			this.labelZipcode.Location = new System.Drawing.Point(63, 153);
			this.labelZipcode.Name = "labelZipcode";
			this.labelZipcode.Size = new System.Drawing.Size(46, 13);
			this.labelZipcode.TabIndex = 0;
			this.labelZipcode.Text = "Zipcode";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(114, 19);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(197, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(84, 127);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(24, 13);
			this.labelCity.TabIndex = 0;
			this.labelCity.Text = "City";
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Location = new System.Drawing.Point(30, 180);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(78, 13);
			this.labelNumber.TabIndex = 0;
			this.labelNumber.Text = "Phone Number";
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(63, 102);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(45, 13);
			this.labelAddress.TabIndex = 0;
			this.labelAddress.Text = "Address";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(73, 23);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			// 
			// FormLogin
			// 
			this.AcceptButton = this.LoginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 426);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "FormLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBoxBilling.ResumeLayout(false);
			this.groupBoxBilling.PerformLayout();
			this.groupBoxContactInfo.ResumeLayout(false);
			this.groupBoxContactInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label labelCreateAccount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.GroupBox groupBoxBilling;
		private System.Windows.Forms.ComboBox comboBoxMonth;
		private System.Windows.Forms.ComboBox comboBoxYear;
		private System.Windows.Forms.TextBox textBoxCC;
		private System.Windows.Forms.Label labelCSV;
		private System.Windows.Forms.Label labelExpiration;
		private System.Windows.Forms.Label labelCC;
		private System.Windows.Forms.GroupBox groupBoxContactInfo;
		private System.Windows.Forms.NumericUpDown numericAge;
		private System.Windows.Forms.TextBox textBoxZipcode;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.Label labelZipcode;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.Label labelConfirmPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxCSV;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.Label ErrorMessage;
	}
}

