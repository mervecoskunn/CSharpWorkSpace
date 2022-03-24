using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * (Find the smallest n such that n2 > 12,000) Use a while loop to find the smallest 
                integer n such that n2 is greater than 12,000.
             * 
             */
            int n = 0;

            while (Math.Pow(n, 2) < 12000)
            {
                n++;
            }
            Console.WriteLine(n + " is the lowest number, such that n^2 is greater than 12,000");
            Console.WriteLine("Lowest number: " + (n - 1) + "^2 = " + Math.Pow(n - 1, 2));
            Console.WriteLine("Greater than (12.000): " + n + "^2 = " + Math.Pow(n, 2));

            Console.ReadLine();
        }
        
    }
}
