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

			this.routeTableAdapter.Fill(this.covidAirlinesDataSet2.Route);
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
				int selectedRouteID = int.Parse(dataGridViewRoutes.SelectedRows[0].Cells[0].Value.ToString());//get ID of selected route

				using (var db = new CovidAirlinesEntities())
				{
					var selectedRoute = db.Routes.Where(r => r.RouteID == selectedRouteID).FirstOrDefault();
					db.Routes.Remove(selectedRoute);
					db.SaveChanges();
				}
				this.routeTableAdapter.Fill(this.covidAirlinesDataSet2.Route);
			}
		}

		private void FormLoad_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'covidAirlinesDataSet2.Route' table. You can move, or remove it, as needed.
			this.routeTableAdapter.Fill(this.covidAirlinesDataSet2.Route);

		}

		private void dataGridViewRoutes_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewRoutes.SelectedRows.Count > 0)	buttonDelete.Enabled = true;
			else											buttonDelete.Enabled = false;
	
		}
	}
}
