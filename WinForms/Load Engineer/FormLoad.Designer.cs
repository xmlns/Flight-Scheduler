
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
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
			this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.covidAirlinesDataSet2 = new CovidAirlines.CovidAirlinesDataSet2();
			this.routeTableAdapter = new CovidAirlines.CovidAirlinesDataSet2TableAdapters.RouteTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDelete
			// 
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
			// dataGridViewRoutes
			// 
			this.dataGridViewRoutes.AllowUserToAddRows = false;
			this.dataGridViewRoutes.AllowUserToDeleteRows = false;
			this.dataGridViewRoutes.AutoGenerateColumns = false;
			this.dataGridViewRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRoutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dataGridViewRoutes.DataSource = this.routeBindingSource;
			this.dataGridViewRoutes.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewRoutes.MultiSelect = false;
			this.dataGridViewRoutes.Name = "dataGridViewRoutes";
			this.dataGridViewRoutes.ReadOnly = true;
			this.dataGridViewRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRoutes.Size = new System.Drawing.Size(1160, 377);
			this.dataGridViewRoutes.TabIndex = 7;
			this.dataGridViewRoutes.SelectionChanged += new System.EventHandler(this.dataGridViewRoutes_SelectionChanged);
			// 
			// routeIDDataGridViewTextBoxColumn
			// 
			this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
			this.routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
			this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
			this.routeIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.routeIDDataGridViewTextBoxColumn.Width = 72;
			// 
			// originCityIDDataGridViewTextBoxColumn
			// 
			this.originCityIDDataGridViewTextBoxColumn.DataPropertyName = "OriginCityID";
			this.originCityIDDataGridViewTextBoxColumn.HeaderText = "OriginCityID";
			this.originCityIDDataGridViewTextBoxColumn.Name = "originCityIDDataGridViewTextBoxColumn";
			this.originCityIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.originCityIDDataGridViewTextBoxColumn.Width = 87;
			// 
			// destinationCityIDDataGridViewTextBoxColumn
			// 
			this.destinationCityIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationCityID";
			this.destinationCityIDDataGridViewTextBoxColumn.HeaderText = "DestinationCityID";
			this.destinationCityIDDataGridViewTextBoxColumn.Name = "destinationCityIDDataGridViewTextBoxColumn";
			this.destinationCityIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.destinationCityIDDataGridViewTextBoxColumn.Width = 113;
			// 
			// departureTimeDataGridViewTextBoxColumn
			// 
			this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
			this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
			this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
			this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.departureTimeDataGridViewTextBoxColumn.Width = 102;
			// 
			// arrivalTimeDataGridViewTextBoxColumn
			// 
			this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
			this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
			this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
			this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.arrivalTimeDataGridViewTextBoxColumn.Width = 84;
			// 
			// stop1CityIDDataGridViewTextBoxColumn
			// 
			this.stop1CityIDDataGridViewTextBoxColumn.DataPropertyName = "Stop1CityID";
			this.stop1CityIDDataGridViewTextBoxColumn.HeaderText = "Stop1CityID";
			this.stop1CityIDDataGridViewTextBoxColumn.Name = "stop1CityIDDataGridViewTextBoxColumn";
			this.stop1CityIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop1CityIDDataGridViewTextBoxColumn.Width = 88;
			// 
			// stop1ArrivalTimeDataGridViewTextBoxColumn
			// 
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop1ArrivalTime";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Stop1ArrivalTime";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.Name = "stop1ArrivalTimeDataGridViewTextBoxColumn";
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop1ArrivalTimeDataGridViewTextBoxColumn.Width = 112;
			// 
			// stop1DepartureTimeDataGridViewTextBoxColumn
			// 
			this.stop1DepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop1DepartureTime";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.HeaderText = "Stop1DepartureTime";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.Name = "stop1DepartureTimeDataGridViewTextBoxColumn";
			this.stop1DepartureTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop1DepartureTimeDataGridViewTextBoxColumn.Width = 130;
			// 
			// stop2CityIDDataGridViewTextBoxColumn
			// 
			this.stop2CityIDDataGridViewTextBoxColumn.DataPropertyName = "Stop2CityID";
			this.stop2CityIDDataGridViewTextBoxColumn.HeaderText = "Stop2CityID";
			this.stop2CityIDDataGridViewTextBoxColumn.Name = "stop2CityIDDataGridViewTextBoxColumn";
			this.stop2CityIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop2CityIDDataGridViewTextBoxColumn.Width = 88;
			// 
			// stop2ArrivalTimeDataGridViewTextBoxColumn
			// 
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop2ArrivalTime";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Stop2ArrivalTime";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.Name = "stop2ArrivalTimeDataGridViewTextBoxColumn";
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop2ArrivalTimeDataGridViewTextBoxColumn.Width = 112;
			// 
			// stop2DepartureTimeDataGridViewTextBoxColumn
			// 
			this.stop2DepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop2DepartureTime";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.HeaderText = "Stop2DepartureTime";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.Name = "stop2DepartureTimeDataGridViewTextBoxColumn";
			this.stop2DepartureTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.stop2DepartureTimeDataGridViewTextBoxColumn.Width = 130;
			// 
			// airplaneIDDataGridViewTextBoxColumn
			// 
			this.airplaneIDDataGridViewTextBoxColumn.DataPropertyName = "AirplaneID";
			this.airplaneIDDataGridViewTextBoxColumn.HeaderText = "AirplaneID";
			this.airplaneIDDataGridViewTextBoxColumn.Name = "airplaneIDDataGridViewTextBoxColumn";
			this.airplaneIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.airplaneIDDataGridViewTextBoxColumn.Width = 81;
			// 
			// ticketPriceDataGridViewTextBoxColumn
			// 
			this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "TicketPrice";
			this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "TicketPrice";
			this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
			this.ticketPriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.ticketPriceDataGridViewTextBoxColumn.Width = 86;
			// 
			// pointsAwardedDataGridViewTextBoxColumn
			// 
			this.pointsAwardedDataGridViewTextBoxColumn.DataPropertyName = "PointsAwarded";
			this.pointsAwardedDataGridViewTextBoxColumn.HeaderText = "PointsAwarded";
			this.pointsAwardedDataGridViewTextBoxColumn.Name = "pointsAwardedDataGridViewTextBoxColumn";
			this.pointsAwardedDataGridViewTextBoxColumn.ReadOnly = true;
			this.pointsAwardedDataGridViewTextBoxColumn.Width = 103;
			// 
			// routeBindingSource
			// 
			this.routeBindingSource.DataMember = "Route";
			this.routeBindingSource.DataSource = this.covidAirlinesDataSet2;
			// 
			// covidAirlinesDataSet2
			// 
			this.covidAirlinesDataSet2.DataSetName = "CovidAirlinesDataSet2";
			this.covidAirlinesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// routeTableAdapter
			// 
			this.routeTableAdapter.ClearBeforeFill = true;
			// 
			// FormLoad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 461);
			this.Controls.Add(this.dataGridViewRoutes);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.buttonDelete);
			this.Name = "FormLoad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLoad";
			this.Load += new System.EventHandler(this.FormLoad_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.covidAirlinesDataSet2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.DataGridView dataGridViewRoutes;
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