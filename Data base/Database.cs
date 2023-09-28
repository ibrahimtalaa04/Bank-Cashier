using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Cashier.Model;
using System.IO;

namespace Bank_Cashier.Data_base
{

    class Database
    {
        BindingList<Account> dataAccounts;
        SortedList<string,AdminBank> dataAdmins;
        StreamReader sr;
        StreamWriter sw;
        public BindingList<Account> DB { get { return dataAccounts; } }

        public Database()
        {
            dataAccounts = ReadFromFile();

            //dataAccounts.Add(new CheckingAccount("Ibrahim AlTalaa","ibrahim@gtc.edu.ps",2000,10));
            //dataAccounts.Add(new CheckingAccount("Hamza Alkhateeb","hamza@gtc.edu.ps",3000,25));
            //dataAccounts.Add(new CheckingAccount("Zakaria Abu Silmiyeh","zakariya@gtc.edu.ps",10000,80));
            //dataAccounts.Add(new SavingAccount("Tahani Alnaouq", "tahanialnaouq@gtc.edu.ps", 50000));
            //dataAccounts.Add(new SavingAccount("Mahmoud Hassounw", "mahmoudhassouna@gtc.edu.ps", 25000));
            dataAdmins = new SortedList<string,AdminBank>();
            dataAdmins.Add("ibrahim",new AdminBank("ibrahim", "ibrahim","Ibrahim AlTalaa"));
            dataAdmins.Add("hamza",new AdminBank("hamza", "hamza","Hamza Alkhateeb"));
            dataAdmins.Add("zakaria",new AdminBank("zakaria", "zakaria","Zakaria Abu Silmiyah"));
        }
        public bool AddAccount(Account account)
        {
            
            int oldcount = dataAccounts.Count;
            dataAccounts.Add(account);
            int newcount = dataAccounts.Count;
            if (newcount > oldcount)
                return true;
            return false;
        }
        public void UpdateRate(double Rate)
        {
            SavingAccount.interestrate = Rate;
            for(int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i] is SavingAccount)
                {
                    ((SavingAccount)dataAccounts[i]).CalculateInerest();
                }
            }
        }
        public bool updateAmountCredit(Account account,double Newamount)
        {
            account.Credit(Newamount);
            for(int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i]==account)
                {
                    dataAccounts[i] = account;
                    return true;
                }
            }
            return false;
        }
        public bool updateAmountDepit(Account account, double Newamount)
        {
            account.Debit(Newamount);
            for (int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i] == account)
                {
                    dataAccounts[i] = account;
                    return true;
                }
            }
            return false;
        }
        public bool checkUser(string Username)
        {
            if(dataAdmins.IndexOfKey(Username)!=-1)
            {
                return true;
            }
            return false;
        }
        public bool checkPassword(string Username,string Password)
        {
            int indx = dataAdmins.IndexOfKey(Username);
            if (indx != -1)
            {
               return dataAdmins[Username].Password == Password;
            }
            return false;
        }
        public string GetAdminName(string Username)
        {
            if (dataAdmins.IndexOfKey(Username) != -1)
            {
                string name = dataAdmins[Username].Name;
                return name;
            }
            return null;
        }
        public Account GetByAccountId(int AccountID)
        {
            for(int i = 0; i < dataAccounts.Count; i++)
            {
                if(dataAccounts[i].AccountId == AccountID)
                {
                    return dataAccounts[i];
                }
            }
            return null;
        }
        public bool updateAccount(int ID, string Name,string Email)
        {
            for(int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i].AccountId == ID)
                {
                    dataAccounts[i].Name = Name;
                    dataAccounts[i].Email =Email;
                    return true;
                }
            }
            return false;
        }
        public bool updateAccount(int ID, string Name, string Email,double Fees)
        {
            for (int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i].AccountId == ID)
                {
                    if (dataAccounts[i] is CheckingAccount)
                    {
                        dataAccounts[i].Name = Name;
                        dataAccounts[i].Email = Email;
                        ((CheckingAccount)dataAccounts[i]).Fee = Fees;
                        return true;
                    }
                }
            }
            return false;
        }
        public Account SearchId(int ID)
        {
            Account acc = null;
            foreach(Account account in dataAccounts)
            {
                if(account.AccountId == ID)
                {
                    acc = account;
                    break;
                }
            }
            return acc;
        }
        public int CountSaving()
        {
            int count = 0;
            for(int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i] is SavingAccount)
                    count++;
            }
            return count;
        }
        public int CountChecking()
        {
            int count = 0;
            for (int i = 0; i < dataAccounts.Count; i++)
            {
                if (dataAccounts[i] is CheckingAccount)
                    count++;
            }
            return count;
        }
        public BindingList<Account> SearchName(String Name)
        {
            BindingList<Account> list = new BindingList<Account>();
         
            foreach(Account account in dataAccounts)
            {
                if(account.Name.Contains(Name))
                {
                    list.Add(account);
                }
            }
            return list;

        }

        public BindingList<Account> ReadFromFile()
        {
            StreamReader sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}\\Data.csv");
            BindingList<Account> res = new BindingList<Account>();
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\Data.csv")) 
            {
                string empty = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                    if (parts[0] == "CheckingAccount")
                    {
                        if (parts.Length == 5)
                        {
                            res.Add(new CheckingAccount(parts[1], parts[2], double.Parse(parts[3]), double.Parse(parts[4])));
                        }
                    }
                    else if (parts[0] == "SavingAccount")
                    {
                        if (parts.Length == 4)
                        {
                            res.Add(new SavingAccount(parts[1], parts[2], double.Parse(parts[3])));
                        }
                    }
                }
            }
            sr.Close();
            return res;

        }
    }

}
