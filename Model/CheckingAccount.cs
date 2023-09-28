using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Cashier.Model
{
    class CheckingAccount : Account
    {
        double fee;

        public double Fee { get { return fee; } set { fee = (value > 0) ? value : 0; } }

        public CheckingAccount(string Name, string Email, double Balance,double Fee) : base(Name, Email,Balance)
        {
            this.Fee = Fee;
        }

        public override bool Debit(double Amount)
        {
           return base.Debit((Amount-Fee));
        }

        public override bool Credit(double Amount)
        {
           return base.Credit((Amount-Fee));
        }
    }
}
