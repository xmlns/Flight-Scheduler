
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelFlight = new System.Windows.Forms.Label();
			this.labelFlightID = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(16, 70);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(121, 368);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Users On Board";
			this.columnHeader1.Width = 117;
			// 
			// labelFlight
			// 
			this.labelFlight.AutoSize = true;
			this.labelFlight.Location = new System.Drawing.Point(13, 13);
			this.labelFlight.Name = "labelFlight";
			this.labelFlight.Size = new System.Drawing.Size(46, 13);
			this.labelFlight.TabIndex = 1;
			this.labelFlight.Text = "FlightID:";
			// 
			// labelFlightID
			// 
			this.labelFlightID.AutoSize = true;
			this.labelFlightID.Location = new System.Drawing.Point(93, 13);
			this.labelFlightID.Name = "labelFlightID";
			this.labelFlightID.Size = new System.Drawing.Size(101, 13);
			this.labelFlightID.TabIndex = 1;
			this.labelFlightID.Text = "*FlightID goes here*";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(13, 48);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(61, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Flight Date:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "h:mm tt, MM/dd/yyyy";
			this.dateTimePicker.Enabled = false;
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(93, 44);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(133, 20);
			this.dateTimePicker.TabIndex = 2;
			this.dateTimePicker.Value = new System.DateTime(2021, 4, 22, 12, 0, 0, 0);
			// 
			// FormFlightManifest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 446);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelFlightID);
			this.Controls.Add(this.labelFlight);
			this.Controls.Add(this.listView1);
			this.Name = "FormFlightManifest";
			this.Text = "Flight Manifest";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label labelFlight;
		private System.Windows.Forms.Label labelFlightID;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
	}
}