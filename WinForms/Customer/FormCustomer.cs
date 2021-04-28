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
			listViewHistory.Items.Clear();
			using (var entities = new CovidAirlinesEntities())
			{
				var cities = entities.Cities.ToArray();
				var histories = entities.Transactions.Where(x => x.UserID == CUSTOMER.UserID)
					.Join(entities.Routes, t => t.RouteID, r => r.RouteID, (t, r) => new {t, r})
						.Join(entities.Flights, x => x.t.FlightNumber, f => f.FlightNumber, (x, f) => new { x, f })
							.AsEnumerable()
							.Select(y => new 
								{
									y.x.t.StatusType,
									y.x.r.TicketPrice,
									y.x.t.FlightNumber,
									y.x.t.PaymentType,
									y.x.r.PointsAwarded,
									y.x.r.OriginCityID,
									y.x.r.DestinationCityID,
									DepartureDateTime = $"{y.f.FlightDate.ToShortDateString()} {y.x.r.DepartureTime.TimeOfDay}",
									ArrivalDateTime = $"{y.f.FlightDate.ToShortDateString()} {y.x.r.ArrivalTime.TimeOfDay}",
									y.x.r.Stop1CityID,
									y.x.r.Stop1DepartureTime,
									y.x.r.Stop2CityID,
									y.x.r.Stop2DepartureTime
								});

				const string BLANK = "-";
				foreach (var history in histories)
				{
					var flightDate = entities.Flights.Find(history.FlightNumber).FlightDate;
					string[] entry = {
						history.FlightNumber.ToString(),
						entities.Cities.Find(history.OriginCityID).Code,
						entities.Cities.Find(history.DestinationCityID).Code,
						history.DepartureDateTime,
						history.ArrivalDateTime,
						history.Stop1CityID == null ? BLANK : entities.Cities.Find(history.Stop1CityID).Code,
						history.Stop1DepartureTime == null ? BLANK : history.Stop1DepartureTime.ToString(),
						history.Stop2CityID == null ? BLANK : entities.Cities.Find(history.Stop2CityID).Code,
						history.Stop2DepartureTime == null ? BLANK : history.Stop2DepartureTime.ToString(),
						Enum.Parse(typeof(StatusType), history.StatusType.ToString()).ToString(),
						history.TicketPrice.ToString()
					};

					listViewHistory.Items.Add(new ListViewItem(entry));
				}
			}
		}

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			//check if a flight is selected not cancelled (that leaves active or already printed)
			if (listViewHistory.SelectedItems.Count > 0)
			{
				var selectedFlightTime = DateTime.Parse(listViewHistory.SelectedItems[0].SubItems[3].Text);//get time of flight departure
				DateTime currentTime = DateTime.Now;//time must be within 24hrs
				DateTime printable = selectedFlightTime.AddHours(-24);//time must be within 24hrs
				
				if (currentTime >= printable && !string.Equals(listViewHistory.SelectedItems[0].SubItems[9].Text, "Cancelled"))	
					buttonBoardingPass.Enabled = true;
				else							
					buttonBoardingPass.Enabled = false;


				DateTime cancellable = selectedFlightTime.AddHours(-1);//time must be before the -1hr mark
				if (currentTime >= cancellable || !string.Equals(listViewHistory.SelectedItems[0].SubItems[9].Text, "Active"))		
					buttonCancelFlight.Enabled = false;
				else								
					buttonCancelFlight.Enabled = true;

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

			//Refresh UserInfo
			using (var db = new CovidAirlinesEntities())
			{
				CUSTOMER = db.Users.Where(u => u.UserID == CUSTOMER.UserID).FirstOrDefault();
			}

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
				if (departFlightNumber == -1);//do nothing
				else if (radioButtonRoundTrip.Checked == true)
				{//round trip, we need to choose return flight now (selected destination -> selected origin)
					FormChooseFlight fReturnFlight = new FormChooseFlight(comboBoxDestination.SelectedIndex + 1, comboBoxOrigin.SelectedIndex + 1, true);
					var returnResult = fReturnFlight.ShowDialog();

					if (returnResult == DialogResult.OK)//Ensure user didnt cancel
					{
						//Get Return route chosen
						returnRouteID = fReturnFlight.chosenRouteID;
						//Get or create flight that matches return route and date
						returnFlightNumber = ConfirmFlight(int.Parse(returnRouteID), dateTimePickerReturn.Value);
						if (returnFlightNumber != -1)//ensure return flight isnt full
						{
							FormConfirmation fConfirmationRoundTrip = new FormConfirmation(CUSTOMER.UserID, departFlightNumber, returnFlightNumber);
							fConfirmationRoundTrip.ShowDialog();
						}
					}
				}
				else //only move on to confirmation page if depart flight isnt full
				{
					FormConfirmation fConfirmationOneWay = new FormConfirmation(CUSTOMER.UserID, departFlightNumber, returnFlightNumber);
					fConfirmationOneWay.ShowDialog();
				}
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
		//Returns -1 if flight is currently full
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
				else if (flight.CurrentPassengers == flight.MaxPassengers)
				{
					string message = "This flight is currently full! Please choose a different flight.";
					string title = "Flight Full!";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result = MessageBox.Show(message, title, buttons);
					return -1;
				}

				return flight.FlightNumber;
			}
		}

		private void buttonBoardingPass_Click(object sender, EventArgs e)
		{
			//TODO: Boarding Pass functionality, populate flight information and mark status as boarded in transaction table
			buttonBoardingPass.Enabled = false;
			int flightNum = int.Parse(listViewHistory.SelectedItems[0].Text);
			if (string.Equals(listViewHistory.SelectedItems[0].SubItems[9].Text, "Active"))
			{
				using (var db = new CovidAirlinesEntities())
				{
					//Only add reward points to user once
					var customer = db.Users.Where(u => u.UserID == CUSTOMER.UserID).FirstOrDefault();
					customer.PointsAvailable += db.Flights.Where(f => f.FlightNumber == flightNum).FirstOrDefault().Route.PointsAwarded;
					db.SaveChanges();
				}
			}
			FormBoardingPass fBoardingPass = new FormBoardingPass(CUSTOMER.UserID, flightNum);
			fBoardingPass.ShowDialog();
			PopulateFlightHistory();//refresh history table
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
					CUSTOMER = userEntry;//update customer global variable

					textBoxNewPassword.Text = string.Empty;
					textBoxConfirmPassword.Text = string.Empty;

					labelResult.Text = "Account Information Updated.";
					return;
				}


				labelResult.Text = "Error Updating Information.";
			}
			PopulateUserInfo();//refresh info fields
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
			if (tabControlMenu.SelectedTab == tabPageAccount)		PopulateUserInfo();
			else if (tabControlMenu.SelectedTab == tabPageHistory)	PopulateFlightHistory();
		}

		private void PopulateUserInfo()
		{
			//Refresh UserInfo
			using (var db = new CovidAirlinesEntities())
			{
				CUSTOMER = db.Users.Where(u => u.UserID == CUSTOMER.UserID).FirstOrDefault();
			}
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

			labelResult.Text = string.Empty;
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

			using (var entities = new CovidAirlinesEntities())
			{
				foreach (ListViewItem row in selectedItems)
				{
					var flightNumber = int.Parse(row.SubItems[0].Text);
                    var flight = entities.Flights.Find(flightNumber);
                    var route = entities.Routes.Find(flight.RouteID);
					var transaction = entities.Transactions.Where(t => t.FlightNumber == flightNumber).FirstOrDefault();

                    flight.CurrentPassengers--;
                    transaction.StatusType = (byte)StatusType.Cancelled;
					var user = entities.Users.Find(CUSTOMER.UserID);
                    user.PointsAvailable += route.PointsAwarded;
				}
				entities.SaveChanges();
			}
			buttonCancelFlight.Enabled = false;
			PopulateFlightHistory();//refresh table
		}
	}
}
