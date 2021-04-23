using System;
using System.Windows.Forms;

namespace CovidAirlines
{
	public partial class FormCustomer : Form
	{
		public FormCustomer()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;

			String[] CITIES = {
				"Seattle, WA (SEA)",
				"San Francisco, CA (SFO)",
				"Los Angles, CA (LAX)",
				"Bismarck, ND (BIS)",
				"Denver, CO (DEN)",
				"Austin, TX (AUS)",
				"Cleveland, OH (CLE)",
				"Nashville, TN (BNA)",
				"Orlando, FL (MCO)",
				"Augusta, ME (AUG)"
			};

			//Populate city choices
			comboBoxOrigin.Items.AddRange(CITIES);
			comboBoxDestination.Items.AddRange(CITIES);

			//Set min(tomorrow) and max (6 months out) dates
			dateTimePickerDepart.Value = dateTimePickerDepart.MinDate = DateTime.Today.AddDays(1);
			dateTimePickerDepart.MaxDate = dateTimePickerDepart.MinDate.AddMonths(6);
			//Set return date picker to the same values
			dateTimePickerReturn.Value = dateTimePickerReturn.MinDate = dateTimePickerDepart.Value.AddDays(1);//cannot return same day
			dateTimePickerReturn.MaxDate = dateTimePickerDepart.MaxDate;

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
				textBoxSelected.Text = flight.Text;
				
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
			/*
			FormBookDepartFlight fBookDepartFlight = new FormBookDepartFlight();
			fBookDepartFlight.MdiParent = this;
			fBookDepartFlight.BringToFront();
			tabControlMenu.SendToBack();

			fBookDepartFlight.Show();
			*/
			
			FormBookDepartFlight fBookDepartFlight = new FormBookDepartFlight();
			
			
			fBookDepartFlight.Show();
			
		}

		private void buttonBoardingPass_Click(object sender, EventArgs e)
		{
			FormBoardingPass fBoardingPass = new FormBoardingPass();
			fBoardingPass.ShowDialog();
		}

		private void tabPageBook_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePickerReturn_ValueChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxOrigin_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
