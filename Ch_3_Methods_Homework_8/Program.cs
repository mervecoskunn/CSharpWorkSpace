using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //is this number polindrome number or not?
            int choseNumber = 122;
            string d1, d2, d3;
            IsthisPolindromeOrNot(choseNumber);
            string newStringChose = Convert.ToString(choseNumber);
            if (newStringChose.Length == 3)
            {
                d1 = newStringChose.ElementAt(0) + "";
                d2 = newStringChose.ElementAt(1) + "";
                d3 = newStringChose.ElementAt(2) + "";


                if (d1 == d3)
                    Console.WriteLine(choseNumber + " is a palindrome.");
                else
                    Console.WriteLine(choseNumber + " is not a palindrome.");

            }
            else
            {
                Console.WriteLine("Please, enter 3 digits.");
            }


            Console.ReadLine();
            
          
        }
        public static void IsthisPolindromeOrNot(int number)
        {
            Console.WriteLine("Enter a three-digit number: "+ number);
            Console.ReadLine();
        }
    }
}
