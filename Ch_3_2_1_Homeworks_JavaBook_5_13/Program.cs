using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_13
{
    internal class Program
    {
        static void Main(string[] args)
        {/* (Find the largest n such that n3 < 12,000) Use a while loop to find the largest 
             integer n such that n3 is less than 12,000.
          * 
          * 
          */
            int n = 0;

            while (Math.Pow(n, 3) < 12000)
            {
                n++;
            }
            Console.WriteLine(n + " is the lowest number, such that n^3 is greater than 12,000");
            Console.WriteLine("Lowest number: " + (n - 1) + "^3 = " + Math.Pow(n - 1, 3));
            Console.WriteLine("Greater than (12.000): " + n + "^3 = " + Math.Pow(n, 3));

            Console.ReadLine();



        }
    }
}
