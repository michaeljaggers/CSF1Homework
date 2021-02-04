using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1Homework Login";
            bool runProgram;
            int userAttempts = 3;
            int passAttempts = 3;
            const string CORRECT_NAME = "CHARLES";
            const string CORRECT_PASSWORD = "PASSWORD";

            do
            {
                runProgram = true;
                Console.WriteLine("To proceed, please log in.");
                Console.WriteLine("Enter your username:\tex. 'charles'\n");
                string username = Console.ReadLine().ToUpper();
                Console.Clear();

                if (username == CORRECT_NAME)
                {
                    do
                    {
                        Console.WriteLine("To continue, please authenticate your account.");
                        Console.WriteLine("Enter your password:\tex. 'password'\n");
                        string password = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (password == CORRECT_PASSWORD)
                        {
                            Console.WriteLine("Access Granted.\n");

                            runProgram = false;
                        }
                        else
                        {
                            passAttempts--;

                            if (passAttempts > 0)
                            {
                                Console.WriteLine("Incorrect password. Access denied.\n" +
                                                    $"You have {passAttempts} attempt{(passAttempts == 1 ? "" : "s")} remaining.\n");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect username. Access denied.\n" +
                                                  "Your account is now locked, please contact customer service.\n");

                                runProgram = false;
                            }
                        } 
                    } while (runProgram && passAttempts > 0);
                }
                else
                {
                    userAttempts--;

                    if (userAttempts > 0)
                    {
                        Console.WriteLine("Incorrect username. Access denied.\n" +
                                         $"You have {userAttempts} attempt{(userAttempts == 1 ? "" : "s")} remaining.\n");
                    } 
                    else
                    {
                        Console.WriteLine("Incorrect username. Access denied.\n" +
                                          "Your account is now locked, please contact customer service.\n");

                        runProgram = false;
                    }
                }
            } while (runProgram);
        }//end Main
    }//end class
}//end namespace