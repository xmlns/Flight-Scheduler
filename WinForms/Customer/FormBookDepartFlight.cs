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
	public partial class FormBookDepartFlight : Form
	{
		public FormBookDepartFlight()
		{
			InitializeComponent();
		}

		private void FormBookFlight_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'covidAirlinesDataSetRoutes.Route' table. You can move, or remove it, as needed.
			this.routeTableAdapter.Fill(this.covidAirlinesDataSetRoutes.Route);
			buttonChooseFlight.Enabled = false;

			using (var db = new CovidAirlinesEntities())
			{
				var flights = db.Routes.Where(r => r.OriginCityID == 1);
				
				

			}
		}

		private void button1_Click(object sender, EventArgs e)
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

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewHistory.SelectedItems.Count > 0)
			{
				buttonChooseFlight.Enabled = true;

			}
			else
			{
				buttonChooseFlight.Enabled = false;
			}
		}

		private void buttonChooseFlight_Click(object sender, EventArgs e)
		{
			FormBookReturnFlight fBookReturnFlight = new FormBookReturnFlight();

			fBookReturnFlight.MdiParent = this.MdiParent;
			//this.MdiParent
			fBookReturnFlight.BringToFront();
			fBookReturnFlight.Show();

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.
		}
	}
}
