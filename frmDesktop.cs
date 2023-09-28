using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bank_Cashier.Model;

namespace Bank_Cashier
{
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Close();
                return;
            }

            if (Program.AppDB.GetAdminName(frmLogin.txtUsername.Text) != null)
                lblWelcome.Text = "Welcome " + Program.AppDB.GetAdminName(frmLogin.txtUsername.Text);

            loadform(new frmHome());
        }
        private void loadform(Form form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();


        }



        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            loadform(new frmUpdateRate());

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            loadform(new frmAddAccount());
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            loadform(new frmShowAccounts());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadform(new frmSearch());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new frmHome());
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        { 
            DialogResult res= MessageBox.Show("You are about to close !", "Close", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK) 
            {
                StreamWriter sr = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Data.csv");
                sr.WriteLine("Type,Name,Email,Balance");
                foreach(Account acc in Program.AppDB.DB)
                {
                    if(acc is CheckingAccount) 
                    {
                        sr.WriteLine($"CheckingAccount,{acc.Name.Trim()},{acc.Email.Trim()},{acc.Balance},{((CheckingAccount)acc).Fee}");
                    }
                    else
                    {
                        sr.WriteLine($"SavingAccount,{acc.Name.Trim()},{acc.Email.Trim()},{acc.Balance}");
                    }
                }
                sr.Close();
                this.Close();
            }
        }
    }
}
