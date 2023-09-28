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
    public partial class frmShowAccounts : Form
    {
        public frmShowAccounts()
        {
            InitializeComponent();
        }

        private void frmShowAccounts_Load(object sender, EventArgs e)
        {
            gvAccounts.DataSource = Program.AppDB.DB;
            gvAccounts.Columns["btncredit"].DisplayIndex = 5;
            gvAccounts.Columns["btnUpdate"].DisplayIndex = 4;
            lblNote.Text = String.Empty;

        }

        private void gvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(gvAccounts.Rows[e.RowIndex].Cells[2].Value.ToString());
            Account account = Program.AppDB.GetByAccountId(ID);  
            int indx = Program.AppDB.DB.IndexOf(account);
            

            if (gvAccounts.Columns[e.ColumnIndex].Name == "btncredit")
            {
                lblNote.Text = String.Empty;
                frmCredit frmcedit = new frmCredit();

                if (frmcedit.ShowDialog() == DialogResult.OK)
                    if (account != null)
                    {
                        double ammount = double.Parse(frmcedit.txtAmount.Text);
                        bool stat = false;
                        if (frmcedit.rbtnCredit.Checked)
                        {
                           stat= Program.AppDB.updateAmountCredit(account, ammount);
                        }
                        else if (frmcedit.rbtnDepit.Checked)
                        {
                            stat = Program.AppDB.updateAmountDepit(account, ammount);
                        }
                        if (stat)
                        {
                            lblNote.Text = "Operation has been done to the account";
                            
                        }
                        else lblNote.Text = "Operation has been failed";
                    }

            }
            else if (gvAccounts.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                frmEditAccount frmEdit=new frmEditAccount();
                frmEdit.txtName.Text = account.Name;
                frmEdit.txtEmail.Text = account.Email;
                frmEdit.txtBalance.Text =Convert.ToString(account.Balance);

                if(account is SavingAccount)
                {
                    frmEdit.rbtnSaving.Checked = true;
                }
                else if (account is CheckingAccount)
                {
                    frmEdit.rbtnChecking.Checked = true;
                    frmEdit.txtFees.Text = Convert.ToString(((CheckingAccount)account).Fee);
                }
                frmEdit.rbtnChecking.Enabled = false;
                frmEdit.rbtnSaving.Enabled = false;
                frmEdit.txtFees.Enabled = false;
                frmEdit.txtBalance.Enabled = false;


                DialogResult res = frmEdit.ShowDialog();
                if (res == DialogResult.OK)
                {
                    bool x = false;
                    if(frmEdit.rbtnChecking.Checked)
                    {
                        x = Program.AppDB.updateAccount(ID, frmEdit.txtName.Text, frmEdit.txtEmail.Text, double.Parse(frmEdit.txtFees.Text));

                    }
                    else if(frmEdit.rbtnSaving.Checked)
                    {
                        x = Program.AppDB.updateAccount(ID, frmEdit.txtName.Text, frmEdit.txtEmail.Text);

                    }
                    if (x)
                    {
                        lblNote.Text = "Acount has been edited";
                        foreach (DataGridViewRow row in gvAccounts.Rows)
                        {
                            if (row.Selected)
                                row.Selected = false;
                        }
                    }
                    else lblNote.Text = "Edited had been failed";
                }
            }
        }
    }
}
