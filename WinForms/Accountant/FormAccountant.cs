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
	public partial class FormAccountant : Form
	{
		public FormAccountant()
		{
			InitializeComponent();
			PopulateTable();
		}

		private void FormAccountant_Load(object sender, EventArgs e)
		{

		}


		private void PopulateTable()
		{
			using (var db = new CovidAirlinesEntities())
			{
				//Get cities
				var cityList = db.Cities.ToList();//used to convert indices to corresponding names
				City nullCity = new City
				{
					Name = "-",
					Code = "-"
				};
				//Pushes cities up one to correct index AND now null values (for no stops) will pull from this entry in list
				cityList.Insert(0, nullCity);

				listViewFlights.Items.Clear();//clear all entries

				int totalFlights, totalPassengers, totalCapacity;
				totalFlights = totalPassengers = totalCapacity = 0;
				decimal totalIncome = 0;


				var flights = db.Flights;
				//Present every possible route in the ListView table for accountant
				foreach (Flight f in flights)
				{
					//For total income, we must only count bookings using credit card
					int creditPaymentCount = db.Transactions.Where(t => t.FlightNumber == f.FlightNumber).Where(t=>t.PaymentType == (byte)PaymentType.Credit).Count();

					string[] entry = {
						f.FlightNumber.ToString(),
						cityList[f.Route.OriginCityID].Code + " - " + cityList[f.Route.OriginCityID].Name,
						cityList[f.Route.DestinationCityID].Code + " - " + cityList[f.Route.DestinationCityID].Name,
						f.FlightDate.Add(f.Route.DepartureTime.TimeOfDay).ToString(),
						f.FlightDate.Add(f.Route.ArrivalTime.TimeOfDay).ToString(),
						f.CurrentPassengers.ToString(),
						f.MaxPassengers.ToString(),
						Math.Round((Convert.ToDouble(f.CurrentPassengers) / f.MaxPassengers *100), 2).ToString() +"%",
						"$" + f.Route.TicketPrice,
						creditPaymentCount.ToString(),
						"$" + (f.Route.TicketPrice * creditPaymentCount)
					};
					totalFlights++;
					totalPassengers += f.CurrentPassengers;
					totalCapacity += f.MaxPassengers;
					totalIncome += f.Route.TicketPrice * creditPaymentCount;


					ListViewItem lvi = new ListViewItem(entry);
					listViewFlights.Items.Add(lvi);
				}

				labelFlights.Text = listViewFlights.Items.Count.ToString();
				labelBooked.Text = totalPassengers.ToString();
				labelCapacity.Text = totalCapacity.ToString();
				labelPercent.Text = Math.Round((Convert.ToDouble(totalPassengers) / totalCapacity * 100), 2).ToString() + "%";
				labelIncome.Text = "$" + totalIncome;
			}
		}

		private void labelFlights_Click(object sender, EventArgs e)
		{

		}
	}
}
