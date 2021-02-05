using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 FizzBuzz";
            Console.WriteLine("Please enter a whole number between 1 and 100.");
            int userNumber = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else
                {
                    Console.Write(i);
                }

                if (i < userNumber)
                {
                    Console.Write(", ");
                }
                else if (i == userNumber)
                {
                    Console.Write("\n\n");
                }
            }
        }
    }
}
