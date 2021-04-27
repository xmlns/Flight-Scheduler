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
	public partial class FormFlightManager : Form
	{
		public FormFlightManager()
		{
			InitializeComponent();
		}

		private void listViewSchedule_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewSchedule.SelectedItems.Count > 0)
			{
				buttonGenerate.Enabled = true;

			}
			else
			{
				buttonGenerate.Enabled = false;
			}
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			int selectedFlightNum = int.Parse(listViewSchedule.SelectedItems[0].Text);

			FormFlightManifest fManifest = new FormFlightManifest(selectedFlightNum);
		}
	}
}
