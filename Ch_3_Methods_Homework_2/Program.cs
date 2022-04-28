using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sum of even numbers from 1 until n 
            int total = SumEvensUntil(10);
            Console.WriteLine("Sum of evens number from 1 until 10: "+total);
            Console.ReadLine();


        }
        public static int SumEvensUntil(int n)
        {
            int sum = 0;
            for (int i = 2; i < 10; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
