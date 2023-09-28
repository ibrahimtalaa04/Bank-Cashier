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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            


        }
        
        private void lblClose_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.Cancel;
            this.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            Regex regex = new Regex(@"^[A-z][A-z|\._]+$");
            if(txtUsername.Text.Length == 0)
            {
                lblError.Text = "Please write your username";
                return;
            }
            if(!regex.IsMatch(txtUsername.Text))
            {
                lblError.Text = "Invalid Username,Please try again !";
                return;
            }
            else
            {
                if(Program.AppDB.checkUser(txtUsername.Text))
                {
                    if(Program.AppDB.checkPassword(txtUsername.Text,txtPassword.Text))
                    {
                        lblError.Text = String.Empty;
                    }
                    else
                    {
                        lblError.Text = "Wrong Password, Please try again";
                        return;
                    }
                }
                else
                {
                    lblError.Text = "This Username is not exist!";
                    return;
                }
            }
            if(txtPassword.Text.Length==0)
            {
                lblError.Text = "Please write your Password ";
                return;
            }
            

            this.Close();
            DialogResult= DialogResult.OK;
            
            
        }

      
    }
}
