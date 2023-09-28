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
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void frmCredit_Load(object sender, EventArgs e)
        {
            rbtnDepit.Checked = true;
            lblError.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                lblError.Text = "Amount is Required";
                return;
            }
            Regex rgxAmount = new Regex(@"^[\-]?[\d]+[\.]?[\d]?$");
            if(!rgxAmount.IsMatch(txtAmount.Text))
            {
                lblError.Text = "Invalid amount, Please try again !!";
                return;
            }
            if(Double.Parse(txtAmount.Text)<0)
            {
                lblError.Text = "Amount must be greate than 0";
                return;
            }
            lblError.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
