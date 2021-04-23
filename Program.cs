using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidAirlines
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        static void AddCities()
        {
            using (var entities = new CovidAirlinesEntities())
            { 
                
            }
        }
        static void AddRoutes()
        {
            using (var entities = new CovidAirlinesEntities())
            {

            }
        }
    }
}
