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
	public partial class FormBoardingPass : Form
	{
		public FormBoardingPass(int userID, int flightNumber)
		{
			InitializeComponent();

			using (var db = new CovidAirlinesEntities())
			{
				//Update status to 'Boarded'
				var transaction = db.Transactions.Where(t => t.FlightNumber == flightNumber).Where(t => t.UserID == userID).FirstOrDefault();
				transaction.StatusType = (byte)StatusType.Boarded;
				db.SaveChanges();
				
				//get database entries
				var passenger = db.Users.Where(u => u.UserID == userID).FirstOrDefault();
				var flight = db.Flights.Where(f => f.FlightNumber == flightNumber).FirstOrDefault();
				var cityList = db.Cities.ToList();

				City nullCity = new City
				{
					Name = "-",
					Code = "-"
				};
				//Pushes cities up one to correct index AND now null values (for no stops) will pull from this entry in list
				cityList.Insert(0, nullCity);

				//Populate User Info
				labelName.Text = passenger.FullName;
				labelAcctNumber.Text = passenger.UserID.ToString();

				//Populate Main trip info
				labelFlightNum.Text = flight.FlightNumber.ToString();
				labelOrigin.Text = cityList[flight.Route.OriginCityID].Code + " - " + cityList[flight.Route.OriginCityID].Name;
				labelDestination.Text = cityList[flight.Route.DestinationCityID].Code + " - " + cityList[flight.Route.DestinationCityID].Name;

				labelDepart.Text = flight.FlightDate.Add(flight.Route.DepartureTime.TimeOfDay).ToString();
				labelArrive.Text = flight.FlightDate.Add(flight.Route.ArrivalTime.TimeOfDay).ToString();

				//Populate Stop1 info if exists
				if (flight.Route.Stop1CityID != null)
				{
					labelConnectionHeader.Show();

					labelStop1.Text = cityList[flight.Route.Stop1CityID.Value].Code + " - " + cityList[flight.Route.Stop1CityID.Value].Name;
					labelStop1.Show();

					labelStop1Arrive.Text = flight.FlightDate.Add(flight.Route.Stop1ArrivalTime.Value.TimeOfDay).ToString();
					labelStop1Arrive.Show();

					labelStop1Depart.Text = flight.FlightDate.Add(flight.Route.Stop1DepartureTime.Value.TimeOfDay).ToString();
					labelStop1Depart.Show();

				}
				
				//Populate Stop2 info if exists
				if (flight.Route.Stop2CityID != null)
				{
					labelConnectionHeader.Show();

					labelStop2.Text = cityList[flight.Route.Stop2CityID.Value].Code + " - " + cityList[flight.Route.Stop2CityID.Value].Name;
					labelStop2.Show();

					labelStop2Arrive.Text = flight.FlightDate.Add(flight.Route.Stop2ArrivalTime.Value.TimeOfDay).ToString();
					labelStop2Arrive.Show();

					labelStop2Depart.Text = flight.FlightDate.Add(flight.Route.Stop2DepartureTime.Value.TimeOfDay).ToString();
					labelStop2Depart.Show();

				}

			}

		}

		private void FormBoardingPass_Load(object sender, EventArgs e)
		{

		}
	}
}
