using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Accounts
{
class Account
    {
        public string? Name { get; set; }
        public double Balance { get; set; }

        public Account() { }

        public Account(string name, double currentBalance)
        {
            Name = name;
            Balance = currentBalance;
        }

        public void ChangeName(string newName) { Name = newName; }

        public double MakeDeposit(double amount)
        {
             return Balance += amount;
        }

        public double MakeWithdraw(double amount)
        {
             return Balance -= amount;       
        }
    }

}
