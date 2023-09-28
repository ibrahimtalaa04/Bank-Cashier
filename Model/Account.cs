using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bank_Cashier.Model
{
    abstract public class Account
    {
        static public int count = 10000;
        string name;
        string email;
        double balance;

        public int accountid;

        public int AccountId { get { return accountid; } }

        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }

        public double Balance { get { return balance; } }


        public Account(string Name, string Email, double Balance)
        {
            this.accountid = count++;
            this.Name = Name;
            this.Email = Email;
            this.balance = Balance;
        }





        public virtual bool Credit(double Amount)
        {
            if (Amount >= 0)
            {
                this.balance += Amount;
                return true;
            }
            return false;
        }


        // void or double
        public virtual bool Debit(double Amount)
        {
            if (Amount <= this.balance)
            {
                this.balance -= Amount;
                return true;
            }
            return false;
        }

        public double Getbalance()
        {
            return this.Balance;
        }

    }
}
