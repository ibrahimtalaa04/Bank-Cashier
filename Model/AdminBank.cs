using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Cashier.Model
{
    public class AdminBank
    {
        string username;
        string password;
        string name;
        public string Username { get { return username; } set { username = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public AdminBank(string Username,string Password,string Name)
        {
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
        }

    }
}
