using System;
using System.Windows.Forms;

using System.Linq;
//using CovidAirlines.Enums;

namespace CovidAirlines
{
	public partial class FormCustomer : Form
	{
		private User CUSTOMER;//Logged in customer
		public FormCustomer(User c)
		{
			InitializeComponent();
			CUSTOMER = c;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'covidAirlinesDataSet1.Transaction' table. You can move, or remove it, as needed.
			this.transactionTableAdapter.Fill(this.covidAirlinesDataSet1.Transaction);
			// TODO: This line of code loads data into the 'covidAirlinesCities.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter.Fill(this.covidAirlinesCities.City);
			// TODO: This line of code loads data into the 'covidAirlinesDataSet.City' table. You can move, or remove it, as needed.
			//this.cityTableAdapter.Fill(this.covidAirlinesDataSet.City);
			// TODO: This line of code loads data into the 'covidAirlinesDataSet.City' table. You can move, or remove it, as needed.
			//this.cityTableAdapter.Fill(this.covidAirlinesDataSet.City);
			/*
			this.WindowState = FormWindowState.Maximized;
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
			*/

			//Populate city choices
			using (var entities = new CovidAirlinesEntities())
			{
				var cityList = entities.Cities.ToList();
				foreach (City c in cityList)
				{
					comboBoxOrigin.Items.Add(c.Code + " - " + c.Name);
					comboBoxDestination.Items.Add(c.Code + " - " + c.Name);
				}
			}

			//Fill Expiry Month Combo box
			for (int i = 1; i <= 12; i++)
			{
				comboBoxMonth.Items.Add(i.ToString());
			}
			//Fill Expiry Year Combo box
			for (int i = 2021; i <= 2099; i++)
			{
				comboBoxYear.Items.Add(i.ToString());
			}

			//Set min(tomorrow) and max (6 months out) dates
			dateTimePickerDepart.Value = dateTimePickerDepart.MinDate = DateTime.Today.AddDays(1);
			dateTimePickerDepart.MaxDate = dateTimePickerDepart.MinDate.AddMonths(6);
			//Set return date picker to the same values
			dateTimePickerReturn.Value = dateTimePickerReturn.MinDate = dateTimePickerDepart.Value.AddDays(1);//cannot return same day
			dateTimePickerReturn.MaxDate = dateTimePickerDepart.MaxDate;

			//Populate User Info
			PopulateUserInfo();
			PopulateFlightHistory();
		}

        private void PopulateFlightHistory()
		{

			using (var entities = new CovidAirlinesEntities())
			{
				const string BLANK = "-";
				var histories = entities.Transactions.Where(x => x.UserID == CUSTOMER.UserID).Join(entities.Routes, t => t.RouteID, r => r.RouteID,
								(t, r) =>
								new {
									t.StatusType,
									r.TicketPrice,
									t.FlightNumber,
									t.PaymentType,
									r.PointsAwarded,
									r.OriginCityID,
									r.DestinationCityID,
									r.DepartureTime,
									r.ArrivalTime,
									Stop1CityID = r.Stop1CityID == null ? BLANK : r.Stop1CityID.ToString(),
									Stop1DepartureTime = r.Stop1DepartureTime == null ? BLANK : r.Stop1DepartureTime.ToString(),
									Stop2CityID = r.Stop2CityID == null ? BLANK : r.Stop2CityID.ToString(),
									Stop2DepartureTime = r.Stop2DepartureTime == null ? BLANK : r.Stop2DepartureTime.ToString()
								});
				foreach (var history in histories)
				{
					string[] entry = {
						history.FlightNumber.ToString(),
						entities.Cities.Find(history.OriginCityID).Code,
						entities.Cities.Find(history.DestinationCityID).Code,
						history.DepartureTime.TimeOfDay.ToString(),
						history.ArrivalTime.TimeOfDay.ToString(),
						history.Stop1CityID,
						history.Stop1DepartureTime,
						history.Stop2CityID,
						history.Stop2DepartureTime,
						Enum.Parse(typeof(StatusType), history.StatusType.ToString()).ToString(),
						history.TicketPrice.ToString()
					};

					listViewHistory.Items.Add(new ListViewItem(entry));
				}
			}
		}

