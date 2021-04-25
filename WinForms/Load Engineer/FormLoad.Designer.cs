
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
			this.components = new System.ComponentModel.Container();
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.covidAirlinesDataSet2 = new CovidAirlines.CovidAirlinesDataSet2();
			this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.routeTableAdapter = new CovidAirlines.CovidAirlinesDataSet2TableAdapters.RouteTableAdapter();
			this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.originCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.destinationCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop1CityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop1ArrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop1DepartureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop2CityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop2ArrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stop2DepartureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airplaneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointsAwardedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
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
			this.columnHeaderOrigin.Width = 79;
			// 
			// columnHeaderDestination
			// 
			this.columnHeaderDestination.Text = "Destination";
			this.columnHeaderDestination.Width = 87;
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
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(109, 305);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(91, 23);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Delete Selected";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(12, 305);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(91, 23);
			this.buttonNew.TabIndex = 6;
			this.buttonNew.Text = "Add New Route";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIDDataGridViewTextBoxColumn,
            this.originCityIDDataGridViewTextBoxColumn,
            this.destinationCityIDDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.stop1CityIDDataGridViewTextBoxColumn,
            this.stop1ArrivalTimeDataGridViewTextBoxColumn,
            this.stop1DepartureTimeDataGridViewTextBoxColumn,
            this.stop2CityIDDataGridViewTextBoxColumn,
            this.stop2ArrivalTimeDataGridViewTextBoxColumn,
            this.stop2DepartureTimeDataGridViewTextBoxColumn,
            this.airplaneIDDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.pointsAwardedDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.routeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1160, 260);
			this.dataGridView1.TabIndex = 7;
			// 
			// covidAirlinesDataSet2
			// 
			this.covidAirlinesDataSet2.DataSetName = "CovidAirlinesDataSet2";
			this.covidAirlinesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// routeBindingSource
			// 
			this.routeBindingSource.DataMember = "Route";
			this.routeBindingSource.DataSource = this.covidAirlinesDataSet2;
			// 
			// routeTableAdapter
			// 
			this.routeTableAdapter.ClearBeforeFill = true;
			// 
			// routeIDDataGridViewTextBoxColumn
			// 
			this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
			this.routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
			this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
			this.routeIDDataGridViewTextBoxColumn.Width = 72;
			// 
			// originCityIDDataGridViewTextBoxColumn
			// 
			this.originCityIDDataGridViewTextBoxColumn.DataPropertyName = "OriginCityID";
			this.originCityIDDataGridViewTextBoxColumn.HeaderText = "OriginCityID";
			this.originCityIDDataGridViewTextBoxColumn.Name = "originCityIDDataGridViewTextBoxColumn";
			this.originCityIDDataGridViewTextBoxColumn.Width = 87;
			// 
			// destinationCityIDDataGridViewTextBoxColumn
			// 
			this.destinationCityIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationCityID";
			this.destinationCityIDDataGridViewTextBoxColumn.HeaderText = "DestinationCityID";
			this.destinationCityIDDataGridViewTextBoxColumn.Name = "destinationCityIDDataGridViewTextBoxColumn";
			this.destinationCityIDDataGridViewTextBoxColumn.Width = 113;
			// 
			// departureTimeDataGridViewTextBoxColumn
			// 
			this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
			this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
			this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
			this.departureTimeDataGridViewTextBoxColumn.Width = 102;
			// 
			// arrivalTimeDataGridViewTextBoxColumn
			// 
			this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
			this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
			this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
			this.arrivalTimeDataGridViewTextBoxColumn.Width = 84;
			// 
			// stop1CityIDDataGridViewTextBoxColumn
			// 
			this.stop1CityIDDataGridViewTextBoxColumn.DataPropertyName = "Stop1CityID";
			this.stop1CityIDDataGridViewTextBoxColumn.HeaderText = "Stop1CityID";
			this.stop1CityIDDataGridViewTextBoxColumn.Name = "stop1CityIDDataGridViewTextBoxColumn";
			this.stop1CityIDDataGridViewTextBoxColumn.Width = 88;
			// 
			// stop1ArrivalTimeDataGridViewTextBoxColumn
			// 
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop1ArrivalTime";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Stop1ArrivalTime";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.Name = "stop1ArrivalTimeDataGridViewTextBoxColumn";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.Width = 112;
			// 
			// stop1DepartureTimeDataGridViewTextBoxColumn
			// 
			this.stop1DepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop1DepartureTime";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.HeaderText = "Stop1DepartureTime";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.Name = "stop1DepartureTimeDataGridViewTextBoxColumn";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.Width = 130;
			// 
			// stop2CityIDDataGridViewTextBoxColumn
			// 
			this.stop2CityIDDataGridViewTextBoxColumn.DataPropertyName = "Stop2CityID";
			this.stop2CityIDDataGridViewTextBoxColumn.HeaderText = "Stop2CityID";
			this.stop2CityIDDataGridViewTextBoxColumn.Name = "stop2CityIDDataGridViewTextBoxColumn";
			this.stop2CityIDDataGridViewTextBoxColumn.Width = 88;
			// 
			// stop2ArrivalTimeDataGridViewTextBoxColumn
			// 
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop2ArrivalTime";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Stop2ArrivalTime";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.Name = "stop2ArrivalTimeDataGridViewTextBoxColumn";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.Width = 112;
			// 
			// stop2DepartureTimeDataGridViewTextBoxColumn
			// 
			this.stop2DepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop2DepartureTime";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.HeaderText = "Stop2DepartureTime";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.Name = "stop2DepartureTimeDataGridViewTextBoxColumn";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.Width = 130;
			// 
			// airplaneIDDataGridViewTextBoxColumn
			// 
			this.airplaneIDDataGridViewTextBoxColumn.DataPropertyName = "AirplaneID";
			this.airplaneIDDataGridViewTextBoxColumn.HeaderText = "AirplaneID";
			this.airplaneIDDataGridViewTextBoxColumn.Name = "airplaneIDDataGridViewTextBoxColumn";
			this.airplaneIDDataGridViewTextBoxColumn.Width = 81;
			// 
			// ticketPriceDataGridViewTextBoxColumn
			// 
			this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "TicketPrice";
			this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "TicketPrice";
			this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
			this.ticketPriceDataGridViewTextBoxColumn.Width = 86;
			// 
			// pointsAwardedDataGridViewTextBoxColumn
			// 
			this.pointsAwardedDataGridViewTextBoxColumn.DataPropertyName = "PointsAwarded";
			this.pointsAwardedDataGridViewTextBoxColumn.HeaderText = "PointsAwarded";
			this.pointsAwardedDataGridViewTextBoxColumn.Name = "pointsAwardedDataGridViewTextBoxColumn";
			this.pointsAwardedDataGridViewTextBoxColumn.Width = 103;
			// 
			// FormLoad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.listViewSchedule);
			this.Name = "FormLoad";
			this.Text = "FormLoad";
			this.Load += new System.EventHandler(this.FormLoad_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
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
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private CovidAirlinesDataSet2 covidAirlinesDataSet2;
		private System.Windows.Forms.BindingSource routeBindingSource;
		private CovidAirlinesDataSet2TableAdapters.RouteTableAdapter routeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn originCityIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop1CityIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop1ArrivalTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop1DepartureTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop2CityIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop2ArrivalTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stop2DepartureTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn airplaneIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pointsAwardedDataGridViewTextBoxColumn;
	}
}