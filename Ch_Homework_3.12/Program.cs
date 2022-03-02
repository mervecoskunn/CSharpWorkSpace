using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_Homework_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Enter a three-digit integer: ");
            int number;
            string d1, d2, d3;
            Int32.TryParse(Console.ReadLine(), out number);
            string numberstr = Convert.ToString(number); // 121
            if (numberstr.Length == 3)
            {
                d1 = numberstr.ElementAt(0) + ""; // 1
                d2 = numberstr.ElementAt(1) + "";
                d3 = numberstr.ElementAt(2) + "";


                if (d1 == d3)
                    Console.WriteLine(number + " is a palindrome.");
                else
                    Console.WriteLine(number + " is not a palindrome.");

            }
            else
            {
                Console.WriteLine("Please, enter 3 digits.");
            }




            // 121


            Console.ReadLine();
        }


    }
}
