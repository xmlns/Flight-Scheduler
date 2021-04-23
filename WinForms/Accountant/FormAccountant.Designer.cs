
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
			this.listViewSchedule = new System.Windows.Forms.ListView();
			this.columnHeaderFlightID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSDepart1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderS2Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPlane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonSingle = new System.Windows.Forms.Button();
			this.buttonCompany = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewSchedule
			// 
			this.listViewSchedule.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlightID,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderStop1,
            this.columnHeaderSDepart1,
            this.columnHeaderStop2,
            this.columnHeaderS2Depart,
            this.columnHeaderPlane,
            this.columnHeaderPrice,
            this.columnHeaderPoints});
			this.listViewSchedule.FullRowSelect = true;
			this.listViewSchedule.HideSelection = false;
			this.listViewSchedule.Location = new System.Drawing.Point(12, 12);
			this.listViewSchedule.MultiSelect = false;
			this.listViewSchedule.Name = "listViewSchedule";
			this.listViewSchedule.Size = new System.Drawing.Size(1160, 287);
			this.listViewSchedule.TabIndex = 5;
			this.listViewSchedule.UseCompatibleStateImageBehavior = false;
			this.listViewSchedule.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderFlightID
			// 
			this.columnHeaderFlightID.Text = "Route ID";
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
			this.columnHeaderStop1.Width = 85;
			// 
			// columnHeaderSDepart1
			// 
			this.columnHeaderSDepart1.Text = "Stop 1 Departure Time";
			this.columnHeaderSDepart1.Width = 123;
			// 
			// columnHeaderStop2
			// 
			this.columnHeaderStop2.Text = "Stop 2";
			// 
			// columnHeaderS2Depart
			// 
			this.columnHeaderS2Depart.Text = "Stop 2 Departure Time";
			this.columnHeaderS2Depart.Width = 121;
			// 
			// columnHeaderPlane
			// 
			this.columnHeaderPlane.Text = "Plane";
			this.columnHeaderPlane.Width = 45;
			// 
			// columnHeaderPrice
			// 
			this.columnHeaderPrice.Text = "Ticket Price";
			this.columnHeaderPrice.Width = 69;
			// 
			// columnHeaderPoints
			// 
			this.columnHeaderPoints.Text = "Points Awarded";
			this.columnHeaderPoints.Width = 89;
			// 
			// buttonSingle
			// 
			this.buttonSingle.Location = new System.Drawing.Point(12, 305);
			this.buttonSingle.Name = "buttonSingle";
			this.buttonSingle.Size = new System.Drawing.Size(152, 23);
			this.buttonSingle.TabIndex = 6;
			this.buttonSingle.Text = "Generate Selected Summary";
			this.buttonSingle.UseVisualStyleBackColor = true;
			// 
			// buttonCompany
			// 
			this.buttonCompany.Location = new System.Drawing.Point(170, 305);
			this.buttonCompany.Name = "buttonCompany";
			this.buttonCompany.Size = new System.Drawing.Size(152, 23);
			this.buttonCompany.TabIndex = 6;
			this.buttonCompany.Text = "Generate Company Summary";
			this.buttonCompany.UseVisualStyleBackColor = true;
			// 
			// FormAccounting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.buttonCompany);
			this.Controls.Add(this.buttonSingle);
			this.Controls.Add(this.listViewSchedule);
			this.Name = "FormAccounting";
			this.Text = "Main Menu - Accounting Manager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewSchedule;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderSDepart1;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderS2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderPlane;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.ColumnHeader columnHeaderPoints;
		private System.Windows.Forms.Button buttonSingle;
		private System.Windows.Forms.Button buttonCompany;
	}
}