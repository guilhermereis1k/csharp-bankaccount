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
        public decimal Balance { get; set; }

        public Account() { }

        public Account(string name, decimal currentBalance)
        {
            Name = name;
            Balance = currentBalance;
        }

        public void ChangeName(string newName) { Name = newName; }

        public decimal MakeDeposit(decimal amount)
        {
             return Balance += amount;
        }

        public decimal MakeWithdraw(decimal amount)
        {
            if(Balance < amount) {
                Console.WriteLine("Invalid amount, your account don't have $ " + Balance);
                return Balance;
            } else
            {
                return Balance -= amount;
            }
            
        }
    }

}
