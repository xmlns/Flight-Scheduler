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
	public partial class FormChooseFlight : Form
	{
		public string chosenRouteID { get; set; }
		public FormChooseFlight(int originID, int destinationID, bool roundtrip)
		{
			InitializeComponent();

			using (var db = new CovidAirlinesEntities())
			{
				if (roundtrip)	labelChooseFlight.Text = "Choose Return Flight";

				var cityList = db.Cities.ToList();
				City nullCity = new City
				{
					Name = "N/A",
					Code = "N/A"
				};
				//Pushes cities up one to correct index AND now null values (for no stops) will pull from this entry in list
				cityList.Insert(0, nullCity);

				var routes = db.Routes.Where(r => r.OriginCityID == originID).Where(r => r.DestinationCityID == destinationID);
				//Present every possible route in the ListView table for customer
				foreach (Route r in routes)
				{
					string[] entry = {
						r.RouteID.ToString(),
						//cityList[r.OriginCityID].Code + " - " + cityList[r.OriginCityID].Name,
						cityList[r.OriginCityID].Name,
						cityList[r.DestinationCityID].Name,
						r.DepartureTime.TimeOfDay.ToString(),
						r.ArrivalTime.TimeOfDay.ToString(),
						cityList[r.Stop1CityID.GetValueOrDefault()].Name,
						r.Stop1ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop1DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
						cityList[r.Stop2CityID.GetValueOrDefault()].Name,
						r.Stop2ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop2DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.TicketPrice.ToString(),
						r.PointsAwarded.ToString()
					};
					ListViewItem lvi = new ListViewItem(entry);
					listViewRoutes.Items.Add(lvi);
				}	
			}
		}

		private void FormBookFlight_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'covidAirlinesDataSetRoutes.Route' table. You can move, or remove it, as needed.
			this.routeTableAdapter.Fill(this.covidAirlinesDataSetRoutes.Route);
			buttonChooseFlight.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] entry = {
				"123",
				"Denver, CO (DEN)",
				"Austin, TX (AUS)",
				DateTime.Now.AddDays(7).ToString(),
				"2:15pm",
				"NONE",
				"N/A",
				"NONE",
				"N/A",
				"Active/Cancelled",
				"$100"
			};
			Random rnd = new Random();
			entry[0] = rnd.Next(999).ToString();  // creates a number between 1 and 12
			ListViewItem lvi = new ListViewItem(entry);
			listViewRoutes.Items.Add(lvi);
		}

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRoutes.SelectedItems.Count > 0)
			{
				buttonChooseFlight.Enabled = true;

			}
			else
			{
				buttonChooseFlight.Enabled = false;
			}
		}

		private void buttonChooseFlight_Click(object sender, EventArgs e)
		{
			chosenRouteID = listViewRoutes.SelectedItems[0].Text;
			this.DialogResult = DialogResult.OK;
			this.Close();

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
