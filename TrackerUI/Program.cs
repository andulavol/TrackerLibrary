using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrackerUI
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

            //Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections();
            Application.Run(new CreatePrizeForm());
        }
    }
}
