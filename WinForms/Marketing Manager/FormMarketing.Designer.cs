
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
			this.labelPlanes = new System.Windows.Forms.Label();
			this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDummy = new System.Windows.Forms.Button();
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
			this.listViewSchedule.TabIndex = 4;
			this.listViewSchedule.UseCompatibleStateImageBehavior = false;
			this.listViewSchedule.View = System.Windows.Forms.View.Details;
			this.listViewSchedule.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
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
			// buttonDummy
			// 
			this.buttonDummy.Location = new System.Drawing.Point(1086, 311);
			this.buttonDummy.Name = "buttonDummy";
			this.buttonDummy.Size = new System.Drawing.Size(75, 23);
			this.buttonDummy.TabIndex = 8;
			this.buttonDummy.Text = "Add Dummy";
			this.buttonDummy.UseVisualStyleBackColor = true;
			this.buttonDummy.Click += new System.EventHandler(this.buttonDummy_Click);
			// 
			// FormMarketing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.buttonDummy);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.comboBoxPlanes);
			this.Controls.Add(this.labelPlanes);
			this.Controls.Add(this.listViewSchedule);
			this.Name = "FormMarketing";
			this.Text = "Main Menu - Marketing Manager";
			this.Load += new System.EventHandler(this.FormMarketing_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Label labelPlanes;
		private System.Windows.Forms.ComboBox comboBoxPlanes;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDummy;
	}
}