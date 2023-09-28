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
    public partial class frmEditAccount : Form
    {
        public frmEditAccount()
        {
            InitializeComponent();
        }

        private void btnEditAcount_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
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
            if (!rgxEmail.IsMatch(txtEmail.Text))
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
            if (!rgxBalane.IsMatch(txtBalance.Text))
            {
                lblError.Text = "Please write a valid balance ";
                return;
            }

            if (!rbtnChecking.Checked && !rbtnSaving.Checked)
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
        }
        private void Type_Checked(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Name.Equals("rbtnSaving"))
            {
                lblFees.Visible = false;
                txtFees.Visible = false;

            }
            else if (radio.Name.Equals("rbtnChecking"))
            {
                lblFees.Visible = true;
                txtFees.Visible = true;
            }

        }

       
    }
}
