using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sum of numbers from 1 to n.
            int total = SumUntil(10);
            Console.WriteLine("Total:"+ total);
            Console.ReadLine();
           
        }
        public static int SumUntil(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                 sum+= i;
            }
            return sum;

        }


    }
}
