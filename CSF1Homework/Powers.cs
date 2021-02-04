using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 Powers";
            for (int i = 1; i <= 50; i++)
            {
                long result = (long)Math.Pow(2, i);
                Console.WriteLine($"{result}");
            }
        }
    }
}
