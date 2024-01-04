using System;
using BankAccountCSharp;
using Accounts;

namespace BankAccountCSharp { 
class Program
{
    static void Main()
    {
        

        Console.WriteLine("\n\n--------------------------\nWelcome to the Hayes Bank!\n--------------------------\n");
        Console.WriteLine("Please insert your name: \n");
        string accountName = Console.ReadLine();

        Account account = new Account(accountName, 0);
        Console.WriteLine("\nWelcome " + account.Name + " you have successfully created your account.");

        bool stop = false;

        while(!stop)
            {
                Console.Clear();
                Console.WriteLine("\n\nPlease press the corresponding letter of the operation you want: Deposit (D), Withdraw (W) or stop (E):\n");

                char operation = Console.ReadKey().KeyChar;
                operation = char.ToLower(operation);

                switch (operation)
                {
                    case 'd':
                        Console.WriteLine("\n\nHow much you want to deposit?\n");
                        string depositAmountString = Console.ReadLine();

                        if (decimal.TryParse(depositAmountString, out decimal depositAmount))
                        {
                            account.MakeDeposit(depositAmount);
                            Console.WriteLine("\nNew balance: " + account.Balance.ToString("0.00"));
                            Console.WriteLine("\nEnd operation? (y/n)\n");
                            char confirmEnd = Console.ReadKey().KeyChar;
                            char end = char.ToLower(confirmEnd);
                            if (end == 'y')
                            {
                                Console.WriteLine("\nEnding...");
                            } else if (end == 'n')
                            {
                                stop = false;
                            }
                            else
                            {
                                break;
                            }
                                
                        }

                        Console.WriteLine("\nInvalid input. Please try again.");
                        break;

                    case 'w':
                        Console.WriteLine("\n\nHow much you want to withdraw?\n");
                        string withdrawAmountString = Console.ReadLine();

                        if (decimal.TryParse(withdrawAmountString, out decimal withdrawAmount))
                        {
                            account.MakeWithdraw(withdrawAmount);
                            Console.WriteLine("\nNew balance: " + account.Balance);
                            Console.WriteLine("\nEnd operation? (y/n)\n");
                            char confirmEnd = Console.ReadKey().KeyChar;
                            char end = char.ToLower(confirmEnd);
                            if (end == 'y')
                            {
                                Console.WriteLine("\nEnding...");
                            }
                            else if (end == 'n')
                            {
                                stop = false;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 'e':
                        stop = true;
                        Console.WriteLine("\nStoping...");
                        break;
                    default:
                        stop = true;
                        Console.WriteLine("\nInvalid input, please try again.");
                        stop = false;
                        break;
                }
            }
       
    }
}

}