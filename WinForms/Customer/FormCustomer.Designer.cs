
namespace CovidAirlines
{
	partial class FormCustomer
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
			this.tabControlMenu = new System.Windows.Forms.TabControl();
			this.tabPageBook = new System.Windows.Forms.TabPage();
			this.labelSearchResponse = new System.Windows.Forms.Label();
			this.radioButtonRoundTrip = new System.Windows.Forms.RadioButton();
			this.radioButtonOneway = new System.Windows.Forms.RadioButton();
			this.buttonSignout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelArrow1 = new System.Windows.Forms.Label();
			this.labelArrow2 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
			this.labelDates = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
			this.labelDestination = new System.Windows.Forms.Label();
			this.labelOrigin = new System.Windows.Forms.Label();
			this.comboBoxDestination = new System.Windows.Forms.ComboBox();
			this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
			this.tabPageHistory = new System.Windows.Forms.TabPage();
			this.buttonOneWeek = new System.Windows.Forms.Button();
			this.buttonBoardingPass = new System.Windows.Forms.Button();
			this.buttonCancelFlight = new System.Windows.Forms.Button();
			this.textBoxSelected = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.listViewHistory = new System.Windows.Forms.ListView();
			this.columnHeaderFlightID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSDepart1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderS2Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.tabPageAccount = new System.Windows.Forms.TabPage();
			this.labelResult = new System.Windows.Forms.Label();
			this.labelUpdateAccount = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.groupBoxBilling = new System.Windows.Forms.GroupBox();
			this.comboBoxMonth = new System.Windows.Forms.ComboBox();
			this.comboBoxYear = new System.Windows.Forms.ComboBox();
			this.textBoxCSV = new System.Windows.Forms.TextBox();
			this.textBoxCC = new System.Windows.Forms.TextBox();
			this.labelCSV = new System.Windows.Forms.Label();
			this.labelExpiration = new System.Windows.Forms.Label();
			this.labelCC = new System.Windows.Forms.Label();
			this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
			this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
			this.labelCurrentPassword = new System.Windows.Forms.Label();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.labelConfirmPassword = new System.Windows.Forms.Label();
			this.labelNewPassword = new System.Windows.Forms.Label();
			this.textBoxNewPassword = new System.Windows.Forms.TextBox();
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
			this.tabControlMenu.SuspendLayout();
			this.tabPageBook.SuspendLayout();
			this.tabPageHistory.SuspendLayout();
			this.tabPageAccount.SuspendLayout();
			this.groupBoxBilling.SuspendLayout();
			this.groupBoxContactInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlMenu
			// 
			this.tabControlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMenu.Controls.Add(this.tabPageBook);
			this.tabControlMenu.Controls.Add(this.tabPageHistory);
			this.tabControlMenu.Controls.Add(this.tabPageAccount);
			this.tabControlMenu.Location = new System.Drawing.Point(12, 12);
			this.tabControlMenu.Name = "tabControlMenu";
			this.tabControlMenu.SelectedIndex = 0;
			this.tabControlMenu.Size = new System.Drawing.Size(1169, 607);
			this.tabControlMenu.TabIndex = 0;
			// 
			// tabPageBook
			// 
			this.tabPageBook.Controls.Add(this.labelSearchResponse);
			this.tabPageBook.Controls.Add(this.radioButtonRoundTrip);
			this.tabPageBook.Controls.Add(this.radioButtonOneway);
			this.tabPageBook.Controls.Add(this.buttonSignout);
			this.tabPageBook.Controls.Add(this.label1);
			this.tabPageBook.Controls.Add(this.labelArrow1);
			this.tabPageBook.Controls.Add(this.labelArrow2);
			this.tabPageBook.Controls.Add(this.buttonSearch);
			this.tabPageBook.Controls.Add(this.dateTimePickerReturn);
			this.tabPageBook.Controls.Add(this.labelDates);
			this.tabPageBook.Controls.Add(this.label3);
			this.tabPageBook.Controls.Add(this.label2);
			this.tabPageBook.Controls.Add(this.dateTimePickerDepart);
			this.tabPageBook.Controls.Add(this.labelDestination);
			this.tabPageBook.Controls.Add(this.labelOrigin);
			this.tabPageBook.Controls.Add(this.comboBoxDestination);
			this.tabPageBook.Controls.Add(this.comboBoxOrigin);
			this.tabPageBook.Location = new System.Drawing.Point(4, 22);
			this.tabPageBook.Name = "tabPageBook";
			this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBook.Size = new System.Drawing.Size(1161, 581);
			this.tabPageBook.TabIndex = 0;
			this.tabPageBook.Text = "Book Flight";
			this.tabPageBook.UseVisualStyleBackColor = true;
			this.tabPageBook.Click += new System.EventHandler(this.tabPageBook_Click);
			// 
			// labelSearchResponse
			// 
			this.labelSearchResponse.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSearchResponse.AutoSize = true;
			this.labelSearchResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSearchResponse.Location = new System.Drawing.Point(343, 373);
			this.labelSearchResponse.Name = "labelSearchResponse";
			this.labelSearchResponse.Size = new System.Drawing.Size(176, 13);
			this.labelSearchResponse.TabIndex = 14;
			this.labelSearchResponse.Text = "*Search Response Goes Here";
			this.labelSearchResponse.Visible = false;
			// 
			// radioButtonRoundTrip
			// 
			this.radioButtonRoundTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonRoundTrip.AutoSize = true;
			this.radioButtonRoundTrip.Location = new System.Drawing.Point(436, 243);
			this.radioButtonRoundTrip.Name = "radioButtonRoundTrip";
			this.radioButtonRoundTrip.Size = new System.Drawing.Size(74, 17);
			this.radioButtonRoundTrip.TabIndex = 3;
			this.radioButtonRoundTrip.Text = "Round-trip";
			this.radioButtonRoundTrip.UseVisualStyleBackColor = true;
			this.radioButtonRoundTrip.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButtonOneway
			// 
			this.radioButtonOneway.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radioButtonOneway.AutoSize = true;
			this.radioButtonOneway.Checked = true;
			this.radioButtonOneway.Location = new System.Drawing.Point(343, 243);
			this.radioButtonOneway.Name = "radioButtonOneway";
			this.radioButtonOneway.Size = new System.Drawing.Size(67, 17);
			this.radioButtonOneway.TabIndex = 2;
			this.radioButtonOneway.TabStop = true;
			this.radioButtonOneway.Text = "One-way";
			this.radioButtonOneway.UseVisualStyleBackColor = true;
			this.radioButtonOneway.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// buttonSignout
			// 
			this.buttonSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSignout.Location = new System.Drawing.Point(1080, 6);
			this.buttonSignout.Name = "buttonSignout";
			this.buttonSignout.Size = new System.Drawing.Size(75, 23);
			this.buttonSignout.TabIndex = 13;
			this.buttonSignout.Text = "Sign Out";
			this.buttonSignout.UseVisualStyleBackColor = true;
			this.buttonSignout.Click += new System.EventHandler(this.buttonSignout_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(448, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Welcome to Air 3550!";
			// 
			// labelArrow1
			// 
			this.labelArrow1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelArrow1.AutoSize = true;
			this.labelArrow1.Location = new System.Drawing.Point(552, 206);
			this.labelArrow1.Name = "labelArrow1";
			this.labelArrow1.Size = new System.Drawing.Size(22, 13);
			this.labelArrow1.TabIndex = 11;
			this.labelArrow1.Text = "--->";
			// 
			// labelArrow2
			// 
			this.labelArrow2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelArrow2.AutoSize = true;
			this.labelArrow2.Location = new System.Drawing.Point(552, 293);
			this.labelArrow2.Name = "labelArrow2";
			this.labelArrow2.Size = new System.Drawing.Size(22, 13);
			this.labelArrow2.TabIndex = 11;
			this.labelArrow2.Text = "--->";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSearch.AutoSize = true;
			this.buttonSearch.Location = new System.Drawing.Point(518, 332);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(84, 23);
			this.buttonSearch.TabIndex = 6;
			this.buttonSearch.Text = "Search Flights";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dateTimePickerReturn
			// 
			this.dateTimePickerReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePickerReturn.Enabled = false;
			this.dateTimePickerReturn.Location = new System.Drawing.Point(577, 289);
			this.dateTimePickerReturn.Name = "dateTimePickerReturn";
			this.dateTimePickerReturn.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerReturn.TabIndex = 5;
			this.dateTimePickerReturn.ValueChanged += new System.EventHandler(this.dateTimePickerReturn_ValueChanged);
			// 
			// labelDates
			// 
			this.labelDates.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelDates.AutoSize = true;
			this.labelDates.Location = new System.Drawing.Point(343, 273);
			this.labelDates.Name = "labelDates";
			this.labelDates.Size = new System.Drawing.Size(41, 13);
			this.labelDates.TabIndex = 8;
			this.labelDates.Text = "Date(s)";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(286, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(286, 412);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 6;
			// 
			// dateTimePickerDepart
			// 
			this.dateTimePickerDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePickerDepart.Location = new System.Drawing.Point(343, 289);
			this.dateTimePickerDepart.Name = "dateTimePickerDepart";
			this.dateTimePickerDepart.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerDepart.TabIndex = 4;
			this.dateTimePickerDepart.Value = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
			// 
			// labelDestination
			// 
			this.labelDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelDestination.AutoSize = true;
			this.labelDestination.Location = new System.Drawing.Point(577, 187);
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.Size = new System.Drawing.Size(60, 13);
			this.labelDestination.TabIndex = 3;
			this.labelDestination.Text = "Destination";
			// 
			// labelOrigin
			// 
			this.labelOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelOrigin.AutoSize = true;
			this.labelOrigin.Location = new System.Drawing.Point(343, 187);
			this.labelOrigin.Name = "labelOrigin";
			this.labelOrigin.Size = new System.Drawing.Size(34, 13);
			this.labelOrigin.TabIndex = 2;
			this.labelOrigin.Text = "Origin";
			// 
			// comboBoxDestination
			// 
			this.comboBoxDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDestination.FormattingEnabled = true;
			this.comboBoxDestination.Location = new System.Drawing.Point(577, 203);
			this.comboBoxDestination.Name = "comboBoxDestination";
			this.comboBoxDestination.Size = new System.Drawing.Size(200, 21);
			this.comboBoxDestination.Sorted = true;
			this.comboBoxDestination.TabIndex = 1;
			// 
			// comboBoxOrigin
			// 
			this.comboBoxOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBoxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOrigin.FormattingEnabled = true;
			this.comboBoxOrigin.Location = new System.Drawing.Point(343, 203);
			this.comboBoxOrigin.Name = "comboBoxOrigin";
			this.comboBoxOrigin.Size = new System.Drawing.Size(200, 21);
			this.comboBoxOrigin.Sorted = true;
			this.comboBoxOrigin.TabIndex = 0;
			this.comboBoxOrigin.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigin_SelectedIndexChanged);
			// 
			// tabPageHistory
			// 
			this.tabPageHistory.Controls.Add(this.buttonOneWeek);
			this.tabPageHistory.Controls.Add(this.buttonBoardingPass);
			this.tabPageHistory.Controls.Add(this.buttonCancelFlight);
			this.tabPageHistory.Controls.Add(this.textBoxSelected);
			this.tabPageHistory.Controls.Add(this.button2);
			this.tabPageHistory.Controls.Add(this.listViewHistory);
			this.tabPageHistory.Controls.Add(this.button1);
			this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
			this.tabPageHistory.Name = "tabPageHistory";
			this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHistory.Size = new System.Drawing.Size(1161, 581);
			this.tabPageHistory.TabIndex = 1;
			this.tabPageHistory.Text = "Flight History";
			this.tabPageHistory.UseVisualStyleBackColor = true;
			// 
			// buttonOneWeek
			// 
			this.buttonOneWeek.Location = new System.Drawing.Point(1054, 519);
			this.buttonOneWeek.Name = "buttonOneWeek";
			this.buttonOneWeek.Size = new System.Drawing.Size(101, 23);
			this.buttonOneWeek.TabIndex = 9;
			this.buttonOneWeek.Text = "Add one week";
			this.buttonOneWeek.UseVisualStyleBackColor = true;
			this.buttonOneWeek.Click += new System.EventHandler(this.buttonOneWeek_Click);
			// 
			// buttonBoardingPass
			// 
			this.buttonBoardingPass.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonBoardingPass.Enabled = false;
			this.buttonBoardingPass.Location = new System.Drawing.Point(176, 299);
			this.buttonBoardingPass.Name = "buttonBoardingPass";
			this.buttonBoardingPass.Size = new System.Drawing.Size(110, 23);
			this.buttonBoardingPass.TabIndex = 7;
			this.buttonBoardingPass.Text = "Print Boarding Pass";
			this.buttonBoardingPass.UseVisualStyleBackColor = true;
			this.buttonBoardingPass.Click += new System.EventHandler(this.buttonBoardingPass_Click);
			// 
			// buttonCancelFlight
			// 
			this.buttonCancelFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCancelFlight.Enabled = false;
			this.buttonCancelFlight.Location = new System.Drawing.Point(6, 299);
			this.buttonCancelFlight.Name = "buttonCancelFlight";
			this.buttonCancelFlight.Size = new System.Drawing.Size(121, 23);
			this.buttonCancelFlight.TabIndex = 6;
			this.buttonCancelFlight.Text = "Cancel Selected Flight";
			this.buttonCancelFlight.UseVisualStyleBackColor = true;
			// 
			// textBoxSelected
			// 
			this.textBoxSelected.Location = new System.Drawing.Point(661, 554);
			this.textBoxSelected.Name = "textBoxSelected";
			this.textBoxSelected.Size = new System.Drawing.Size(387, 20);
			this.textBoxSelected.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(490, 551);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Get Selected";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listViewHistory
			// 
			this.listViewHistory.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlightID,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderStop1,
            this.columnHeaderSDepart1,
            this.columnHeaderStop2,
            this.columnHeaderS2Depart,
            this.columnHeaderStatus,
            this.columnHeaderPrice});
			this.listViewHistory.FullRowSelect = true;
			this.listViewHistory.HideSelection = false;
			this.listViewHistory.Location = new System.Drawing.Point(6, 6);
			this.listViewHistory.MultiSelect = false;
			this.listViewHistory.Name = "listViewHistory";
			this.listViewHistory.Size = new System.Drawing.Size(1149, 287);
			this.listViewHistory.TabIndex = 3;
			this.listViewHistory.UseCompatibleStateImageBehavior = false;
			this.listViewHistory.View = System.Windows.Forms.View.Details;
			this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
			// 
			// columnHeaderFlightID
			// 
			this.columnHeaderFlightID.Text = "FlightID";
			// 
			// columnHeaderOrigin
			// 
			this.columnHeaderOrigin.Text = "Origin";
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 72;
			// 
			// columnHeaderDepart
			// 
			this.columnHeaderDepart.Text = "Departure Time";
			this.columnHeaderDepart.Width = 106;
			// 
			// columnHeaderArrive
			// 
			this.columnHeaderArrive.Text = "Arrival Time";
			this.columnHeaderArrive.Width = 85;
			// 
			// columnHeaderStop1
			// 
			this.columnHeaderStop1.Text = "Stop 1";
			this.columnHeaderStop1.Width = 89;
			// 
			// columnHeaderSDepart1
			// 
			this.columnHeaderSDepart1.Text = "Stop 1 Departure Time";
			this.columnHeaderSDepart1.Width = 124;
			// 
			// columnHeaderStop2
			// 
			this.columnHeaderStop2.Text = "Stop 2";
			// 
			// columnHeaderS2Depart
			// 
			this.columnHeaderS2Depart.Text = "Stop 2 Departure Time";
			this.columnHeaderS2Depart.Width = 89;
			// 
			// columnHeaderStatus
			// 
			this.columnHeaderStatus.Text = "Status";
			// 
			// columnHeaderPrice
			// 
			this.columnHeaderPrice.Text = "Ticket Price";
			this.columnHeaderPrice.Width = 77;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1054, 552);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add Dummy Entry";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPageAccount
			// 
			this.tabPageAccount.Controls.Add(this.labelResult);
			this.tabPageAccount.Controls.Add(this.labelUpdateAccount);
			this.tabPageAccount.Controls.Add(this.buttonUpdate);
			this.tabPageAccount.Controls.Add(this.groupBoxBilling);
			this.tabPageAccount.Controls.Add(this.groupBoxContactInfo);
			this.tabPageAccount.Location = new System.Drawing.Point(4, 22);
			this.tabPageAccount.Name = "tabPageAccount";
			this.tabPageAccount.Size = new System.Drawing.Size(1161, 581);
			this.tabPageAccount.TabIndex = 2;
			this.tabPageAccount.Text = "Account Information";
			this.tabPageAccount.UseVisualStyleBackColor = true;
			// 
			// labelResult
			// 
			this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResult.Location = new System.Drawing.Point(263, 418);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(269, 13);
			this.labelResult.TabIndex = 15;
			this.labelResult.Text = "Create Account Confirm/Reject Message Here";
			this.labelResult.Visible = false;
			// 
			// labelUpdateAccount
			// 
			this.labelUpdateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelUpdateAccount.AutoSize = true;
			this.labelUpdateAccount.Location = new System.Drawing.Point(503, 95);
			this.labelUpdateAccount.Name = "labelUpdateAccount";
			this.labelUpdateAccount.Size = new System.Drawing.Size(140, 13);
			this.labelUpdateAccount.TabIndex = 14;
			this.labelUpdateAccount.Text = "Update Account Information";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonUpdate.Location = new System.Drawing.Point(263, 387);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(608, 23);
			this.buttonUpdate.TabIndex = 2;
			this.buttonUpdate.Text = "Update Account";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			// 
			// groupBoxBilling
			// 
			this.groupBoxBilling.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBoxBilling.Controls.Add(this.comboBoxMonth);
			this.groupBoxBilling.Controls.Add(this.comboBoxYear);
			this.groupBoxBilling.Controls.Add(this.textBoxCSV);
			this.groupBoxBilling.Controls.Add(this.textBoxCC);
			this.groupBoxBilling.Controls.Add(this.labelCSV);
			this.groupBoxBilling.Controls.Add(this.labelExpiration);
			this.groupBoxBilling.Controls.Add(this.labelCC);
			this.groupBoxBilling.Location = new System.Drawing.Point(263, 277);
			this.groupBoxBilling.Name = "groupBoxBilling";
			this.groupBoxBilling.Size = new System.Drawing.Size(608, 104);
			this.groupBoxBilling.TabIndex = 1;
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
			this.groupBoxContactInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBoxContactInfo.Controls.Add(this.textBoxCurrentPassword);
			this.groupBoxContactInfo.Controls.Add(this.labelCurrentPassword);
			this.groupBoxContactInfo.Controls.Add(this.textBoxConfirmPassword);
			this.groupBoxContactInfo.Controls.Add(this.labelConfirmPassword);
			this.groupBoxContactInfo.Controls.Add(this.labelNewPassword);
			this.groupBoxContactInfo.Controls.Add(this.textBoxNewPassword);
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
			this.groupBoxContactInfo.Location = new System.Drawing.Point(263, 111);
			this.groupBoxContactInfo.Name = "groupBoxContactInfo";
			this.groupBoxContactInfo.Size = new System.Drawing.Size(608, 160);
			this.groupBoxContactInfo.TabIndex = 0;
			this.groupBoxContactInfo.TabStop = false;
			this.groupBoxContactInfo.Text = "Contact Information";
			// 
			// textBoxCurrentPassword
			// 
			this.textBoxCurrentPassword.Location = new System.Drawing.Point(113, 47);
			this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
			this.textBoxCurrentPassword.Size = new System.Drawing.Size(198, 20);
			this.textBoxCurrentPassword.TabIndex = 1;
			// 
			// labelCurrentPassword
			// 
			this.labelCurrentPassword.AutoSize = true;
			this.labelCurrentPassword.Location = new System.Drawing.Point(18, 50);
			this.labelCurrentPassword.Name = "labelCurrentPassword";
			this.labelCurrentPassword.Size = new System.Drawing.Size(90, 13);
			this.labelCurrentPassword.TabIndex = 7;
			this.labelCurrentPassword.Text = "Current Password";
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(113, 101);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(197, 20);
			this.textBoxConfirmPassword.TabIndex = 3;
			this.textBoxConfirmPassword.UseSystemPasswordChar = true;
			// 
			// labelConfirmPassword
			// 
			this.labelConfirmPassword.AutoSize = true;
			this.labelConfirmPassword.Location = new System.Drawing.Point(16, 104);
			this.labelConfirmPassword.Name = "labelConfirmPassword";
			this.labelConfirmPassword.Size = new System.Drawing.Size(91, 13);
			this.labelConfirmPassword.TabIndex = 5;
			this.labelConfirmPassword.Text = "Confirm Password";
			// 
			// labelNewPassword
			// 
			this.labelNewPassword.AutoSize = true;
			this.labelNewPassword.Location = new System.Drawing.Point(30, 77);
			this.labelNewPassword.Name = "labelNewPassword";
			this.labelNewPassword.Size = new System.Drawing.Size(78, 13);
			this.labelNewPassword.TabIndex = 4;
			this.labelNewPassword.Text = "New Password";
			// 
			// textBoxNewPassword
			// 
			this.textBoxNewPassword.Location = new System.Drawing.Point(113, 74);
			this.textBoxNewPassword.Name = "textBoxNewPassword";
			this.textBoxNewPassword.Size = new System.Drawing.Size(197, 20);
			this.textBoxNewPassword.TabIndex = 2;
			this.textBoxNewPassword.UseSystemPasswordChar = true;
			// 
			// numericAge
			// 
			this.numericAge.Location = new System.Drawing.Point(396, 127);
			this.numericAge.Name = "numericAge";
			this.numericAge.Size = new System.Drawing.Size(49, 20);
			this.numericAge.TabIndex = 8;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(396, 101);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(197, 20);
			this.textBoxNumber.TabIndex = 7;
			// 
			// textBoxZipcode
			// 
			this.textBoxZipcode.Location = new System.Drawing.Point(396, 74);
			this.textBoxZipcode.Name = "textBoxZipcode";
			this.textBoxZipcode.Size = new System.Drawing.Size(197, 20);
			this.textBoxZipcode.TabIndex = 6;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(396, 47);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(197, 20);
			this.textBoxCity.TabIndex = 5;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(396, 19);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(197, 20);
			this.textBoxAddress.TabIndex = 4;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(364, 131);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(26, 13);
			this.labelAge.TabIndex = 0;
			this.labelAge.Text = "Age";
			// 
			// labelZipcode
			// 
			this.labelZipcode.AutoSize = true;
			this.labelZipcode.Location = new System.Drawing.Point(345, 77);
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
			this.labelCity.Location = new System.Drawing.Point(366, 50);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(24, 13);
			this.labelCity.TabIndex = 0;
			this.labelCity.Text = "City";
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Location = new System.Drawing.Point(312, 104);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(78, 13);
			this.labelNumber.TabIndex = 0;
			this.labelNumber.Text = "Phone Number";
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(345, 23);
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
			// FormCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1193, 631);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlMenu);
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCustomer";
			this.ShowIcon = false;
			this.Text = "Main Menu - Customer";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tabControlMenu.ResumeLayout(false);
			this.tabPageBook.ResumeLayout(false);
			this.tabPageBook.PerformLayout();
			this.tabPageHistory.ResumeLayout(false);
			this.tabPageHistory.PerformLayout();
			this.tabPageAccount.ResumeLayout(false);
			this.tabPageAccount.PerformLayout();
			this.groupBoxBilling.ResumeLayout(false);
			this.groupBoxBilling.PerformLayout();
			this.groupBoxContactInfo.ResumeLayout(false);
			this.groupBoxContactInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMenu;
		private System.Windows.Forms.TabPage tabPageBook;
		private System.Windows.Forms.TabPage tabPageHistory;
		private System.Windows.Forms.TabPage tabPageAccount;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label labelUpdateAccount;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.GroupBox groupBoxBilling;
		private System.Windows.Forms.ComboBox comboBoxMonth;
		private System.Windows.Forms.ComboBox comboBoxYear;
		private System.Windows.Forms.TextBox textBoxCSV;
		private System.Windows.Forms.TextBox textBoxCC;
		private System.Windows.Forms.Label labelCSV;
		private System.Windows.Forms.Label labelExpiration;
		private System.Windows.Forms.Label labelCC;
		private System.Windows.Forms.GroupBox groupBoxContactInfo;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.Label labelConfirmPassword;
		private System.Windows.Forms.Label labelNewPassword;
		private System.Windows.Forms.TextBox textBoxNewPassword;
		private System.Windows.Forms.NumericUpDown numericAge;
		private System.Windows.Forms.TextBox textBoxNumber;
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
		private System.Windows.Forms.Label labelArrow2;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
		private System.Windows.Forms.Label labelDates;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
		private System.Windows.Forms.Label labelDestination;
		private System.Windows.Forms.Label labelOrigin;
		private System.Windows.Forms.ComboBox comboBoxDestination;
		private System.Windows.Forms.ComboBox comboBoxOrigin;
		private System.Windows.Forms.Label labelArrow1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCurrentPassword;
		private System.Windows.Forms.TextBox textBoxCurrentPassword;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listViewHistory;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderSDepart1;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.RadioButton radioButtonOneway;
		private System.Windows.Forms.Button buttonSignout;
		private System.Windows.Forms.RadioButton radioButtonRoundTrip;
		private System.Windows.Forms.TextBox textBoxSelected;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonBoardingPass;
		private System.Windows.Forms.Button buttonCancelFlight;
		private System.Windows.Forms.Button buttonOneWeek;
		private System.Windows.Forms.Label labelSearchResponse;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderS2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStatus;
	}
}