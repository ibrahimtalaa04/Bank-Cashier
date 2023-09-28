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
using Bank_Cashier.Model;
using System.ComponentModel;

namespace Bank_Cashier
{
    public partial class frmSearch : Form
    {
        BindingList<Account> list;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            lblSearch.Text = String.Empty;

            if (txtSearch.Text.Length == 0)
            {
                if (rbtnSearchId.Checked)
                {
                    lblError.Text = "PLease write Id";
                }
                else
                {
                    lblError.Text = "PLease write the Name";
                }
                lblSearch.Text = String.Empty;
                return;
            }

            if (rbtnSearchId.Checked)
            {
                Regex r = new Regex(@"^\d{5}$");
                lblSearch.Text = String.Empty;

                if (r.IsMatch(txtSearch.Text))
                {
                    Account ac = Program.AppDB.SearchId(int.Parse(txtSearch.Text));
                    if(ac != null)
                    {
                        BindingList<Account> accounts = new BindingList<Account>();
                        accounts.Add(ac);
                        gvSearch.Visible = true;
                        gvSearch.DataSource = accounts;
                        lblError.Text = String.Empty;
                    }
                    else
                    {
                        gvSearch.Visible = false;
                        lblSearch.Visible = true;
                        lblSearch.Text = "There is no account has this id";
                        lblError.Text = String.Empty;
                    }

                }
                else
                {
                    lblError.Text = "Id must be 5 digit numbers !!!";
                    lblSearch.Text = String.Empty;

                }
            }
            else
            {
                list = Program.AppDB.SearchName(txtSearch.Text);
                lblSearch.Text = String.Empty;
                lblError.Text = String.Empty;
                if (list.Count != 0)
                {
                    gvSearch.Visible = true;
                    gvSearch.DataSource = list;
                }
                else
                {
                    gvSearch.Visible = false;
                    lblSearch.Visible = true;
                    lblSearch.Text = "There is no Accounts contain this name";
                    lblError.Text = String.Empty;
                }
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            lblError.Text=String.Empty;
            lblNote.Text = String.Empty;
            rbtnSearchId.Checked=true;
            lblSearch.Visible=false;
            gvSearch.Visible=false;
            //gvSearch.Columns["btnUpdate"].DisplayIndex = 3;
            //gvSearch.Columns["btncredit"].DisplayIndex = 4;

        }

        private void gvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(gvSearch.Rows[e.RowIndex].Cells[1].Value.ToString());
            Account account = Program.AppDB.GetByAccountId(ID);
            int indx = Program.AppDB.DB.IndexOf(account);
            int indxlist = list.IndexOf(account);
            if (gvSearch.Columns[e.ColumnIndex].Name == "btncredit")
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
                            stat = Program.AppDB.updateAmountCredit(account, ammount);
                            
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
                        foreach (DataGridViewRow row in gvSearch.Rows)
                        {
                            if (row.Selected)
                                row.Selected = false;
                        }
                        gvSearch.Rows[e.RowIndex].Cells[4].Value = list[indxlist].Balance;
                    }
            }
        }


    }
}
