using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework: Mad Lib");
            Console.WriteLine("\nPlease enter some information below to do this Mad Lib.  Unless otherwise specified, verbs should be in standard present tense (i.e. 'swim' or 'run').  Adverbs are words modifying verbs (like 'soon', or often ending in 'ly', like 'swiftly').  Adjectives are words that describe nouns (like 'green' or 'descriptive').");

            Console.WriteLine("\nNoun:");
            string noun = Console.ReadLine();

            Console.WriteLine("\nVerb:");
            string verb = Console.ReadLine();

            Console.WriteLine("\nAdjective:");
            string adjective = Console.ReadLine();

            Console.WriteLine("\nNoun:");
            string noun2 = Console.ReadLine();

            Console.WriteLine("\nVerb ending in '-ing':");
            string verb2 = Console.ReadLine();

            Console.WriteLine("\nAdjective:");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("\nAdverb:");
            string adverb = Console.ReadLine();

            Console.WriteLine("\nExclamation:");
            string exclamation = Console.ReadLine();

            Console.WriteLine("\nCity:");
            string city = Console.ReadLine();

            Console.WriteLine("\nA Time Of Day:");
            string time = Console.ReadLine();

            Console.WriteLine("\nThanks, here's your story:");
            Console.WriteLine($"One day there was a {noun}");
        }
    }
}
