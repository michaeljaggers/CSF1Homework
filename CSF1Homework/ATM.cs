using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {

            Console.Title = "CSF1 ATM";
            bool authenticate = true;
            int numAttempts = 3;
            int passAttempts = 3;
            int balance = 0;
            const string CORRECT_NUMBER = "123456789";
            const string CORRECT_PASSWORD = "0000";

            Console.WriteLine("Welcome to Swindler's Bank");

            do
            {
                //enter account number
                Console.WriteLine("Please enter your 9-digit account number:\tex. '123456789'\n");
                string number = Console.ReadLine();
                Console.Clear();

                if (number == CORRECT_NUMBER)
                {
                    do
                    {
                        //enter pin number
                        Console.WriteLine("To continue, input your account PIN:\tex. '0000'\n");
                        string password = Console.ReadLine();
                        Console.Clear();

                        if (password == CORRECT_PASSWORD)
                        {
                            bool continueMenu = false;
                            do
                            {
                                //main menu
                                Console.WriteLine("# Main Menu #\n" +
                                                  "Please choose your option:\n\n" +
                                                  "- (D) Deposit\n" +
                                                  "- (W) Withdrawal\n" +
                                                  "- (B) Check Balance\n" +
                                                  "- (X) Exit\n");

                                string option = Console.ReadLine().ToUpper();
                                Console.Clear();

                                //menu options
                                switch (option)
                                {
                                    case "D":
                                        Console.WriteLine("# Deposit #\n" + "How much would you like to deposit? (whole dollar amounts only)\n");
                                        int deposit = int.Parse(Console.ReadLine());

                                        Console.Clear();
                                        balance += deposit;
                                        Console.WriteLine($"{deposit:c} has been deposited into account number {CORRECT_NUMBER}.\n\n");
                                        Console.WriteLine("Would you like to start a new transaction? Y/N");
                                        continueMenu = Console.ReadLine().ToUpper() == "Y";
                                        Console.Clear();

                                        if (!continueMenu)
                                        {
                                            Console.WriteLine("Thank you for choosing Swindler's Bank!  We appreciate your business.\n");
                                        }
                                        break;

                                    case "W":
                                        Console.WriteLine("# Withdrawal #\n" + "Please enter the withwrawal amount. (whole dollar amounts only\n");
                                        int withdrawal = int.Parse(Console.ReadLine());

                                        Console.Clear();
                                        balance -= withdrawal;
                                        Console.WriteLine($"{withdrawal:c} has been withdrawn from account number {CORRECT_NUMBER}.\n\n");
                                        Console.WriteLine("Would you like to start a new transaction? Y/N");
                                        continueMenu = Console.ReadLine().ToUpper() == "Y";
                                        Console.Clear();

                                        if (!continueMenu)
                                        {
                                            Console.WriteLine("Thank you for choosing Swindler's Bank!  We appreciate your business.\n");
                                        }
                                        break;

                                    case "B":
                                        Console.WriteLine("# Balance #\n\n" + $"Account {CORRECT_NUMBER} has a current balance of {balance:c}.\n\n");
                                        Console.WriteLine("Would you like to start a new transaction? Y/N");
                                        continueMenu = Console.ReadLine().ToUpper() == "Y";
                                        Console.Clear();

                                        if (!continueMenu)
                                        {
                                            Console.WriteLine("Thank you for choosing Swindler's Bank!  We appreciate your business.\n");
                                        }
                                        break;

                                    case "X":
                                        Console.WriteLine("Thank you for choosing Swindler's Bank!  We appreciate your business.\n");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid option selected.\n");
                                        continueMenu = true;
                                        break;
                                }

                                authenticate = false;
                            } while (continueMenu);
                        }
                        else
                        {
                            //failed password entry
                            passAttempts--;

                            if (passAttempts > 0)
                            {
                                Console.WriteLine("PIN number incorrect. Please try again.\n" +
                                                  $"You have {passAttempts} attempt{(passAttempts == 1 ? "" : "s")} remaining.\n");
                            }
                            else
                            {
                                Console.WriteLine("PIN number incorrect. Access denied.\n" +
                                                  "Your account is now locked, please contact customer service.\n");

                                authenticate = false;
                            }
                        }
                    } while (authenticate && passAttempts > 0);
                }
                else
                {
                    //failed account number entry
                    numAttempts--;

                    if (numAttempts > 0)
                    {
                        Console.WriteLine("Account not found.\n" +
                                         $"You have {numAttempts} attempt{(numAttempts == 1 ? "" : "s")} remaining.\n");
                    }
                    else
                    {
                        Console.WriteLine("Account not found.\n\n" +
                                          "Thank you for choosing Swindler's Bank!  We appreciate your business.\n");

                        authenticate = false;
                    }
                }
            } while (authenticate);
        }
    }
}
