using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method for sum of odds numbers from 1 until n
            int total = sumOddsUntil(10);
            Console.WriteLine("Sum odds numbers from 1 until 10: "+ total);
            Console.ReadLine();

        }
        public static int sumOddsUntil(int n )
        {
            int sum = 0;
               n = 10;
            for (int i = 1; i < n; i+=2)
            {
                sum += i;

            }
            return sum;

        }
    }
}
