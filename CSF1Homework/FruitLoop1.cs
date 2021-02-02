using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruitNames = { "apple", "banana", "pear", "orange", "kiwi", "strawberry" };

            for (int i = 0; i < fruitNames.Length; i++)
            {
                Console.WriteLine(fruitNames[i]);
            }
        }
    }
}
