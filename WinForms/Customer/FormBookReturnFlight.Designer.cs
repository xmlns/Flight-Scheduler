
namespace CovidAirlines
{
	partial class FormBookReturnFlight
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
			this.buttonChooseFlight = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.labelSelectReturn = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			this.listViewHistory.Location = new System.Drawing.Point(12, 32);
			this.listViewHistory.MultiSelect = false;
			this.listViewHistory.Name = "listViewHistory";
			this.listViewHistory.Size = new System.Drawing.Size(1173, 287);
			this.listViewHistory.TabIndex = 4;
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
			this.columnHeaderSDepart1.Width = 112;
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
			// buttonChooseFlight
			// 
			this.buttonChooseFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonChooseFlight.Location = new System.Drawing.Point(12, 325);
			this.buttonChooseFlight.Name = "buttonChooseFlight";
			this.buttonChooseFlight.Size = new System.Drawing.Size(126, 23);
			this.buttonChooseFlight.TabIndex = 5;
			this.buttonChooseFlight.Text = "Choose Selected Flight";
			this.buttonChooseFlight.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(1107, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Dummy Entry";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelSelectReturn
			// 
			this.labelSelectReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSelectReturn.AutoSize = true;
			this.labelSelectReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectReturn.Location = new System.Drawing.Point(12, 9);
			this.labelSelectReturn.Name = "labelSelectReturn";
			this.labelSelectReturn.Size = new System.Drawing.Size(204, 20);
			this.labelSelectReturn.TabIndex = 7;
			this.labelSelectReturn.Text = "Choose Returning Flight";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCancel.Location = new System.Drawing.Point(16, 420);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(122, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel Order";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormBookReturnFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1197, 455);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelSelectReturn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonChooseFlight);
			this.Controls.Add(this.listViewHistory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBookReturnFlight";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Book Your Flight!";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormBookFlight_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewHistory;
		private System.Windows.Forms.ColumnHeader columnHeaderFlightID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderSDepart1;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderS2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStatus;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.Button buttonChooseFlight;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelSelectReturn;
		private System.Windows.Forms.Button buttonCancel;
	}
}