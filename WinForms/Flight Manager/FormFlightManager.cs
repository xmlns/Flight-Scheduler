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
	public partial class FormFlightManager : Form
	{
		public FormFlightManager()
		{
			InitializeComponent();
		}

		private void FormFlightManager_Load(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void LoadTable()
		{
			using (var db = new CovidAirlinesEntities())
			{
				//Now populate routes
				var cityList = db.Cities.ToList();//used to convert indices to corresponding names
				City nullCity = new City
				{
					Name = "-",
					Code = "-"
				};
				//Pushes cities up one to correct index AND now null values (for no stops) will pull from this entry in list
				cityList.Insert(0, nullCity);

				listViewFlights.Items.Clear();//clear all entries

				//get all flights up to current date
				DateTime cutoffDate = DateTime.Today.AddDays(2);
				var flights = db.Flights.Where(f => f.FlightDate <= cutoffDate).ToList();
				//Present every flight in the ListView table for manager
				foreach (Flight f in flights)
				{
					string[] entry = {
						f.FlightNumber.ToString(),
						cityList[f.Route.OriginCityID].Code,
						cityList[f.Route.DestinationCityID].Code,
						f.FlightDate.Add(f.Route.DepartureTime.TimeOfDay).ToString(),
						f.FlightDate.Add(f.Route.ArrivalTime.TimeOfDay).ToString(),
						cityList[f.Route.Stop1CityID.GetValueOrDefault()].Name,
						f.FlightDate.Add(f.Route.Stop1ArrivalTime.GetValueOrDefault().TimeOfDay).ToString(),
						f.FlightDate.Add(f.Route.Stop1DepartureTime.GetValueOrDefault().TimeOfDay).ToString(),
						cityList[f.Route.Stop2CityID.GetValueOrDefault()].Name,
						f.FlightDate.Add(f.Route.Stop2ArrivalTime.GetValueOrDefault().TimeOfDay).ToString(),
						f.FlightDate.Add(f.Route.Stop2DepartureTime.GetValueOrDefault().TimeOfDay).ToString(),
						f.CurrentPassengers.ToString() + "/" + f.MaxPassengers.ToString()
					};

					if (entry[5] == "-")//If no stop 1 city
					{
						entry[6] = "-";
						entry[7] = "-";
					}
					if (entry[8] == "-")//If no stop 1 city
					{
						entry[9] = "-";
						entry[10] = "-";
					}


					ListViewItem lvi = new ListViewItem(entry);
					listViewFlights.Items.Add(lvi);
				}
			}
		}

		private void listViewSchedule_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewFlights.SelectedItems.Count > 0)
			{
				buttonGenerate.Enabled = true;

			}
			else
			{
				buttonGenerate.Enabled = false;
			}
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			int selectedFlightNum = int.Parse(listViewFlights.SelectedItems[0].Text);

			FormFlightManifest fManifest = new FormFlightManifest(selectedFlightNum);
			fManifest.ShowDialog();
		}

	}
}
