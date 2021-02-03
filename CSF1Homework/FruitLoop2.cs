using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 Fruit Loop 2";
            Console.WriteLine("Homework: FruitLoop2");

            string[] fruitNames = { "apple", "banana", "pear", "orange", "kiwi", "strawberry" };

            for (int i = 0; i < fruitNames.Length; i++)
            {
                Console.WriteLine(fruitNames[i]);                

                for (int j = -1; j < i; j++)
                {
                    Console.Write(".");
                }

                Console.Write("\n");

                //could also be written using a switch statement since you know how many times it will run
                /*switch (i)
                {
                    case 0:
                        Console.WriteLine(".");
                        break;

                    case 1:
                        Console.WriteLine("..");
                        break;

                    case 2:
                        Console.WriteLine("...");
                        break;

                    case 3:
                        Console.WriteLine("....");
                        break;

                    case 4:
                        Console.WriteLine(".....");
                        break;

                    case 5:
                        Console.WriteLine("......");
                        break;
                    
                    default:
                        break;
                }//end switch */
            }
        }
    }
}
