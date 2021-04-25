
namespace CovidAirlines
{
	partial class FormChooseFlight
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
			this.components = new System.ComponentModel.Container();
			this.listViewRoutes = new System.Windows.Forms.ListView();
			this.columnHeaderRouteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderArrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1Arrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop1Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2Arrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStop2Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonChooseFlight = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.labelChooseFlight = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.covidAirlinesDataSetRoutes = new CovidAirlines.CovidAirlinesDataSetRoutes();
			this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.routeTableAdapter = new CovidAirlines.CovidAirlinesDataSetRoutesTableAdapters.RouteTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSetRoutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listViewRoutes
			// 
			this.listViewRoutes.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listViewRoutes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listViewRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRouteID,
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderDepart,
            this.columnHeaderArrive,
            this.columnHeaderStop1,
            this.columnHeaderStop1Arrival,
            this.columnHeaderStop1Depart,
            this.columnHeaderStop2,
            this.columnHeaderStop2Arrival,
            this.columnHeaderStop2Depart,
            this.columnHeaderPrice,
            this.columnHeaderPoints});
			this.listViewRoutes.FullRowSelect = true;
			this.listViewRoutes.HideSelection = false;
			this.listViewRoutes.Location = new System.Drawing.Point(12, 31);
			this.listViewRoutes.MultiSelect = false;
			this.listViewRoutes.Name = "listViewRoutes";
			this.listViewRoutes.Size = new System.Drawing.Size(1173, 290);
			this.listViewRoutes.TabIndex = 4;
			this.listViewRoutes.UseCompatibleStateImageBehavior = false;
			this.listViewRoutes.View = System.Windows.Forms.View.Details;
			this.listViewRoutes.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
			// 
			// columnHeaderRouteID
			// 
			this.columnHeaderRouteID.Text = "RouteID";
			this.columnHeaderRouteID.Width = 55;
			// 
			// columnHeaderOrigin
			// 
			this.columnHeaderOrigin.Text = "Origin";
			this.columnHeaderOrigin.Width = 88;
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 89;
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
			// columnHeaderStop1Arrival
			// 
			this.columnHeaderStop1Arrival.Text = "Stop 1 Arrival Time";
			this.columnHeaderStop1Arrival.Width = 100;
			// 
			// columnHeaderStop1Depart
			// 
			this.columnHeaderStop1Depart.Text = "Stop 1 Departure Time";
			this.columnHeaderStop1Depart.Width = 122;
			// 
			// columnHeaderStop2
			// 
			this.columnHeaderStop2.Text = "Stop 2";
			// 
			// columnHeaderStop2Arrival
			// 
			this.columnHeaderStop2Arrival.Text = "Stop 2 Arrival Time";
			this.columnHeaderStop2Arrival.Width = 101;
			// 
			// columnHeaderStop2Depart
			// 
			this.columnHeaderStop2Depart.Text = "Stop 2 Departure Time";
			this.columnHeaderStop2Depart.Width = 119;
			// 
			// columnHeaderPrice
			// 
			this.columnHeaderPrice.Text = "Ticket Price";
			this.columnHeaderPrice.Width = 69;
			// 
			// columnHeaderPoints
			// 
			this.columnHeaderPoints.Text = "Points Awarded";
			this.columnHeaderPoints.Width = 86;
			// 
			// buttonChooseFlight
			// 
			this.buttonChooseFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonChooseFlight.AutoSize = true;
			this.buttonChooseFlight.Location = new System.Drawing.Point(12, 324);
			this.buttonChooseFlight.Name = "buttonChooseFlight";
			this.buttonChooseFlight.Size = new System.Drawing.Size(126, 23);
			this.buttonChooseFlight.TabIndex = 5;
			this.buttonChooseFlight.Text = "Choose Selected Flight";
			this.buttonChooseFlight.UseVisualStyleBackColor = true;
			this.buttonChooseFlight.Click += new System.EventHandler(this.buttonChooseFlight_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Location = new System.Drawing.Point(1107, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Dummy Entry";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelChooseFlight
			// 
			this.labelChooseFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelChooseFlight.AutoSize = true;
			this.labelChooseFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChooseFlight.Location = new System.Drawing.Point(8, 8);
			this.labelChooseFlight.Name = "labelChooseFlight";
			this.labelChooseFlight.Size = new System.Drawing.Size(206, 20);
			this.labelChooseFlight.TabIndex = 7;
			this.labelChooseFlight.Text = "Choose Departure Flight";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(12, 431);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(126, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// covidAirlinesDataSetRoutes
			// 
			this.covidAirlinesDataSetRoutes.DataSetName = "CovidAirlinesDataSetRoutes";
			this.covidAirlinesDataSetRoutes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// routeBindingSource
			// 
			this.routeBindingSource.DataMember = "Route";
			this.routeBindingSource.DataSource = this.covidAirlinesDataSetRoutes;
			// 
			// routeTableAdapter
			// 
			this.routeTableAdapter.ClearBeforeFill = true;
			// 
			// FormChooseFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1185, 510);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelChooseFlight);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonChooseFlight);
			this.Controls.Add(this.listViewRoutes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormChooseFlight";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book Your Flight!";
			this.Load += new System.EventHandler(this.FormBookFlight_Load);
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSetRoutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewRoutes;
		private System.Windows.Forms.ColumnHeader columnHeaderRouteID;
		private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
		private System.Windows.Forms.ColumnHeader columnHeaderDestination;
		private System.Windows.Forms.ColumnHeader columnHeaderDepart;
		private System.Windows.Forms.ColumnHeader columnHeaderArrive;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Depart;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.Button buttonChooseFlight;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelChooseFlight;
		private System.Windows.Forms.Button buttonCancel;
		private CovidAirlinesDataSetRoutes covidAirlinesDataSetRoutes;
		private System.Windows.Forms.BindingSource routeBindingSource;
		private CovidAirlinesDataSetRoutesTableAdapters.RouteTableAdapter routeTableAdapter;
		private System.Windows.Forms.ColumnHeader columnHeaderStop1Arrival;
		private System.Windows.Forms.ColumnHeader columnHeaderStop2Arrival;
		private System.Windows.Forms.ColumnHeader columnHeaderPoints;
	}
}