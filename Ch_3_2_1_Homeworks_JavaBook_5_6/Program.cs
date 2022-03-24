using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (Conversion from miles to kilometers) Write a program that displays the follow-
               ing two tables side by side:
             */
            Console.WriteLine("Miles\tKilometers\t\tKilometers\tMiles");
            double kilometers;
            double miles;
            double kilometersPerMiles = 1.609;
            for (int m = 1, k = 20; m <= 10 && k <= 65; m ++, k += 5)
            {

                kilometers = m * kilometersPerMiles;
                miles = k / kilometersPerMiles;
                Console.WriteLine(m + "\t\t" + kilometers + "\t|\t" + k + "\t\t" + Math.Round(miles, 2));
            }

            Console.ReadLine();



        }
    }
}
