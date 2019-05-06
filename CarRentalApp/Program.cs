using System;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.View.Forms;

namespace CarRentalApp
{
    internal static class Program
    {
        public static User CurrentUser { get; set; }
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFom());
        }
    }
}
