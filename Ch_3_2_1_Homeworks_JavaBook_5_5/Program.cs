using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (Conversion from kilograms to pounds and pounds to kilograms) Write a program
               that displays the following two tables side by side:
             */
            Console.WriteLine("Kilograms\tPounds\t\tPounds\tKilograms");
            double pound;
            double kilogram;
            double poundPerKilogram = 2.2;
            for (int  k = 1 ,  p =20; k <=199 && p<=515; k+=2,p+=5)
                {
                
                pound = k * poundPerKilogram;
                kilogram = p / 2.2;
                Console.WriteLine(k+"\t\t"+ pound+"\t|\t"+p+"\t"+Math.Round(kilogram,2));
            }

            Console.ReadLine();





        }
    }
}
