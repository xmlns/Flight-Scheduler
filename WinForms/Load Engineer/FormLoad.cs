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
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			string message = "Are you sure you want to delete this route? This cannot be undone.";
			string title = "Delete Route";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons);
			if (result == DialogResult.Yes)
			{
				// TODO - Delete route from database 
			}

			//this.Close();
		}

		private void FormLoad_Load_1(object sender, EventArgs e)
		{

		}
	}
}
