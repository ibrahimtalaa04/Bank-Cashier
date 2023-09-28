using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bank_Cashier
{
    public partial class frmUpdateRate : Form
    {
        public frmUpdateRate()
        {
            InitializeComponent();
        }

        private void frmUpdateRate_Load(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblNote.Text = String.Empty;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Regex rgxRate= new Regex(@"^[\d]+[\.]?[\d]?$");
            if(!rgxRate.IsMatch(txtRate.Text))
            {
                lblError.Text = "Please write a vaild rate";
                return;
            }
            if (double.Parse(txtRate.Text) < 0 || double.Parse(txtRate.Text) > 1)
            {
                lblError.Text = "Rate must be between 0 and 1";
                return;

            }

            Program.AppDB.UpdateRate(double.Parse(txtRate.Text));
            lblError.Text = String.Empty;
            lblNote.Text = "Rate has been updated";
            Program.AppDB.UpdateRate(double.Parse(txtRate.Text));
        }
    }
}
