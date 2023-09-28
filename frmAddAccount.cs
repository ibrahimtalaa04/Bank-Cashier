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
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;
using Bank_Cashier.Model;

namespace Bank_Cashier
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }


        private void Type_Checked(object sender, EventArgs e)
        {
            var radio=(RadioButton)sender;
            if(radio.Name.Equals("rbtnSaving"))
            {
                lblFees.Visible = false;
                txtFees.Visible = false;

            }
            else if(radio.Name.Equals("rbtnChecking"))
            {
                lblFees.Visible = true;
                txtFees.Visible = true;
            }

        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            rbtnChecking.Checked = true;
            lblError.Text = String.Empty;
            lblNote.Text = String.Empty;
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text))
            {
                lblError.Text = "Name is Required";
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblError.Text = "Email is Required";
                return;
            }
            Regex rgxEmail = new Regex(@"^(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)$");
            if(!rgxEmail.IsMatch(txtEmail.Text))
            {
                lblError.Text = "Please Write a valid Email";
                return;
            }
            if (string.IsNullOrEmpty(txtBalance.Text))
            {
                lblError.Text = "Balance is Required";
                return;
            }
            Regex rgxBalane = new Regex(@"^[\d]+[\.]?[\d]?$");
            if(!rgxBalane.IsMatch(txtBalance.Text))
            {
                lblError.Text = "Please write a valid balance ";
                return;
            }

            if(!rbtnChecking.Checked &&!rbtnSaving.Checked)
            {
                lblError.Text = "Please choose the account type";
                return;
            }
            if (lblFees.Visible && txtFees.Visible)
            {
                if (string.IsNullOrEmpty(txtFees.Text))
                {
                    lblError.Text = "Fees is Required";
                    return;
                }
                else if (!rgxBalane.IsMatch(txtFees.Text))
                {
                    lblError.Text = "Please write a vaild Fees";
                    return;
                }
                else lblError.Text = String.Empty;
            }
            lblError.Text = String.Empty;
            DialogResult = DialogResult.OK;
            Account acNew = null;
            if(rbtnChecking.Checked)
            {
                acNew = new CheckingAccount(txtName.Text,txtEmail.Text,double.Parse(txtBalance.Text),double.Parse(txtFees.Text));

            }
            else acNew = new SavingAccount(txtName.Text, txtEmail.Text, double.Parse(txtBalance.Text));

            bool status= Program.AppDB.AddAccount(acNew);
            if(status==true)
            {
                lblNote.Text = "The Account has been added";
            }
            else
            {
                lblNote.Text = "The add has been failed";

            }


            btnReset.PerformClick();

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblFees.Visible = true;
            txtFees.Visible = true;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = String.Empty;
                }
                else if (this.Controls[i] is RadioButton)
                {
                    ((RadioButton)(this.Controls[i])).Checked = false;
                }
                else if (this.Controls[i] is ListControl)
                {
                    ((ListControl)this.Controls[i]).SelectedIndex = -1;
                }
                else if (this.Controls[i] is BunifuTextbox)
                {
                    this.Controls[i].Text = String.Empty;
                }
                else if (this.Controls[i] is BunifuMaterialTextbox)
                {
                    this.Controls[i].Text = String.Empty;
                }
                else if (this.Controls[i] is BunifuMetroTextbox)
                {
                    this.Controls[i].Text = String.Empty;
                }
            }
            lblError.Text = String.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.Cancel;
            this.Close();
        }

    }
}
