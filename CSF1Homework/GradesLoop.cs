using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 GradesLoop";
            string score;
            string scores = "";
            do
            {
                Console.WriteLine("Please enter a score (0-100).  A negative number will display entered scores.\n");
                score = Console.ReadLine();

                Console.Clear();

                if (int.Parse(score) >= 0)
                {
                    scores += $"{score}\n";
                }
                
            } while (int.Parse(score) >= 0);

            Console.WriteLine("Your Scores\n" + scores);
        }
    }
}
