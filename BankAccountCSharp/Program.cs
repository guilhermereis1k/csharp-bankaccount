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
                        try
                        {
                            Console.WriteLine("\n\nHow much you want to deposit?\n");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n\nDeposit amount: " + depositAmount);

                            if (depositAmount > 0)
                            {
                                account.MakeDeposit(depositAmount);
                                Console.WriteLine("\nNew balance: " + account.Balance.ToString("0.00"));
                                Console.WriteLine("\nEnd operation? (y/n)\n");
                                char confirmEnd = Console.ReadKey().KeyChar;
                                char end = char.ToLower(confirmEnd);
                                if (end == 'y')
                                {
                                    Console.WriteLine("\n\nEnding...");
                                    Console.ReadKey();
                                    stop = true;
                                    break;
                                }
                                else if (end == 'n')
                                {
                                    stop = false;
                                }
                            }
                            else if (depositAmount < 0)
                            {
                                Console.WriteLine("\nPlease make sure to enter a valid number.");
                                Console.ReadKey();
                                break;
                            }
                            break;
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine("\nAn error occurred: " + ex.Message);
                            Console.ReadKey();
                            break;
                        }

                    case 'w':
                        try
                        {
                            Console.WriteLine("\n\nHow much you want to withdraw?\n");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                            if (withdrawAmount > 0 && withdrawAmount < account.Balance)
                            {
                                account.MakeWithdraw(withdrawAmount);
                                Console.WriteLine("\nNew balance: " + account.Balance);
                                Console.WriteLine("\nEnd operation? (y/n)\n");
                                char confirmEnd = Console.ReadKey().KeyChar;
                                char end = char.ToLower(confirmEnd);
                                if (end == 'y')
                                {
                                    Console.WriteLine("\n\nEnding...");
                                    Console.ReadKey();
                                    stop = true;
                                    break;
                                }
                                else if (end == 'n')
                                {
                                    stop = false;
                                }
                            } else if (withdrawAmount < 0) {
                                Console.WriteLine("\nPlease make sure to enter a valid number.");
                                Console.ReadKey();
                                break;
                            } else if (withdrawAmount > account.Balance)
                            {
                                Console.WriteLine("\nInvalid funds.");
                                Console.ReadKey();
                                break;
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nAn error occurred: " + ex.Message);
                            Console.ReadKey();
                            break;
                        };

                    case 'e':
                        stop = true;
                        Console.WriteLine("\n\nEnding...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\n\nInvalid input, please try again.");
                        Console.ReadKey();
                        break;
                }
            }
       
    }
}

}