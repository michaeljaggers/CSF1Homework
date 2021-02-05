using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 Fibonacci";
            Console.WriteLine("Pease input a whole number between 1-100000 to use as a stopping point.");
            int userNumber = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            int prevNumber = 0;
            int nextNumber = 0;
            Console.Clear();

            
            
            while (currentNumber < userNumber)
            {
                if (currentNumber == 0)
                {
                    currentNumber++;
                    Console.Write($"{prevNumber}, {currentNumber}, ");
                }
                else
                {
                    nextNumber = currentNumber + prevNumber;
                    Console.Write($"{nextNumber}, ");
                    prevNumber = currentNumber;
                    currentNumber = nextNumber;
                }
            }

            Console.WriteLine("\n");
        }
    }
}
