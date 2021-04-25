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
	public partial class FormConfirmation : Form
	{
		static int USERID, DEPART_FLIGHTNUMBER, RETURN_FLIGHTNUMBER;

		List<City> cityList;

		public FormConfirmation(int userid, int departNumber, int returnNumber)
		{
			InitializeComponent();

			//Initialize global variables
			USERID = userid;
			DEPART_FLIGHTNUMBER = departNumber;
			RETURN_FLIGHTNUMBER = returnNumber;
			//get list of all cities
			using (var db = new CovidAirlinesEntities())
			{
				cityList = db.Cities.ToList();
				var customer = db.Users.Where(u => u.UserID == USERID).FirstOrDefault();
				labelName.Text = customer.FullName;
				labelAcctNumber.Text = USERID.ToString();
			}
		}

		private void FormConfirmation_Load(object sender, EventArgs e)
		{
			PopulateDepartureFlightInfo();
			if (RETURN_FLIGHTNUMBER != -1) PopulateReturnFlightInfo();

			decimal totalCost = decimal.Parse(labelCostDepart.Text) + decimal.Parse(labelCostReturn.Text);
			labelTotalCost.Text = totalCost.ToString();
			labelTotalPoints.Text = (totalCost*100).ToString();
		}

		private void PopulateDepartureFlightInfo()
		{
			labelDFlightNum.Text = DEPART_FLIGHTNUMBER.ToString();
			using (var db = new CovidAirlinesEntities())
			{
				//Get depart flight from database
				var departureFlight = db.Flights.Where(f => f.FlightNumber == DEPART_FLIGHTNUMBER).FirstOrDefault();

				if (departureFlight != null)//safety net, should always be created in FormCustomer is originally DNE
				{
					//Get depart route from database
					//var departureRoute = db.Routes.Where(r => r.RouteID == departureFlight.RouteID).FirstOrDefault();
					var departureRoute = departureFlight.Route;

					labelCostDepart.Text = departureFlight.Route.TicketPrice.ToString();

					labelDOrigin.Text = cityList[departureRoute.OriginCityID].Code + " - " + cityList[departureRoute.OriginCityID].Name;
					labelDDestination.Text = cityList[departureRoute.DestinationCityID].Code + " - " + cityList[departureRoute.DestinationCityID].Name;

					labelDDepart.Text = departureFlight.FlightDate.Date.Add(departureRoute.DepartureTime.TimeOfDay).ToString();
					labelDArrive.Text = departureFlight.FlightDate.Date.Add(departureRoute.ArrivalTime.TimeOfDay).ToString();

					if (departureRoute.Stop1CityID != null)
					{
						int stop1ID = departureRoute.Stop1CityID.Value;
						labelDStop1.Text = cityList[stop1ID].Code + " - " + cityList[stop1ID].Name;
						labelDStop1Arrive.Text = departureFlight.FlightDate.Date.Add(departureRoute.Stop1ArrivalTime.Value.TimeOfDay).ToString();
						labelDStop1Depart.Text = departureFlight.FlightDate.Date.Add(departureRoute.Stop1DepartureTime.Value.TimeOfDay).ToString();

						labelDStop1.Show();
						labelDStop1Arrive.Show();
						labelDStop1Depart.Show();

						if (departureRoute.Stop2CityID != null)
						{
							int stop2ID = departureRoute.Stop2CityID.Value;
							labelDStop2.Text = cityList[stop2ID].Code + " - " + cityList[stop2ID].Name;
							labelDStop2Arrive.Text = departureFlight.FlightDate.Date.Add(departureRoute.Stop2ArrivalTime.Value.TimeOfDay).ToString();
							labelDStop2Depart.Text = departureFlight.FlightDate.Date.Add(departureRoute.Stop2DepartureTime.Value.TimeOfDay).ToString();

							labelDStop2.Show();
							labelDStop2Arrive.Show();
							labelDStop2Depart.Show();
						}
					}
				}
			}
		}

		private void PopulateReturnFlightInfo()
		{
			labelRFlightNum.Text = RETURN_FLIGHTNUMBER.ToString();
			using (var db = new CovidAirlinesEntities())
			{
				//Get flight from database
				var returnFlight = db.Flights.Where(f => f.FlightNumber == RETURN_FLIGHTNUMBER).FirstOrDefault();

				if (returnFlight != null)//safety net, should always be created in FormCustomer is originally DNE
				{
					//Get depart route from database
					var returnRoute = db.Routes.Where(r => r.RouteID == returnFlight.RouteID).FirstOrDefault();

					labelCostReturn.Text = returnFlight.Route.TicketPrice.ToString();

					labelROrigin.Text = cityList[returnRoute.OriginCityID].Code + " - " + cityList[returnRoute.OriginCityID].Name;
					labelRDestination.Text = cityList[returnRoute.DestinationCityID].Code + " - " + cityList[returnRoute.DestinationCityID].Name;

					labelRDepart.Text = returnFlight.FlightDate.Date.Add(returnRoute.DepartureTime.TimeOfDay).ToString();
					labelRArrive.Text = returnFlight.FlightDate.Date.Add(returnRoute.ArrivalTime.TimeOfDay).ToString();

					if (returnRoute.Stop1CityID != null)
					{
						int stop1ID = returnRoute.Stop1CityID.Value;
						labelRStop1.Text = cityList[stop1ID].Code + " - " + cityList[stop1ID].Name;
						labelRStop1Arrive.Text = returnFlight.FlightDate.Date.Add(returnRoute.Stop1ArrivalTime.Value.TimeOfDay).ToString();
						labelRStop1Depart.Text = returnFlight.FlightDate.Date.Add(returnRoute.Stop1DepartureTime.Value.TimeOfDay).ToString();

						labelRStop1.Show();
						labelRStop1Arrive.Show();
						labelRStop1Depart.Show();

						if (returnRoute.Stop2CityID != null)
						{
							int stop2ID = returnRoute.Stop2CityID.Value;
							labelRStop2.Text = cityList[stop2ID].Code + " - " + cityList[stop2ID].Name;
							labelRStop2Arrive.Text = returnFlight.FlightDate.Date.Add(returnRoute.Stop2ArrivalTime.Value.TimeOfDay).ToString();
							labelRStop2Depart.Text = returnFlight.FlightDate.Date.Add(returnRoute.Stop2DepartureTime.Value.TimeOfDay).ToString();

							labelRStop2.Show();
							labelRStop2Arrive.Show();
							labelRStop2Depart.Show();
						}
					}
				}
			}

			//Show return trip components for return flight
			groupBoxReturnFlight.Show();
			labelCostReturn.Show();
			labelCostReturn1.Show();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonOrder_Click(object sender, EventArgs e)
		{
			
			ProcessTransactions();

			this.Close();
		}

		private void ProcessTransactions()
		{
			PaymentType paymentMethod = radioButtonCredit.Checked ? PaymentType.Credit : PaymentType.Points;

			using (var db = new CovidAirlinesEntities())
			{
				//Get Flight and increment passenger count in Flights table
				var departFlight = db.Flights.Where(f => f.FlightNumber == DEPART_FLIGHTNUMBER).FirstOrDefault();

				if (departFlight.CurrentPassengers == departFlight.MaxPassengers)
				{
					MessageBox.Show("Sorry flight " + departFlight.FlightNumber + " is currently fulled!");
					return;
				}

				departFlight.CurrentPassengers++;

				//Add new entry to Transaction table
				Transaction departTransaction = new Transaction
				{
					FlightNumber = departFlight.FlightNumber,
					RouteID = departFlight.RouteID,
					Date = departFlight.FlightDate,
					PaymentType = (byte)paymentMethod,
					UserID = USERID,
					StatusType = (byte)StatusType.Active
				};

				db.Transactions.Add(departTransaction);

				if (RETURN_FLIGHTNUMBER != -1)
				{
					var returnFlight = db.Flights.Where(f => f.FlightNumber == RETURN_FLIGHTNUMBER).FirstOrDefault();

					if (returnFlight.CurrentPassengers == returnFlight.MaxPassengers)
					{
						MessageBox.Show("Sorry flight " + returnFlight.FlightNumber + " is currently fulled!");
						return;
					}

					returnFlight.CurrentPassengers++;
					//Add new entry to Transaction table
					Transaction returnTransaction = new Transaction
					{
						FlightNumber = returnFlight.FlightNumber,
						RouteID = returnFlight.RouteID,
						Date = returnFlight.FlightDate,
						PaymentType = (byte)paymentMethod,
						UserID = USERID,
						StatusType = (byte)StatusType.Active
					};

					db.Transactions.Add(returnTransaction);
					
				}

				db.SaveChanges();//Save all changes before existing
			}

		}
	}
}
