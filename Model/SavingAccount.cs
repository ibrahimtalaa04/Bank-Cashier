using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Cashier.Model
{
    class SavingAccount : Account
    {
        public static double interestrate=0.25;

        public double InterestRate { get { return interestrate; }  }

        public SavingAccount(string Name, string Email, double Balance) : base(Name, Email, Balance)
        { 

        }

        public bool CalculateInerest()
        {
            return base.Credit(InterestRate * this.Balance);
        }

    }
}
