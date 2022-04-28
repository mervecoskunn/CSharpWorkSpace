using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the ISBN number :");

            // Read input
            string isbn = Console.ReadLine();

            if (isbn.Length == 9)
            {
                // Get each digit as integers
                int d1 = int.Parse(isbn.ElementAt(0) + "");
                int d2 = int.Parse(isbn.ElementAt(1) + "");
                int d3 = int.Parse(isbn.ElementAt(2) + "");
                int d4 = int.Parse(isbn.ElementAt(3) + "");
                int d5 = int.Parse(isbn.ElementAt(4) + "");
                int d6 = int.Parse(isbn.ElementAt(5) + "");
                int d7 = int.Parse(isbn.ElementAt(6) + "");
                int d8 = int.Parse(isbn.ElementAt(7) + "");
                int d9 = int.Parse(isbn.ElementAt(8) + "");

                // Compute d10
                int d10 = (d1 * 1 + d2 * 2 + d3 * 3 + d4 * 4 + d5 * 5 + d6 * 6 + d7 * 7 + d8 * 8 + d9 * 9) % 11;

                // Do according to the result of d10
                if (d10 == 10)
                {
                    Console.WriteLine(isbn + "X");
                }
                else
                    Console.WriteLine(isbn + d10);
            }
            else
                Console.WriteLine("Please specify 9 digits");


            Console.ReadLine();
        }

    }
}    
    
