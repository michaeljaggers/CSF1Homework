using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 Interest Calculator";
            Console.WriteLine("Please input a starting dollar amount (decimals are OK).\n");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please input your annual interest rate percentage (without the %).\n");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter the term in years for calculation.\n");
            decimal term = decimal.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < term; i++)
            {
                balance += balance * (interestRate / 100);
            }

            Console.WriteLine($"The total amount you will have in {term} year{(Convert.ToInt32(term) == 1 ? "" : "s")} is {balance:c}\n");
        }
    }
}
