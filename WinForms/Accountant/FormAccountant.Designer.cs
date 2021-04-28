
namespace CovidAirlines
{
	partial class FormAccountant
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
			this.listViewFlights = new System.Windows.Forms.ListView();
			this.columnHeaderFlightNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPassengers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCreditCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelCompanyHeader = new System.Windows.Forms.Label();
			this.labelTotalFlights = new System.Windows.Forms.Label();
			this.labelFlights = new System.Windows.Forms.Label();
			this.labelTotalBooked = new System.Windows.Forms.Label();
			this.labelBooked = new System.Windows.Forms.Label();
			this.labelTotalCapacity = new System.Windows.Forms.Label();
			this.labelCapacity = new System.Windows.Forms.Label();
			this.labelTotalPercent = new System.Windows.Forms.Label();
			this.labelPercent = new System.Windows.Forms.Label();
			this.labelTotalIncome = new System.Windows.Forms.Label();
			this.labelIncome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listViewFlights
			// 
			this.listViewFlights.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlightNum,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderPassengers,
            this.columnHeaderCapacity,
            this.columnHeaderPercent,
            this.columnHeaderPrice,
            this.columnHeaderCreditCount,
            this.columnHeaderIncome});
			this.listViewFlights.FullRowSelect = true;
			this.listViewFlights.HideSelection = false;
			this.listViewFlights.Location = new System.Drawing.Point(12, 12);
			this.listViewFlights.MultiSelect = false;
			this.listViewFlights.Name = "listViewFlights";
			this.listViewFlights.Size = new System.Drawing.Size(1160, 287);
			this.listViewFlights.TabIndex = 5;
			this.listViewFlights.UseCompatibleStateImageBehavior = false;
			this.listViewFlights.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderFlightNum
			// 
			this.columnHeaderFlightNum.Text = "Flight Number";
			this.columnHeaderFlightNum.Width = 81;
			// 
			// columnHeaderOrigin
			// 
			this.columnHeaderOrigin.Text = "Origin";
			this.columnHeaderOrigin.Width = 110;
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 110;
			// 
			// columnHeaderDepart
			// 
			this.columnHeaderDepart.Text = "Departure Time";
			this.columnHeaderDepart.Width = 125;
			// 
			// columnHeaderArrive
			// 
			this.columnHeaderArrive.Text = "Arrival Time";
			this.columnHeaderArrive.Width = 125;
			// 
			// columnHeaderPrice
			// 
			this.columnHeaderPrice.Text = "Ticket Price";
			this.columnHeaderPrice.Width = 70;
			// 
			// columnHeaderIncome
			// 
			this.columnHeaderIncome.Text = "Total Income";
			this.columnHeaderIncome.Width = 90;
			// 
			// columnHeaderPassengers
			// 
			this.columnHeaderPassengers.Text = "Passengers Booked";
			this.columnHeaderPassengers.Width = 109;
			// 
			// columnHeaderCapacity
			// 
			this.columnHeaderCapacity.Text = "Passenger Capacity";
			this.columnHeaderCapacity.Width = 109;
			// 
			// columnHeaderPercent
			// 
			this.columnHeaderPercent.Text = "Percent Capacity";
			this.columnHeaderPercent.Width = 97;
			// 
			// columnHeaderCreditCount
			// 
			this.columnHeaderCreditCount.Text = "Paid With Credit";
			this.columnHeaderCreditCount.Width = 90;
			// 
			// labelCompanyHeader
			// 
			this.labelCompanyHeader.AutoSize = true;
			this.labelCompanyHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCompanyHeader.Location = new System.Drawing.Point(12, 311);
			this.labelCompanyHeader.Name = "labelCompanyHeader";
			this.labelCompanyHeader.Size = new System.Drawing.Size(167, 20);
			this.labelCompanyHeader.TabIndex = 7;
			this.labelCompanyHeader.Text = "Company Summary:";
			// 
			// labelTotalFlights
			// 
			this.labelTotalFlights.AutoSize = true;
			this.labelTotalFlights.Location = new System.Drawing.Point(13, 381);
			this.labelTotalFlights.Name = "labelTotalFlights";
			this.labelTotalFlights.Size = new System.Drawing.Size(67, 13);
			this.labelTotalFlights.TabIndex = 8;
			this.labelTotalFlights.Text = "Total Flights:";
			// 
			// labelFlights
			// 
			this.labelFlights.AutoSize = true;
			this.labelFlights.Location = new System.Drawing.Point(93, 381);
			this.labelFlights.Name = "labelFlights";
			this.labelFlights.Size = new System.Drawing.Size(28, 13);
			this.labelFlights.TabIndex = 8;
			this.labelFlights.Text = "XXX";
			this.labelFlights.Click += new System.EventHandler(this.labelFlights_Click);
			// 
			// labelTotalBooked
			// 
			this.labelTotalBooked.AutoSize = true;
			this.labelTotalBooked.Location = new System.Drawing.Point(13, 350);
			this.labelTotalBooked.Name = "labelTotalBooked";
			this.labelTotalBooked.Size = new System.Drawing.Size(74, 13);
			this.labelTotalBooked.TabIndex = 8;
			this.labelTotalBooked.Text = "Total Booked:";
			// 
			// labelBooked
			// 
			this.labelBooked.AutoSize = true;
			this.labelBooked.Location = new System.Drawing.Point(93, 350);
			this.labelBooked.Name = "labelBooked";
			this.labelBooked.Size = new System.Drawing.Size(28, 13);
			this.labelBooked.TabIndex = 8;
			this.labelBooked.Text = "XXX";
			this.labelBooked.Click += new System.EventHandler(this.labelFlights_Click);
			// 
			// labelTotalCapacity
			// 
			this.labelTotalCapacity.AutoSize = true;
			this.labelTotalCapacity.Location = new System.Drawing.Point(150, 350);
			this.labelTotalCapacity.Name = "labelTotalCapacity";
			this.labelTotalCapacity.Size = new System.Drawing.Size(78, 13);
			this.labelTotalCapacity.TabIndex = 8;
			this.labelTotalCapacity.Text = "Total Capacity:";
			// 
			// labelCapacity
			// 
			this.labelCapacity.AutoSize = true;
			this.labelCapacity.Location = new System.Drawing.Point(234, 350);
			this.labelCapacity.Name = "labelCapacity";
			this.labelCapacity.Size = new System.Drawing.Size(28, 13);
			this.labelCapacity.TabIndex = 8;
			this.labelCapacity.Text = "XXX";
			this.labelCapacity.Click += new System.EventHandler(this.labelFlights_Click);
			// 
			// labelTotalPercent
			// 
			this.labelTotalPercent.AutoSize = true;
			this.labelTotalPercent.Location = new System.Drawing.Point(308, 350);
			this.labelTotalPercent.Name = "labelTotalPercent";
			this.labelTotalPercent.Size = new System.Drawing.Size(91, 13);
			this.labelTotalPercent.TabIndex = 8;
			this.labelTotalPercent.Text = "Percent Capacity:";
			// 
			// labelPercent
			// 
			this.labelPercent.AutoSize = true;
			this.labelPercent.Location = new System.Drawing.Point(405, 350);
			this.labelPercent.Name = "labelPercent";
			this.labelPercent.Size = new System.Drawing.Size(46, 13);
			this.labelPercent.TabIndex = 8;
			this.labelPercent.Text = "XX.YY%";
			this.labelPercent.Click += new System.EventHandler(this.labelFlights_Click);
			// 
			// labelTotalIncome
			// 
			this.labelTotalIncome.AutoSize = true;
			this.labelTotalIncome.Location = new System.Drawing.Point(150, 381);
			this.labelTotalIncome.Name = "labelTotalIncome";
			this.labelTotalIncome.Size = new System.Drawing.Size(72, 13);
			this.labelTotalIncome.TabIndex = 8;
			this.labelTotalIncome.Text = "Total Income:";
			// 
			// labelIncome
			// 
			this.labelIncome.AutoSize = true;
			this.labelIncome.Location = new System.Drawing.Point(234, 381);
			this.labelIncome.Name = "labelIncome";
			this.labelIncome.Size = new System.Drawing.Size(51, 13);
			this.labelIncome.TabIndex = 8;
			this.labelIncome.Text = "$XXX.YY";
			this.labelIncome.Click += new System.EventHandler(this.labelFlights_Click);
			// 
			// FormAccountant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.labelPercent);
			this.Controls.Add(this.labelCapacity);
			this.Controls.Add(this.labelIncome);
			this.Controls.Add(this.labelBooked);
			this.Controls.Add(this.labelFlights);
			this.Controls.Add(this.labelTotalPercent);
			this.Controls.Add(this.labelTotalCapacity);
			this.Controls.Add(this.labelTotalIncome);
			this.Controls.Add(this.labelTotalBooked);
			this.Controls.Add(this.labelTotalFlights);
			this.Controls.Add(this.labelCompanyHeader);
			this.Controls.Add(this.listViewFlights);
			this.Name = "FormAccountant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu - Accounting Manager";
			this.Load += new System.EventHandler(this.FormAccountant_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewFlights;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightNum;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.ColumnHeader columnHeaderIncome;
		private System.Windows.Forms.ColumnHeader columnHeaderPassengers;
		private System.Windows.Forms.ColumnHeader columnHeaderCapacity;
		private System.Windows.Forms.ColumnHeader columnHeaderPercent;
		private System.Windows.Forms.ColumnHeader columnHeaderCreditCount;
		private System.Windows.Forms.Label labelCompanyHeader;
		private System.Windows.Forms.Label labelTotalFlights;
		private System.Windows.Forms.Label labelFlights;
		private System.Windows.Forms.Label labelTotalBooked;
		private System.Windows.Forms.Label labelBooked;
		private System.Windows.Forms.Label labelTotalCapacity;
		private System.Windows.Forms.Label labelCapacity;
		private System.Windows.Forms.Label labelTotalPercent;
		private System.Windows.Forms.Label labelPercent;
		private System.Windows.Forms.Label labelTotalIncome;
		private System.Windows.Forms.Label labelIncome;
	}
}