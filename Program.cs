using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Cashier.Data_base;

namespace Bank_Cashier
{
    internal static class Program
    {
        public static Database AppDB = new Database();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDesktop());
        }
    }
}
