
namespace CovidAirlines
{
	partial class FormFlightManifest
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
			this.listViewPassengers = new System.Windows.Forms.ListView();
			this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelFlightNum = new System.Windows.Forms.Label();
			this.labelFlightNumHere = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelPassenger = new System.Windows.Forms.Label();
			this.labelPassengerHere = new System.Windows.Forms.Label();
			this.labelDateHere = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listViewPassengers
			// 
			this.listViewPassengers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName});
			this.listViewPassengers.FullRowSelect = true;
			this.listViewPassengers.HideSelection = false;
			this.listViewPassengers.Location = new System.Drawing.Point(12, 94);
			this.listViewPassengers.MultiSelect = false;
			this.listViewPassengers.Name = "listViewPassengers";
			this.listViewPassengers.Size = new System.Drawing.Size(243, 344);
			this.listViewPassengers.TabIndex = 0;
			this.listViewPassengers.UseCompatibleStateImageBehavior = false;
			this.listViewPassengers.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderID
			// 
			this.columnHeaderID.Text = "User ID";
			this.columnHeaderID.Width = 54;
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Full Name";
			this.columnHeaderName.Width = 180;
			// 
			// labelFlightNum
			// 
			this.labelFlightNum.AutoSize = true;
			this.labelFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFlightNum.Location = new System.Drawing.Point(13, 13);
			this.labelFlightNum.Name = "labelFlightNum";
			this.labelFlightNum.Size = new System.Drawing.Size(89, 13);
			this.labelFlightNum.TabIndex = 1;
			this.labelFlightNum.Text = "Flight Number:";
			// 
			// labelFlightNumHere
			// 
			this.labelFlightNumHere.AutoSize = true;
			this.labelFlightNumHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFlightNumHere.Location = new System.Drawing.Point(146, 13);
			this.labelFlightNumHere.Name = "labelFlightNumHere";
			this.labelFlightNumHere.Size = new System.Drawing.Size(86, 13);
			this.labelFlightNumHere.TabIndex = 1;
			this.labelFlightNumHere.Text = "*FlightNum here*";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.Location = new System.Drawing.Point(13, 48);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(98, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Departure Date:";
			// 
			// labelPassenger
			// 
			this.labelPassenger.AutoSize = true;
			this.labelPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassenger.Location = new System.Drawing.Point(13, 78);
			this.labelPassenger.Name = "labelPassenger";
			this.labelPassenger.Size = new System.Drawing.Size(127, 13);
			this.labelPassenger.TabIndex = 1;
			this.labelPassenger.Text = "Passengers Boarded:";
			// 
			// labelPassengerHere
			// 
			this.labelPassengerHere.AutoSize = true;
			this.labelPassengerHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassengerHere.Location = new System.Drawing.Point(146, 78);
			this.labelPassengerHere.Name = "labelPassengerHere";
			this.labelPassengerHere.Size = new System.Drawing.Size(89, 13);
			this.labelPassengerHere.TabIndex = 1;
			this.labelPassengerHere.Text = "*Passenger here*";
			// 
			// labelDateHere
			// 
			this.labelDateHere.AutoSize = true;
			this.labelDateHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDateHere.Location = new System.Drawing.Point(146, 48);
			this.labelDateHere.Name = "labelDateHere";
			this.labelDateHere.Size = new System.Drawing.Size(87, 13);
			this.labelDateHere.TabIndex = 1;
			this.labelDateHere.Text = "*FlightDate here*";
			// 
			// FormFlightManifest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(262, 446);
			this.Controls.Add(this.labelPassenger);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelPassengerHere);
			this.Controls.Add(this.labelDateHere);
			this.Controls.Add(this.labelFlightNumHere);
			this.Controls.Add(this.labelFlightNum);
			this.Controls.Add(this.listViewPassengers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFlightManifest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flight Manifest";
			this.Load += new System.EventHandler(this.FormFlightManifest_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewPassengers;
		private System.Windows.Forms.ColumnHeader columnHeaderID;
		private System.Windows.Forms.Label labelFlightNum;
		private System.Windows.Forms.Label labelFlightNumHere;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.Label labelPassenger;
		private System.Windows.Forms.Label labelPassengerHere;
		private System.Windows.Forms.Label labelDateHere;
	}
}