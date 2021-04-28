
namespace CovidAirlines
{
	partial class FormLoad
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.listViewRoutes = new System.Windows.Forms.ListView();
			this.columnHeaderFlightID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2Arrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// buttonDelete
			// 
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Location = new System.Drawing.Point(109, 395);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(91, 23);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Delete Selected";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(12, 395);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(91, 23);
			this.buttonNew.TabIndex = 6;
			this.buttonNew.Text = "Add New Route";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// listViewRoutes
			// 
			this.listViewRoutes.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlightID,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderStop1,
            this.columnHeaderStop1Arrive,
            this.columnHeaderStop1Depart,
            this.columnHeaderStop2,
            this.columnHeaderStop2Arrive,
            this.columnHeaderStop2Depart});
			this.listViewRoutes.FullRowSelect = true;
			this.listViewRoutes.HideSelection = false;
			this.listViewRoutes.Location = new System.Drawing.Point(12, 12);
			this.listViewRoutes.MultiSelect = false;
			this.listViewRoutes.Name = "listViewRoutes";
			this.listViewRoutes.Size = new System.Drawing.Size(1160, 377);
			this.listViewRoutes.TabIndex = 8;
			this.listViewRoutes.UseCompatibleStateImageBehavior = false;
			this.listViewRoutes.View = System.Windows.Forms.View.Details;
			this.listViewRoutes.SelectedIndexChanged += new System.EventHandler(this.listViewRoutes_SelectedIndexChanged);
			// 
			// columnHeaderFlightID
			// 
			this.columnHeaderFlightID.Text = "Route ID";
			this.columnHeaderFlightID.Width = 58;
			// 
			// columnHeaderOrigin
			// 
			this.columnHeaderOrigin.Text = "Origin";
			this.columnHeaderOrigin.Width = 130;
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 130;
			// 
			// columnHeaderDepart
			// 
			this.columnHeaderDepart.Text = "Departure Time";
			this.columnHeaderDepart.Width = 86;
			// 
			// columnHeaderArrive
			// 
			this.columnHeaderArrive.Text = "Arrival Time";
			this.columnHeaderArrive.Width = 68;
			// 
			// columnHeaderStop1
			// 
			this.columnHeaderStop1.Text = "Stop 1";
			this.columnHeaderStop1.Width = 110;
			// 
			// columnHeaderStop1Arrive
			// 
			this.columnHeaderStop1Arrive.Text = "Stop 1 Arrival Time";
			this.columnHeaderStop1Arrive.Width = 103;
			// 
			// columnHeaderStop1Depart
			// 
			this.columnHeaderStop1Depart.Text = "Stop 1 Departure Time";
			this.columnHeaderStop1Depart.Width = 119;
			// 
			// columnHeaderStop2
			// 
			this.columnHeaderStop2.Text = "Stop 2";
			this.columnHeaderStop2.Width = 110;
			// 
			// columnHeaderStop2Arrive
			// 
			this.columnHeaderStop2Arrive.Text = "Stop 2 Arrival Time";
			this.columnHeaderStop2Arrive.Width = 102;
			// 
			// columnHeaderStop2Depart
			// 
			this.columnHeaderStop2Depart.Text = "Stop 2 Departure Time";
			this.columnHeaderStop2Depart.Width = 123;
			// 
			// FormLoad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.listViewRoutes);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.buttonDelete);
			this.Name = "FormLoad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLoad";
			this.Load += new System.EventHandler(this.FormLoad_Load_1);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.ListView listViewRoutes;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Arrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Arrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Depart;
	}
}