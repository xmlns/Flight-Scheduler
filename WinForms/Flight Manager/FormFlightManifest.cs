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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FormFlightManifest_Load(object sender, EventArgs e)
		{

		}
	}
}
