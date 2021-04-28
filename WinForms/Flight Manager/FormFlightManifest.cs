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
	public partial class FormFlightManifest : Form
	{
		private int flightNumber;
		public FormFlightManifest(int flightNum)
		{
			InitializeComponent();
			flightNumber = flightNum;
		}

		private void FormFlightManifest_Load(object sender, EventArgs e)
		{
			labelFlightNumHere.Text = flightNumber.ToString();

			using (var db = new CovidAirlinesEntities())
			{
				var flight = db.Flights.Where(f => f.FlightNumber == flightNumber).FirstOrDefault();
				DateTime departureDate = flight.FlightDate.Date.Add(flight.Route.DepartureTime.TimeOfDay);
				labelDateHere.Text = departureDate.ToString("MM/dd/yyyy h:mm tt");
				
				//Get every transaction with the matching flight number and of those who have boarded
				var transactions = db.Transactions.Where(f => f.FlightNumber == flightNumber).Where(t => t.StatusType == (byte)StatusType.Boarded).ToList();
				labelPassengerHere.Text = transactions.Count + "/" + flight.CurrentPassengers;
				foreach (Transaction t in transactions)
				{
					string[] entry = {
						t.UserID.ToString(),
						t.User.FullName.ToString()
					};
					ListViewItem lvi = new ListViewItem(entry);
					listViewPassengers.Items.Add(lvi);
				}
			}
		}
	}
}
