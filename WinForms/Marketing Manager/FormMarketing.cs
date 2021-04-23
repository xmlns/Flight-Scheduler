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
	public partial class FormMarketing : Form
	{
		public FormMarketing()
		{
			InitializeComponent();
		}

		private void FormMarketing_Load(object sender, EventArgs e)
		{
			buttonUpdate.Enabled = false;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{

		}

		private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewSchedule.SelectedItems.Count > 0)
			{
				if (comboBoxPlanes.SelectedIndex != -1)
				{
					buttonUpdate.Enabled = true;
				}
				
			}
			else
			{
				buttonUpdate.Enabled = false;
			}
		}

		private void buttonDummy_Click(object sender, EventArgs e)
		{
			string[] entry = {"1",
				"Denver, CO (DEN)",
				"Austin, TX (AUS)",
				"12:00pm",
				"2:15pm",
				"NONE",
				"N/A",
				"NONE",
				"N/A",
				"737",
				"$100",
				"100"
			};
			Random rnd = new Random();
			entry[0] = rnd.Next(99).ToString();  // creates a number between 1 and 12
			ListViewItem lvi = new ListViewItem(entry);
			listViewSchedule.Items.Add(lvi);
		}

		private void comboBoxPlanes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewSchedule.SelectedItems.Count > 0)
			{
				if (comboBoxPlanes.SelectedIndex != -1)
				{
					buttonUpdate.Enabled = true;
				}

			}
			else
			{
				buttonUpdate.Enabled = false;
			}
		}
	}
}
