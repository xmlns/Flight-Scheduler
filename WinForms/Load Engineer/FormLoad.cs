using System;
using System.Linq;
using System.Windows.Forms;

namespace CovidAirlines
{
    public partial class FormLoad : Form
	{
		public FormLoad()
		{
			InitializeComponent();
			LoadTable();
		}

		private void FormLoad_Load(object sender, EventArgs e)
		{
			using (var entities = new CovidAirlinesEntities())
			{
				var all = entities.Routes.ToList();
			}
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			FormLoadAdd fFormLoadAdd = new FormLoadAdd();
			fFormLoadAdd.ShowDialog();
			LoadTable();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			string message = "Are you sure you want to delete this route? This cannot be undone.";
			string title = "Delete Route";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons);
			if (result == DialogResult.Yes)
			{
				//int selectedRouteID = int.Parse(dataGridViewRoutes.SelectedRows[0].Cells[0].ToString());//get ID of selected route
				int selectedRouteID = int.Parse(listViewRoutes.SelectedItems[0].Text);//get ID of selected route

				using (var db = new CovidAirlinesEntities())
				{
					var selectedRoute = db.Routes.Where(r => r.RouteID == selectedRouteID).FirstOrDefault();
					db.Routes.Remove(selectedRoute);
					db.SaveChanges();
				}
				LoadTable();
			}
		}

		private void LoadTable()
		{
			using (var db = new CovidAirlinesEntities())
			{
				//Get cities to match CityIDs
				var cityList = db.Cities.ToList();//used to convert indices to corresponding names
				City nullCity = new City
				{
					Name = "-",
					Code = "-"
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
						cityList[r.Stop1CityID.GetValueOrDefault()].Code + " - " + cityList[r.Stop1CityID.GetValueOrDefault()].Name,
						r.Stop1ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop1DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
						cityList[r.Stop2CityID.GetValueOrDefault()].Code + " - " + cityList[r.Stop2CityID.GetValueOrDefault()].Name,
						r.Stop2ArrivalTime.GetValueOrDefault().TimeOfDay.ToString(),
						r.Stop2DepartureTime.GetValueOrDefault().TimeOfDay.ToString(),
					};

					//Clear Stop1 info if needed
					if (r.Stop1CityID == null)
					{
						entry[5] = "-";
						entry[6] = "-";
						entry[7] = "-";
					}
					//Populate Stop1 info if needed
					if (r.Stop2CityID == null)
					{
						entry[8] = "-";
						entry[9] = "-";
						entry[10] = "-";
					}

					ListViewItem lvi = new ListViewItem(entry);
					listViewRoutes.Items.Add(lvi);
				}
			}
		}

		private void listViewRoutes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRoutes.SelectedItems.Count > 0) buttonDelete.Enabled = true;
			else buttonDelete.Enabled = false;
		}

		private void FormLoad_Load_1(object sender, EventArgs e)
		{

		}
	}
}
