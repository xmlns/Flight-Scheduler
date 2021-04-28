using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CovidAirlines
{
	public partial class FormLoadAdd : Form
	{

		public FormLoadAdd()
		{
			InitializeComponent();
		}

		private void FormLoadAdd_Load(object sender, EventArgs e)
		{
			comboBoxStop1.Enabled = false;

			//Populate city choices
			using (var entities = new CovidAirlinesEntities())
			{
				var cityList = entities.Cities.ToList();
				string cityString;
				foreach (City c in cityList)
				{
					cityString = c.Code + " - " + c.Name;
					comboBoxOrigin.Items.Add(cityString);
					comboBoxDestination.Items.Add(cityString);
					comboBoxStop1.Items.Add(cityString);
					comboBoxStop2.Items.Add(cityString);
				}
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void buttonAddRoute_Click(object sender, EventArgs e)
		{
			//TODO - Parse inputted data and add to database
			var allCityIDs = new[] {
				comboBoxOrigin.SelectedIndex,
				comboBoxDestination.SelectedIndex,
				comboBoxStop1.SelectedIndex,
				comboBoxStop2.SelectedIndex
			};

			if (comboBoxOrigin.SelectedIndex == -1)
			{
				labelError.Text = "Enter an Origin City";
				labelError.Show();
				return;
			}
			if (comboBoxDestination.SelectedIndex == -1)
			{
				labelError.Text = "Enter a Destination City";
				labelError.Show();
				return;
			}
			if (checkBoxStop1.Checked == true && comboBoxStop1.SelectedIndex == -1)
			{
				labelError.Text = "Enter a Stop 1 City";
				labelError.Show();
				return;
			}
			if (checkBoxStop2.Checked == true && comboBoxStop2.SelectedIndex == -1)
			{
				labelError.Text = "Enter a Stop 2 City";
				labelError.Show();
				return;
			}
				
			int count = 2;
			if (checkBoxStop2.Checked == true) count = 4;
			else if (checkBoxStop1.Checked == true) count = 3;

			bool allUnique = allCityIDs.Take(count).Distinct().Count() == count;

			if (!allUnique)
			{
				labelError.Text = "All cities must be unique!";
				labelError.Show();
				return;
			}

			using (var db = new CovidAirlinesEntities()) {
				List<City> CityList = db.Cities.ToList();
				
				Route newRoute = new Route
				{
					//RouteID = 1, now auto increments
					OriginCityID = comboBoxOrigin.SelectedIndex + 1,//+1 since comboboxes are zxero indexed and database starts at 1
					DestinationCityID = comboBoxDestination.SelectedIndex + 1,
					DepartureTime = dateTimePickerDepart.Value,
					ArrivalTime = dateTimePickerArrival.Value,
					Stop1CityID = comboBoxStop1.SelectedIndex + 1,
					Stop1ArrivalTime = dateTimePickerStop1Arrival.Value,
					Stop1DepartureTime = dateTimePickerStop1Depart.Value,
					Stop2CityID = comboBoxStop2.SelectedIndex + 1,
					Stop2ArrivalTime = dateTimePickerStop2Arrival.Value,
					Stop2DepartureTime = dateTimePickerStop2Depart.Value,
					AirplaneID = (byte)AirplaneType.Boeing_737
				};
				newRoute.TicketPrice = Utility.CalculateTicketPrice(newRoute.OriginCityID, newRoute.DestinationCityID);
				newRoute.PointsAwarded = Utility.CalculatePointsAwarded(Convert.ToDouble(newRoute.TicketPrice));

				if (checkBoxStop1.Checked == false)
				{
					newRoute.Stop1CityID = null;
					newRoute.Stop1ArrivalTime = null;
					newRoute.Stop1DepartureTime = null;
				}
				if (checkBoxStop2.Checked == false)
				{
					newRoute.Stop2CityID = null;
					newRoute.Stop2ArrivalTime = null;
					newRoute.Stop2DepartureTime = null;
				}

				db.Routes.Add(newRoute);
				db.SaveChanges();

				labelError.Text = "Success!";
				labelError.Show();

			}

			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBoxOrigin_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBoxStop1_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = checkBoxStop1.Checked;

			comboBoxStop1.Enabled = enabled;
			dateTimePickerStop1Arrival.Enabled = enabled;
			dateTimePickerStop1Depart.Enabled = enabled;

			//enabled stop 2 if stop 1 in use
			checkBoxStop2.Enabled = enabled;
			if (enabled == false)
			{
				comboBoxStop1.SelectedIndex = -1;
				checkBoxStop2.Checked = false;
			}

		}

		private void checkBoxStop2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = checkBoxStop2.Checked;

			comboBoxStop2.Enabled = enabled;
			dateTimePickerStop2Arrival.Enabled = enabled;
			dateTimePickerStop2Depart.Enabled = enabled;
			
			if (enabled == false)	comboBoxStop2.SelectedIndex = -1;
			
		}
	}
}
