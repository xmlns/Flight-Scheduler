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
	public partial class FormMarketing : Form
	{
		public FormMarketing()
		{
			InitializeComponent();
		}

		private void FormMarketing_Load(object sender, EventArgs e)
		{
			buttonUpdate.Enabled = false;
			RefreshTable();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			//get route ID of selected entry
			int selectedRouteID = int.Parse(listViewRoutes.SelectedItems[0].Text);

			using (var db = new CovidAirlinesEntities())
			{
				//get route entry from database that matches selected route id
				var route = db.Routes.Where(r => r.RouteID == selectedRouteID).FirstOrDefault();

				if (route != null)
				{
					route.AirplaneID = comboBoxPlanes.SelectedIndex;
					labelResponse.Text = "Successfully updated plane for Route #" + selectedRouteID.ToString();
					labelResponse.Show();
					db.SaveChanges();
				}
				else
				{
					labelResponse.Text = "Unable to update plane for Route #" + selectedRouteID.ToString();
					labelResponse.Show();
				}
			}
			//Update table to show changes
			RefreshTable();

		}

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRoutes.SelectedItems.Count > 0)
			{
				if (comboBoxPlanes.SelectedIndex != -1)
				{
					buttonUpdate.Enabled = true;
				}
				
			}
			else
			{
				buttonUpdate.Enabled = false;
			}
		}

		private void buttonDummy_Click(object sender, EventArgs e)
		{
			string[] entry = {"1",
				"Denver, CO (DEN)",
				"Austin, TX (AUS)",
				"12:00pm",
				"2:15pm",
				"NONE",
				"N/A",
				"NONE",
				"N/A",
				"737",
				"$100",
				"100"
			};
			Random rnd = new Random();
			entry[0] = rnd.Next(99).ToString();  // creates a number between 1 and 12
			ListViewItem lvi = new ListViewItem(entry);
			listViewRoutes.Items.Add(lvi);
		}

		private void comboBoxPlanes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRoutes.SelectedItems.Count > 0)
			{
				if (comboBoxPlanes.SelectedIndex != -1)
				{
					buttonUpdate.Enabled = true;
				}

			}
			else
			{
				buttonUpdate.Enabled = false;
			}
		}

		private void RefreshTable()
		{
			using (var db = new CovidAirlinesEntities())
			{
				//Fill/Update Combobox with airplane choices
				var planeList = db.Airplanes.ToList();
				//empty all items
				comboBoxPlanes.Items.Clear();
				foreach (Airplane p in planeList)
				{//For each plane in the database...
					//convert ID to its Enum type and add the string that identifies that index to the combobox
					comboBoxPlanes.Items.Add(((AirplaneType)p.AirplaneID).ToString());
				}

				//Now populate routes
				var cityList = db.Cities.ToList();//used to convert indices to corresponding names
				City nullCity = new City
				{
					Name = "N/A",
					Code = "N/A"
				};
				//Pushes cities up one to correct index AND now null values (for no stops) will pull from this entry in list
				cityList.Insert(0, nullCity);

				listViewRoutes.Items.Clear();//clear all entries

				var routes = db.Routes;
				//Present every possible route in the ListView table for customer
				foreach (Route r in routes)
				{
					string[] entry = {
						r.RouteID.ToString(),
						cityList[r.OriginCityID].Code + " - " + cityList[r.OriginCityID].Name,
						cityList[r.DestinationCityID].Code + " - " + cityList[r.DestinationCityID].Name,
						r.DepartureTime.TimeOfDay.ToString(),
						r.ArrivalTime.TimeOfDay.ToString(),
						cityList[r.Stop1CityID.GetValueOrDefault()].Name,
						r.Stop1ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop1DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
						cityList[r.Stop2CityID.GetValueOrDefault()].Name,
						r.Stop2ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop2DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
						((AirplaneType)r.AirplaneID).ToString(),
						planeList[r.AirplaneID].Capacity.ToString()
					};
					ListViewItem lvi = new ListViewItem(entry);
					listViewRoutes.Items.Add(lvi);
				}
			}
		}
	}
}
