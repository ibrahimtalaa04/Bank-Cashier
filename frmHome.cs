using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Cashier.Model;

namespace Bank_Cashier
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblCountAll.Text = "The number of all acounts in the system is " + Program.AppDB.DB.Count;
            lblCountSaving.Text = $"The number of Saving acounts in the system is {Program.AppDB.CountSaving()}";
            lblCountChecking.Text = $"The number of Checking acounts in the system is { Program.AppDB.CountChecking()}";
            lblCountRate.Text = $"The rate in Saving Accounts is {SavingAccount.interestrate}";
        }
    }
}
