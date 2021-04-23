using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			
			//List<City> cityList =;
			//string test = _context.Cities.ToList()[0].Name;
			//comboBoxOrigin.Items.AddRange(cityList);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void buttonAddRoute_Click(object sender, EventArgs e)
		{
			//TODO - Parse inputted data and add to database
			using (var db = new CovidAirlinesEntities()) {
				List<City> CityList = db.Cities.ToList();
				Airplane a = new Airplane { AirplaneID = 1, AirplaneType = (byte)AirplaneType.Boeing_737, Quantity = 100 };
				
				/*Route newRoute = new Route
				{
					RouteID = 1,
					Origin = _context.Cities.First(),
					Destination = CityList[1],
					DepartureTime = dateTimePickerDepart.Value,
					ArrivalTime = dateTimePickerArrival.Value,
					Stop1 = CityList[2],
					Stop1ArrivalTime = dateTimePickerStop1Arrival.Value,
					Stop1DepartureTime = dateTimePickerStop1Depart.Value,
					Stop2 = CityList[3],
					Stop2ArrivalTime = dateTimePickerStop2Arrival.Value,
					Stop2DepartureTime = dateTimePickerStop2Depart.Value,
					Airplane = a,
					TicketPrice = 100,
					PointsAwarded = 100
				};
				*/
				//db.DailySchedules.Add(newRoute);
				//db.SaveChanges();

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
			if (enabled == false) checkBoxStop2.Checked = false;

		}

		private void checkBoxStop2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = checkBoxStop2.Checked;

			comboBoxStop2.Enabled = enabled;
			dateTimePickerStop2Arrival.Enabled = enabled;
			dateTimePickerStop2Depart.Enabled = enabled;

		}
	}
}
