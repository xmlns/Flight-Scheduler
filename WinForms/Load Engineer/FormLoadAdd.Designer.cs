
namespace CovidAirlines
{
	partial class FormLoadAdd
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
			this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.labelOrigin = new System.Windows.Forms.Label();
			this.comboBoxDestination = new System.Windows.Forms.ComboBox();
			this.labelDestination = new System.Windows.Forms.Label();
			this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
			this.labelDeparture = new System.Windows.Forms.Label();
			this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
			this.labelArrival = new System.Windows.Forms.Label();
			this.comboBoxStop1 = new System.Windows.Forms.ComboBox();
			this.labelStop1City = new System.Windows.Forms.Label();
			this.dateTimePickerStop1Depart = new System.Windows.Forms.DateTimePicker();
			this.labelStop1Depart = new System.Windows.Forms.Label();
			this.comboBoxStop2 = new System.Windows.Forms.ComboBox();
			this.labelStop2City = new System.Windows.Forms.Label();
			this.dateTimePickerStop2Depart = new System.Windows.Forms.DateTimePicker();
			this.labelStop2Depart = new System.Windows.Forms.Label();
			this.buttonAddRoute = new System.Windows.Forms.Button();
			this.labelPlane = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.dateTimePickerStop1Arrival = new System.Windows.Forms.DateTimePicker();
			this.labelStop1Arrival = new System.Windows.Forms.Label();
			this.dateTimePickerStop2Arrival = new System.Windows.Forms.DateTimePicker();
			this.labelStop2Arrival = new System.Windows.Forms.Label();
			this.checkBoxStop1 = new System.Windows.Forms.CheckBox();
			this.checkBoxStop2 = new System.Windows.Forms.CheckBox();
			this.labelError = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxOrigin
			// 
			this.comboBoxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOrigin.FormattingEnabled = true;
			this.comboBoxOrigin.Location = new System.Drawing.Point(118, 23);
			this.comboBoxOrigin.Name = "comboBoxOrigin";
			this.comboBoxOrigin.Size = new System.Drawing.Size(155, 21);
			this.comboBoxOrigin.TabIndex = 0;
			this.comboBoxOrigin.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigin_SelectedIndexChanged);
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.AllowNew = true;
			this.cityBindingSource.DataMember = "Name";
			// 
			// labelOrigin
			// 
			this.labelOrigin.AutoSize = true;
			this.labelOrigin.Location = new System.Drawing.Point(23, 27);
			this.labelOrigin.Name = "labelOrigin";
			this.labelOrigin.Size = new System.Drawing.Size(54, 13);
			this.labelOrigin.TabIndex = 1;
			this.labelOrigin.Text = "Origin City";
			// 
			// comboBoxDestination
			// 
			this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDestination.FormattingEnabled = true;
			this.comboBoxDestination.Location = new System.Drawing.Point(388, 23);
			this.comboBoxDestination.Name = "comboBoxDestination";
			this.comboBoxDestination.Size = new System.Drawing.Size(155, 21);
			this.comboBoxDestination.Sorted = true;
			this.comboBoxDestination.TabIndex = 0;
			// 
			// labelDestination
			// 
			this.labelDestination.AutoSize = true;
			this.labelDestination.Location = new System.Drawing.Point(289, 27);
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.Size = new System.Drawing.Size(80, 13);
			this.labelDestination.TabIndex = 1;
			this.labelDestination.Text = "Destination City";
			// 
			// dateTimePickerDepart
			// 
			this.dateTimePickerDepart.CustomFormat = "h:mm tt";
			this.dateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDepart.Location = new System.Drawing.Point(118, 76);
			this.dateTimePickerDepart.Name = "dateTimePickerDepart";
			this.dateTimePickerDepart.ShowUpDown = true;
			this.dateTimePickerDepart.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerDepart.TabIndex = 2;
			this.dateTimePickerDepart.Value = new System.DateTime(2021, 4, 19, 10, 0, 0, 0);
			this.dateTimePickerDepart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelDeparture
			// 
			this.labelDeparture.AutoSize = true;
			this.labelDeparture.Location = new System.Drawing.Point(23, 80);
			this.labelDeparture.Name = "labelDeparture";
			this.labelDeparture.Size = new System.Drawing.Size(80, 13);
			this.labelDeparture.TabIndex = 3;
			this.labelDeparture.Text = "Departure Time";
			// 
			// dateTimePickerArrival
			// 
			this.dateTimePickerArrival.CustomFormat = "h:mm tt";
			this.dateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerArrival.Location = new System.Drawing.Point(388, 76);
			this.dateTimePickerArrival.Name = "dateTimePickerArrival";
			this.dateTimePickerArrival.ShowUpDown = true;
			this.dateTimePickerArrival.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerArrival.TabIndex = 2;
			this.dateTimePickerArrival.Value = new System.DateTime(2021, 4, 19, 20, 0, 0, 0);
			this.dateTimePickerArrival.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelArrival
			// 
			this.labelArrival.AutoSize = true;
			this.labelArrival.Location = new System.Drawing.Point(289, 80);
			this.labelArrival.Name = "labelArrival";
			this.labelArrival.Size = new System.Drawing.Size(62, 13);
			this.labelArrival.TabIndex = 3;
			this.labelArrival.Text = "Arrival Time";
			// 
			// comboBoxStop1
			// 
			this.comboBoxStop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStop1.Enabled = false;
			this.comboBoxStop1.FormattingEnabled = true;
			this.comboBoxStop1.Location = new System.Drawing.Point(118, 155);
			this.comboBoxStop1.Name = "comboBoxStop1";
			this.comboBoxStop1.Size = new System.Drawing.Size(155, 21);
			this.comboBoxStop1.Sorted = true;
			this.comboBoxStop1.TabIndex = 0;
			// 
			// labelStop1City
			// 
			this.labelStop1City.AutoSize = true;
			this.labelStop1City.Location = new System.Drawing.Point(23, 159);
			this.labelStop1City.Name = "labelStop1City";
			this.labelStop1City.Size = new System.Drawing.Size(58, 13);
			this.labelStop1City.TabIndex = 1;
			this.labelStop1City.Text = "Stop 1 City";
			// 
			// dateTimePickerStop1Depart
			// 
			this.dateTimePickerStop1Depart.CustomFormat = "h:mm tt";
			this.dateTimePickerStop1Depart.Enabled = false;
			this.dateTimePickerStop1Depart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStop1Depart.Location = new System.Drawing.Point(118, 208);
			this.dateTimePickerStop1Depart.Name = "dateTimePickerStop1Depart";
			this.dateTimePickerStop1Depart.ShowUpDown = true;
			this.dateTimePickerStop1Depart.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerStop1Depart.TabIndex = 2;
			this.dateTimePickerStop1Depart.Value = new System.DateTime(2021, 4, 19, 14, 0, 0, 0);
			this.dateTimePickerStop1Depart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelStop1Depart
			// 
			this.labelStop1Depart.AutoSize = true;
			this.labelStop1Depart.Location = new System.Drawing.Point(23, 212);
			this.labelStop1Depart.Name = "labelStop1Depart";
			this.labelStop1Depart.Size = new System.Drawing.Size(80, 13);
			this.labelStop1Depart.TabIndex = 3;
			this.labelStop1Depart.Text = "Departure Time";
			// 
			// comboBoxStop2
			// 
			this.comboBoxStop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStop2.Enabled = false;
			this.comboBoxStop2.FormattingEnabled = true;
			this.comboBoxStop2.Location = new System.Drawing.Point(388, 155);
			this.comboBoxStop2.Name = "comboBoxStop2";
			this.comboBoxStop2.Size = new System.Drawing.Size(155, 21);
			this.comboBoxStop2.Sorted = true;
			this.comboBoxStop2.TabIndex = 0;
			// 
			// labelStop2City
			// 
			this.labelStop2City.AutoSize = true;
			this.labelStop2City.Location = new System.Drawing.Point(289, 159);
			this.labelStop2City.Name = "labelStop2City";
			this.labelStop2City.Size = new System.Drawing.Size(58, 13);
			this.labelStop2City.TabIndex = 1;
			this.labelStop2City.Text = "Stop 2 City";
			// 
			// dateTimePickerStop2Depart
			// 
			this.dateTimePickerStop2Depart.CustomFormat = "h:mm tt";
			this.dateTimePickerStop2Depart.Enabled = false;
			this.dateTimePickerStop2Depart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStop2Depart.Location = new System.Drawing.Point(388, 209);
			this.dateTimePickerStop2Depart.Name = "dateTimePickerStop2Depart";
			this.dateTimePickerStop2Depart.ShowUpDown = true;
			this.dateTimePickerStop2Depart.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerStop2Depart.TabIndex = 2;
			this.dateTimePickerStop2Depart.Value = new System.DateTime(2021, 4, 19, 18, 0, 0, 0);
			this.dateTimePickerStop2Depart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelStop2Depart
			// 
			this.labelStop2Depart.AutoSize = true;
			this.labelStop2Depart.Location = new System.Drawing.Point(289, 213);
			this.labelStop2Depart.Name = "labelStop2Depart";
			this.labelStop2Depart.Size = new System.Drawing.Size(80, 13);
			this.labelStop2Depart.TabIndex = 3;
			this.labelStop2Depart.Text = "Departure Time";
			// 
			// buttonAddRoute
			// 
			this.buttonAddRoute.Location = new System.Drawing.Point(41, 301);
			this.buttonAddRoute.Name = "buttonAddRoute";
			this.buttonAddRoute.Size = new System.Drawing.Size(75, 23);
			this.buttonAddRoute.TabIndex = 4;
			this.buttonAddRoute.Text = "Add Route";
			this.buttonAddRoute.UseVisualStyleBackColor = true;
			this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
			// 
			// labelPlane
			// 
			this.labelPlane.AutoSize = true;
			this.labelPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlane.Location = new System.Drawing.Point(38, 270);
			this.labelPlane.Name = "labelPlane";
			this.labelPlane.Size = new System.Drawing.Size(501, 13);
			this.labelPlane.TabIndex = 5;
			this.labelPlane.Text = "*Plane will be defaulted to XXX and will need to be changed by the Marketing Mana" +
    "ger";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(143, 301);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// dateTimePickerStop1Arrival
			// 
			this.dateTimePickerStop1Arrival.CustomFormat = "h:mm tt";
			this.dateTimePickerStop1Arrival.Enabled = false;
			this.dateTimePickerStop1Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStop1Arrival.Location = new System.Drawing.Point(118, 182);
			this.dateTimePickerStop1Arrival.Name = "dateTimePickerStop1Arrival";
			this.dateTimePickerStop1Arrival.ShowUpDown = true;
			this.dateTimePickerStop1Arrival.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerStop1Arrival.TabIndex = 2;
			this.dateTimePickerStop1Arrival.Value = new System.DateTime(2021, 4, 19, 12, 0, 0, 0);
			this.dateTimePickerStop1Arrival.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelStop1Arrival
			// 
			this.labelStop1Arrival.AutoSize = true;
			this.labelStop1Arrival.Location = new System.Drawing.Point(23, 186);
			this.labelStop1Arrival.Name = "labelStop1Arrival";
			this.labelStop1Arrival.Size = new System.Drawing.Size(62, 13);
			this.labelStop1Arrival.TabIndex = 3;
			this.labelStop1Arrival.Text = "Arrival Time";
			// 
			// dateTimePickerStop2Arrival
			// 
			this.dateTimePickerStop2Arrival.CustomFormat = "h:mm tt";
			this.dateTimePickerStop2Arrival.Enabled = false;
			this.dateTimePickerStop2Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStop2Arrival.Location = new System.Drawing.Point(388, 182);
			this.dateTimePickerStop2Arrival.Name = "dateTimePickerStop2Arrival";
			this.dateTimePickerStop2Arrival.ShowUpDown = true;
			this.dateTimePickerStop2Arrival.Size = new System.Drawing.Size(85, 20);
			this.dateTimePickerStop2Arrival.TabIndex = 2;
			this.dateTimePickerStop2Arrival.Value = new System.DateTime(2021, 4, 19, 16, 0, 0, 0);
			this.dateTimePickerStop2Arrival.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// labelStop2Arrival
			// 
			this.labelStop2Arrival.AutoSize = true;
			this.labelStop2Arrival.Location = new System.Drawing.Point(289, 186);
			this.labelStop2Arrival.Name = "labelStop2Arrival";
			this.labelStop2Arrival.Size = new System.Drawing.Size(62, 13);
			this.labelStop2Arrival.TabIndex = 3;
			this.labelStop2Arrival.Text = "Arrival Time";
			// 
			// checkBoxStop1
			// 
			this.checkBoxStop1.AutoSize = true;
			this.checkBoxStop1.Location = new System.Drawing.Point(26, 130);
			this.checkBoxStop1.Name = "checkBoxStop1";
			this.checkBoxStop1.Size = new System.Drawing.Size(57, 17);
			this.checkBoxStop1.TabIndex = 7;
			this.checkBoxStop1.Text = "Stop 1";
			this.checkBoxStop1.UseVisualStyleBackColor = true;
			this.checkBoxStop1.CheckedChanged += new System.EventHandler(this.checkBoxStop1_CheckedChanged);
			// 
			// checkBoxStop2
			// 
			this.checkBoxStop2.AutoSize = true;
			this.checkBoxStop2.Enabled = false;
			this.checkBoxStop2.Location = new System.Drawing.Point(296, 130);
			this.checkBoxStop2.Name = "checkBoxStop2";
			this.checkBoxStop2.Size = new System.Drawing.Size(57, 17);
			this.checkBoxStop2.TabIndex = 7;
			this.checkBoxStop2.Text = "Stop 2";
			this.checkBoxStop2.UseVisualStyleBackColor = true;
			this.checkBoxStop2.CheckedChanged += new System.EventHandler(this.checkBoxStop2_CheckedChanged);
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(224, 306);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(93, 13);
			this.labelError.TabIndex = 5;
			this.labelError.Text = "*Error Message";
			this.labelError.Visible = false;
			// 
			// FormLoadAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 344);
			this.Controls.Add(this.checkBoxStop2);
			this.Controls.Add(this.checkBoxStop1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.labelPlane);
			this.Controls.Add(this.buttonAddRoute);
			this.Controls.Add(this.labelStop2Depart);
			this.Controls.Add(this.labelStop1Depart);
			this.Controls.Add(this.labelStop2Arrival);
			this.Controls.Add(this.labelStop1Arrival);
			this.Controls.Add(this.labelArrival);
			this.Controls.Add(this.dateTimePickerStop2Depart);
			this.Controls.Add(this.dateTimePickerStop1Depart);
			this.Controls.Add(this.dateTimePickerStop2Arrival);
			this.Controls.Add(this.dateTimePickerStop1Arrival);
			this.Controls.Add(this.dateTimePickerArrival);
			this.Controls.Add(this.labelDeparture);
			this.Controls.Add(this.dateTimePickerDepart);
			this.Controls.Add(this.labelDestination);
			this.Controls.Add(this.comboBoxDestination);
			this.Controls.Add(this.labelStop2City);
			this.Controls.Add(this.labelStop1City);
			this.Controls.Add(this.comboBoxStop2);
			this.Controls.Add(this.labelOrigin);
			this.Controls.Add(this.comboBoxStop1);
			this.Controls.Add(this.comboBoxOrigin);
			this.Name = "FormLoadAdd";
			this.Text = "Add New Route!";
			this.Load += new System.EventHandler(this.FormLoadAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxOrigin;
		private System.Windows.Forms.Label labelOrigin;
		private System.Windows.Forms.ComboBox comboBoxDestination;
		private System.Windows.Forms.Label labelDestination;
		private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
		private System.Windows.Forms.Label labelDeparture;
		private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
		private System.Windows.Forms.Label labelArrival;
		private System.Windows.Forms.ComboBox comboBoxStop1;
		private System.Windows.Forms.Label labelStop1City;
		private System.Windows.Forms.DateTimePicker dateTimePickerStop1Depart;
		private System.Windows.Forms.Label labelStop1Depart;
		private System.Windows.Forms.ComboBox comboBoxStop2;
		private System.Windows.Forms.Label labelStop2City;
		private System.Windows.Forms.DateTimePicker dateTimePickerStop2Depart;
		private System.Windows.Forms.Label labelStop2Depart;
		private System.Windows.Forms.Button buttonAddRoute;
		private System.Windows.Forms.Label labelPlane;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private System.Windows.Forms.DateTimePicker dateTimePickerStop1Arrival;
		private System.Windows.Forms.Label labelStop1Arrival;
		private System.Windows.Forms.DateTimePicker dateTimePickerStop2Arrival;
		private System.Windows.Forms.Label labelStop2Arrival;
		private System.Windows.Forms.CheckBox checkBoxStop1;
		private System.Windows.Forms.CheckBox checkBoxStop2;
		private System.Windows.Forms.Label labelError;
	}
}