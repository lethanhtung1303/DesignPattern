using System;
using System.Windows.Forms;

namespace quanlyxekhach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new ManageCustomer());
            //Application.Run(new ManageEmployee());
            //Application.Run(new ManageInfoTrip());
            //Application.Run(new AccountManagement());
            //Application.Run(new ManageTicket());
        }
    }
}