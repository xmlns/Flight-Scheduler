
namespace CovidAirlines
{
	partial class FormFlightManager
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
			this.columnHeaderFlightID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderS1Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderS2Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.columnHeaderS1Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderS2Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listViewFlights
			// 
			this.listViewFlights.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlightID,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderStop1,
            this.columnHeaderS1Arrive,
            this.columnHeaderS1Depart,
            this.columnHeaderStop2,
            this.columnHeaderS2Arrive,
            this.columnHeaderS2Depart,
            this.columnHeaderTickets});
			this.listViewFlights.FullRowSelect = true;
			this.listViewFlights.HideSelection = false;
			this.listViewFlights.Location = new System.Drawing.Point(12, 12);
			this.listViewFlights.MultiSelect = false;
			this.listViewFlights.Name = "listViewFlights";
			this.listViewFlights.Size = new System.Drawing.Size(1160, 287);
			this.listViewFlights.TabIndex = 6;
			this.listViewFlights.UseCompatibleStateImageBehavior = false;
			this.listViewFlights.View = System.Windows.Forms.View.Details;
			this.listViewFlights.SelectedIndexChanged += new System.EventHandler(this.listViewSchedule_SelectedIndexChanged);
			// 
			// columnHeaderFlightID
			// 
			this.columnHeaderFlightID.Text = "Flight Number";
			this.columnHeaderFlightID.Width = 77;
			// 
			// columnHeaderOrigin
			// 
			this.columnHeaderOrigin.Text = "Origin";
			this.columnHeaderOrigin.Width = 70;
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 70;
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
			// columnHeaderStop1
			// 
			this.columnHeaderStop1.Text = "Stop 1";
			// 
			// columnHeaderS1Depart
			// 
			this.columnHeaderS1Depart.Text = "Stop 1 Departure Time";
			this.columnHeaderS1Depart.Width = 125;
			// 
			// columnHeaderStop2
			// 
			this.columnHeaderStop2.Text = "Stop 2";
			// 
			// columnHeaderS2Depart
			// 
			this.columnHeaderS2Depart.Text = "Stop 2 Departure Time";
			this.columnHeaderS2Depart.Width = 119;
			// 
			// columnHeaderTickets
			// 
			this.columnHeaderTickets.Text = "Tickets Sold";
			this.columnHeaderTickets.Width = 75;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Enabled = false;
			this.buttonGenerate.Location = new System.Drawing.Point(13, 306);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(148, 23);
			this.buttonGenerate.TabIndex = 7;
			this.buttonGenerate.Text = "Generate Selected Manifest";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// columnHeaderS1Arrive
			// 
			this.columnHeaderS1Arrive.Text = "Stop 1 Arrival Time";
			this.columnHeaderS1Arrive.Width = 125;
			// 
			// columnHeaderS2Arrive
			// 
			this.columnHeaderS2Arrive.Text = "Stop 2 Arrival Time";
			this.columnHeaderS2Arrive.Width = 125;
			// 
			// FormFlightManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.buttonGenerate);
			this.Controls.Add(this.listViewFlights);
			this.Name = "FormFlightManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu - Flight Manager";
			this.Load += new System.EventHandler(this.FormFlightManager_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewFlights;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderS1Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderS2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderTickets;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.ColumnHeader columnHeaderS1Arrive;
		private System.Windows.Forms.ColumnHeader columnHeaderS2Arrive;
	}
}