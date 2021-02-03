using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF1 Temperature Conveter";
            Console.WriteLine("Homework: Temperature Converter\n");

            bool continueProgram = false;

            do
            {
                //program entry       
                continueProgram = false;
                Console.WriteLine("What system of measurement would you like to convert?\n" +
                    "Celsius (C)\n" +
                    "Fahrenheit (F)\n");
                string system = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (system)
                {
                    case "CELSIUS":
                    case "C":
                        //celsius to fahrenheit
                        Console.WriteLine("Please enter a numeric temperature value in Celsius to convert: ");
                        decimal userCelsius = decimal.Parse(Console.ReadLine());
                        decimal fahrenheitResult = userCelsius * (9.0m / 5.0m) + 32;
                        Console.Clear();
                        Console.WriteLine($"The Celsius value of {userCelsius}\x00B0 converted to Fahrenheit is {fahrenheitResult}\x00B0\n");
                        Console.WriteLine("Would you like to do another temperature conversion? Y/N\n");
                        continueProgram = Console.ReadLine().ToUpper() == "Y";
                        Console.Clear();
                        break;

                    case "FAHRENHEIT":
                    case "F":
                        //fahrenheit to celsius
                        Console.WriteLine("Please enter a numeric temperature value in Fahrenheit to convert: ");
                        decimal userFahrenheit = decimal.Parse(Console.ReadLine());
                        decimal celsiusResult = (userFahrenheit - 32) / (9.0m / 5.0m);
                        Console.Clear();
                        Console.WriteLine($"The Fahrenheit value of {userFahrenheit}\x00B0 converted to Celsius is {celsiusResult}\x00B0\n");
                        Console.WriteLine("Would you like to do another temperature conversion? Y/N\n");
                        continueProgram = Console.ReadLine().ToUpper() == "Y";
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid system of measurement.\nYou must choose between Celsius (C) or Fahrenheit (F)\n");
                        continueProgram = true;
                        break;
                }
            } while (continueProgram);

            Console.WriteLine("Exiting program.\n");

        }
    }
}
