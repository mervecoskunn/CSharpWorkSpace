using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write 3 integer numbers

            WriteThreeInteger(10,20,30);
            Console.ReadLine();
        }
        public static void WriteThreeInteger(int number1, int number2, int number3)
        {
            Console.WriteLine("Number 1: "+number1);
            Console.WriteLine("Number 2: " + number2);
            Console.WriteLine("Number 3: " + number3);
            Console.ReadLine();
        }
    }
}
