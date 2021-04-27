
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
			this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelFlightNum = new System.Windows.Forms.Label();
			this.labelFlightNumHere = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 70);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(243, 368);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderID
			// 
			this.columnHeaderID.Text = "User ID";
			this.columnHeaderID.Width = 54;
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
			this.labelFlightNumHere.Location = new System.Drawing.Point(108, 13);
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
			this.labelDate.Size = new System.Drawing.Size(73, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Flight Date:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "h:mm tt, MM/dd/yyyy";
			this.dateTimePicker.Enabled = false;
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(111, 44);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(144, 20);
			this.dateTimePicker.TabIndex = 2;
			this.dateTimePicker.Value = new System.DateTime(2021, 4, 22, 12, 0, 0, 0);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Full Name";
			this.columnHeaderName.Width = 154;
			// 
			// FormFlightManifest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(262, 446);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelFlightNumHere);
			this.Controls.Add(this.labelFlightNum);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFlightManifest";
			this.Text = "Flight Manifest";
			this.Load += new System.EventHandler(this.FormFlightManifest_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeaderID;
		private System.Windows.Forms.Label labelFlightNum;
		private System.Windows.Forms.Label labelFlightNumHere;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
	}
}