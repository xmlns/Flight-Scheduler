
namespace CovidAirlines
{
	partial class FormMarketing
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
			this.columnHeaderPlane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelPlanes = new System.Windows.Forms.Label();
			this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.labelResponse = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
            this.columnHeaderStop2Depart,
            this.columnHeaderPlane,
            this.columnHeaderCapacity});
			this.listViewRoutes.FullRowSelect = true;
			this.listViewRoutes.HideSelection = false;
			this.listViewRoutes.Location = new System.Drawing.Point(12, 12);
			this.listViewRoutes.MultiSelect = false;
			this.listViewRoutes.Name = "listViewRoutes";
			this.listViewRoutes.Size = new System.Drawing.Size(1160, 287);
			this.listViewRoutes.TabIndex = 4;
			this.listViewRoutes.UseCompatibleStateImageBehavior = false;
			this.listViewRoutes.View = System.Windows.Forms.View.Details;
			this.listViewRoutes.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
			// 
			// columnHeaderFlightID
			// 
			this.columnHeaderFlightID.Text = "Route ID";
			this.columnHeaderFlightID.Width = 58;
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
			this.columnHeaderStop1.Width = 70;
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
			this.columnHeaderStop2.Width = 70;
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
			// columnHeaderPlane
			// 
			this.columnHeaderPlane.Text = "Plane";
			this.columnHeaderPlane.Width = 75;
			// 
			// columnHeaderCapacity
			// 
			this.columnHeaderCapacity.Text = "Capacity";
			// 
			// labelPlanes
			// 
			this.labelPlanes.AutoSize = true;
			this.labelPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlanes.Location = new System.Drawing.Point(12, 317);
			this.labelPlanes.Name = "labelPlanes";
			this.labelPlanes.Size = new System.Drawing.Size(43, 13);
			this.labelPlanes.TabIndex = 5;
			this.labelPlanes.Text = "Plane:";
			// 
			// comboBoxPlanes
			// 
			this.comboBoxPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPlanes.FormattingEnabled = true;
			this.comboBoxPlanes.Items.AddRange(new object[] {
            "*Plane 1*",
            "*Plane 2*",
            "*Plane 3*"});
			this.comboBoxPlanes.Location = new System.Drawing.Point(74, 313);
			this.comboBoxPlanes.Name = "comboBoxPlanes";
			this.comboBoxPlanes.Size = new System.Drawing.Size(121, 21);
			this.comboBoxPlanes.TabIndex = 6;
			this.comboBoxPlanes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlanes_SelectedIndexChanged);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(241, 312);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(80, 23);
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Text = "Update Plane";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// labelResponse
			// 
			this.labelResponse.AutoSize = true;
			this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResponse.Location = new System.Drawing.Point(343, 316);
			this.labelResponse.Name = "labelResponse";
			this.labelResponse.Size = new System.Drawing.Size(155, 13);
			this.labelResponse.TabIndex = 9;
			this.labelResponse.Text = "*Response message here*";
			this.labelResponse.Visible = false;
			// 
			// FormMarketing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.labelResponse);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.comboBoxPlanes);
			this.Controls.Add(this.labelPlanes);
			this.Controls.Add(this.listViewRoutes);
			this.Name = "FormMarketing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu - Marketing Manager";
			this.Load += new System.EventHandler(this.FormMarketing_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewRoutes;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderPlane;
		private System.Windows.Forms.Label labelPlanes;
		private System.Windows.Forms.ComboBox comboBoxPlanes;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Arrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Arrive;
		private System.Windows.Forms.Label labelResponse;
		private System.Windows.Forms.ColumnHeader columnHeaderCapacity;
	}
}