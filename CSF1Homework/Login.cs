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
            int attempts = 3;
       
            do
            {
                //program entry
                runProgram = true;
                Console.WriteLine("To proceed, please log in.");
                Console.WriteLine("Enter your username:\tex. 'charles'\n");
                const string CORRECT_NAME = "CHARLES";
                string username = Console.ReadLine().ToUpper();
                Console.Clear();


                if (username == CORRECT_NAME)
                {
                    Console.WriteLine("Access Granted.\n");
                    runProgram = false;
                }
                else
                {
                    attempts--;

                    if (attempts > 0)
                    {
                        Console.WriteLine("Incorrect username: access denied.\n" +
                                         $"You have {attempts} attempts remaining.\n");
                    } 
                    else
                    {
                        Console.WriteLine("Incorrect username: access denied.\n" +
                            "Your account is now locked, please contact customer service.\n");
                        runProgram = false;
                    }
                    


                }
            } while (runProgram);
            
        }
    }
}