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
	public partial class FormBookReturnFlight : Form
	{
		public FormBookReturnFlight()
		{
			InitializeComponent();
		}

		private void FormBookFlight_Load(object sender, EventArgs e)
		{
			buttonChooseFlight.Enabled = false;

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

		private void buttonCancel_Click(object sender, EventArgs e)
		{

		}
	}
}