        private void button1_Click(object sender, EventArgs e)
		{
			string[] entry = {"123",
				"Denver, CO (DEN)",
				"Austin, TX (AUS)",
				DateTime.Now.ToString(),
				"2:15pm",
				"NONE",
				"N/A",
				"NONE",
				"N/A",
				"Active/Cancelled",
				"$100"
			};
			Random rnd = new Random();
			entry[0] = rnd.Next(999).ToString();  // creates a number between 1 and 999
			ListViewItem lvi = new ListViewItem(entry);
			listViewHistory.Items.Add(lvi);
		}

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewHistory.SelectedItems.Count > 0)
			{
				var selectedFlightTime = DateTime.Parse(listViewHistory.SelectedItems[0].SubItems[3].Text);//get time of flight departure
				DateTime currentTime = DateTime.Now;//time must be within 24hrs
				DateTime printable = selectedFlightTime.AddHours(-24);//time must be within 24hrs
				
				if (currentTime >= printable)	buttonBoardingPass.Enabled = true;
				else							buttonBoardingPass.Enabled = false;


				DateTime cancellable = selectedFlightTime.AddHours(-1);//time must be before the -1hr mark
				if (currentTime >= cancellable)		buttonCancelFlight.Enabled = false;
				else								buttonCancelFlight.Enabled = true;

			}
			else
			{
				buttonCancelFlight.Enabled = false;
				buttonBoardingPass.Enabled = false;
			}
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerReturn.Enabled = radioButtonRoundTrip.Checked;
			dateTimePickerReturn.Value = dateTimePickerDepart.Value.AddDays(1);

		}

		private void buttonSignout_Click(object sender, EventArgs e)
		{
			this.Close();			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listViewHistory.SelectedItems.Count > 0)
			{
				var flight = listViewHistory.SelectedItems[0];
				//rest of your logic
				//textBoxSelected.Text = flight.Text;
				
			}
		}

		private void buttonOneWeek_Click(object sender, EventArgs e)
		{
			string[] entry = {"123",
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
			listViewHistory.Items.Add(lvi);
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			//Check if origin city is empty
			if (string.IsNullOrWhiteSpace(comboBoxOrigin.GetItemText(comboBoxOrigin.SelectedItem)))
			{
				labelSearchResponse.Text = "Select an origin city!";
				labelSearchResponse.Visible = true;
				return;
			}
			//Check if destination city is empty
			if (string.IsNullOrWhiteSpace(comboBoxDestination.GetItemText(comboBoxDestination.SelectedItem)))
			{
				labelSearchResponse.Text = "Select a destination city!";
				labelSearchResponse.Visible = true;
				return;
			}
			//Make sure origin and destination are distinct
			if (comboBoxOrigin.GetItemText(comboBoxOrigin.SelectedItem) == comboBoxDestination.GetItemText(comboBoxDestination.SelectedItem))
			{
				labelSearchResponse.Text = "Origin and Destination locations must be different!";
				labelSearchResponse.Visible = true;
				return;
			}
			//Make sure return date is after departure date if round trip is selected
			if (radioButtonRoundTrip.Checked && (dateTimePickerDepart.Value >= dateTimePickerReturn.Value))
			{
				labelSearchResponse.Text = "Return date must be after departure date!";
				labelSearchResponse.Visible = true;
				return;
			}

			labelSearchResponse.Text = "Searching...";
			labelSearchResponse.Visible = true;

			BookFlightFormLogic();
			
		}

		private void BookFlightFormLogic()
		{
			this.Hide();
			//Always go to book depart flight first (selected origin -> selected destination)
			//combo box are zero-indexed
			FormChooseFlight fDepartFlight = new FormChooseFlight(comboBoxOrigin.SelectedIndex+1, comboBoxDestination.SelectedIndex+1, false);
			var departResult = fDepartFlight.ShowDialog();
			
			string departRouteID, returnRouteID;
			departRouteID = returnRouteID = string.Empty;

			if (departResult == DialogResult.OK)
			{
				//Get Depart route chosen
				departRouteID = fDepartFlight.chosenRouteID;

				int departFlightNumber, returnFlightNumber = -1;

				//Get or create flight that matches depart route and date
				departFlightNumber = ConfirmFlight(int.Parse(departRouteID), dateTimePickerDepart.Value);

				if (radioButtonRoundTrip.Checked == true)
				{//round trip, we need to choose return flight now (selected destination -> selected origin)
					FormChooseFlight fReturnFlight = new FormChooseFlight(comboBoxDestination.SelectedIndex+1, comboBoxOrigin.SelectedIndex+1, true);
					var returnResult = fReturnFlight.ShowDialog();

					if (returnResult == DialogResult.Cancel) return;//dont continue

					//Get Return route chosen
					returnRouteID = fReturnFlight.chosenRouteID;
					//Get or create flight that matches return route and date
					returnFlightNumber = ConfirmFlight(int.Parse(returnRouteID), dateTimePickerReturn.Value);
				}
				FormConfirmation fConfirmation = new FormConfirmation(CUSTOMER.UserID, departFlightNumber, returnFlightNumber);
				fConfirmation.ShowDialog();
			}

			//Clear old search criteria
			comboBoxOrigin.SelectedIndex = -1;
			comboBoxDestination.SelectedIndex = -1;
			radioButtonOneway.Checked = true;
			dateTimePickerDepart.Value = DateTime.Today.AddDays(1);
			labelSearchResponse.Hide();

			this.Show();

		}

		//This method will search Flights database to see if the chosen route and time already has flight created
		//If this is the first booking of the inputted route and date, it will create a new flight in the database
		//Will return FlightNumber of new or preexisting flight
		private int ConfirmFlight(int routeID, DateTime flightDate)
		{
			using (var db = new CovidAirlinesEntities())
			{
				//First search if flight already exists in Flight Table
				var flight = db.Flights.Where(r => r.RouteID == routeID).Where(d => d.FlightDate == flightDate.Date).FirstOrDefault();

				//Flight Does Not Exist
				if (flight == null || flight.FlightDate < flightDate)
				{
					var route = db.Routes.Where(r => r.RouteID == routeID).FirstOrDefault();
					flight = new Flight
					{
						RouteID = routeID,
						FlightDate = flightDate.Date,
						CurrentPassengers = 0,
						MaxPassengers = route.Airplane.Capacity
					};
					db.Flights.Add(flight);
					db.SaveChanges();
				}

				return flight.FlightNumber;
			}
		}

		private void buttonBoardingPass_Click(object sender, EventArgs e)
		{
			//TODO: Boarding Pass functionality, populate flight information and mark status as boarded in transaction table
			FormBoardingPass fBoardingPass = new FormBoardingPass();
			fBoardingPass.ShowDialog();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			//Grab all inputted information
			string[] acctInfo = new string[12];

			acctInfo[0] = textBoxName.Text;
			acctInfo[1] = textBoxNewPassword.Text;
			acctInfo[2] = textBoxConfirmPassword.Text;
			acctInfo[3] = textBoxAddress.Text;
			acctInfo[4] = textBoxCity.Text;
			acctInfo[5] = textBoxZipcode.Text;
			acctInfo[6] = textBoxNumber.Text;
			acctInfo[7] = numericAge.Value.ToString();
			acctInfo[8] = textBoxCC.Text;
			acctInfo[9] = comboBoxMonth.GetItemText(comboBoxMonth.SelectedItem);
			acctInfo[10] = comboBoxYear.GetItemText(comboBoxYear.SelectedItem);
			acctInfo[11] = textBoxCSV.Text;

			//Ensure all fields are filled
			bool allFieldsFilled = true;
			for (int i = 0; i < acctInfo.Length; i++)
			{
				if (checkBoxPassword.Checked ==false &&( i == 1 || i == 2)) continue; //skip password fields if boxed unchecked
				allFieldsFilled &= !string.IsNullOrWhiteSpace(acctInfo[i]);
			}

			if (!allFieldsFilled)
			{
				labelResult.Text = "All fields are required!";
				labelResult.Visible = true;
				return;
			}

			//Now make sure password and confirmation password match
			if (checkBoxPassword.Checked == true && acctInfo[1] != acctInfo[2])
			{
				labelResult.Text = "Password and confirmation password do not match!";
				labelResult.Visible = true;
				return;
			}
			using (var db = new CovidAirlinesEntities())
			{
				labelResult.Text = "Updating Account Information...";
				labelResult.Visible = true;

				User userEntry = db.Users.Where(u => u.UserID == CUSTOMER.UserID).FirstOrDefault();
				if (userEntry != null)
				{
					userEntry.FullName = acctInfo[0];
					userEntry.Address = acctInfo[3];
					userEntry.City = acctInfo[4];
					userEntry.ZipCode = acctInfo[5];
					userEntry.PhoneNumber = acctInfo[6];
					userEntry.Age = short.Parse(acctInfo[7]);
					userEntry.CardNumber = acctInfo[8];
					userEntry.CardExpiryDate = new DateTime(int.Parse(acctInfo[10]), int.Parse(acctInfo[9]), 1);
					userEntry.CardCVV = short.Parse(acctInfo[11]);
					if (checkBoxPassword.Checked)
					{
						userEntry.PasswordHash = Utility.GenerateHash(acctInfo[1]);
					}
					db.SaveChanges();

					textBoxNewPassword.Text = string.Empty;
					textBoxConfirmPassword.Text = string.Empty;

					labelResult.Text = "Account Information Updated...";
					return;
				}


				labelResult.Text = "Error Updating Information...";
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = checkBoxPassword.Checked;

			textBoxNewPassword.Enabled = enabled;
			textBoxConfirmPassword.Enabled = enabled;

			if (!enabled)
			{
				textBoxNewPassword.Text = string.Empty;
				textBoxConfirmPassword.Text = string.Empty;
			}

		}

		private void tabControlMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControlMenu.SelectedTab == tabPageAccount)	PopulateUserInfo();
		}

		private void PopulateUserInfo()
		{
			//Populate User Info
			labelUserIDHere.Text = CUSTOMER.UserID.ToString();
			labelPointsHere.Text = CUSTOMER.PointsAvailable.ToString();
			labelRedeemedHere.Text = CUSTOMER.PointsRedeemed.ToString();
			textBoxName.Text = CUSTOMER.FullName;
			textBoxAddress.Text = CUSTOMER.Address;
			textBoxCity.Text = CUSTOMER.City;
			textBoxZipcode.Text = CUSTOMER.ZipCode;
			textBoxNumber.Text = CUSTOMER.PhoneNumber;
			numericAge.Value = CUSTOMER.Age;
			textBoxCC.Text = CUSTOMER.CardNumber;
			comboBoxMonth.SelectedIndex = CUSTOMER.CardExpiryDate.Month - 1;
			comboBoxYear.SelectedIndex = CUSTOMER.CardExpiryDate.Year - 2021;
			textBoxCSV.Text = CUSTOMER.CardCVV.ToString();

			textBoxNewPassword.Text = string.Empty;
			textBoxConfirmPassword.Text = string.Empty;
		}

		private void tabPageHistory_Click(object sender, EventArgs e)
		{

		}

		private void transactionBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

        private void buttonCancelFlight_Click(object sender, EventArgs e)
        {
			CancelFlights(listViewHistory.SelectedItems);
		}
		private void CancelFlights(ListView.SelectedListViewItemCollection selectedItems)
		{
			if (selectedItems.Count == 0)
			{
				return;
			}

			/* TO-DO: Iterate over the selected rows, check if the flight departs in 1 hour.
						Decrement passengers, change transaction status to Cancelled, decrement points
			using (var entities = new CovidAirlinesEntities())
			{
				foreach (ListViewItem row in selectedItems)
				{
					var flightNumber = row.SubItems[0];
                    var flight = entities.Flights.Find(flightNumber);
                    var route = entities.Routes.Find(flight.RouteID);
                    var timeDiff = DateTime.UtcNow.TimeOfDay.Subtract(route.DepartureTime.TimeOfDay);

                    if (timeDiff.Hours > 1)
                    {
						//.Text = "Flights can only be cancelled up to an hour before they depart";
                        //labelErrorMessage.Show();
                        return;
                    }

					var transaction = entities.Transactions.Where(t => t.RouteID == flight.RouteID).FirstOrDefault();
                    flight.CurrentPassengers--;
                    transaction.StatusType = (byte)StatusType.Cancelled;
                    CUSTOMER.PointsAvailable -= route.PointsAwarded;
				}
				entities.SaveChanges();
			}
			*/
		}
	}
}
