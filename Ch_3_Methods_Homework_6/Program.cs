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

            WriteThreeInteger(30,20,10);
            Console.ReadLine();
        }
        public static void WriteThreeInteger(int number1, int number2, int number3)
        {
            if (number1>number2 || number1>number3)
            {
                Console.WriteLine("Number 1 is biggest than other: "+ number1);
            }
            else if (number1>number2 || number2>number3)
            {
                Console.WriteLine("Number 2 is bigger than number3 and smaller than number1:  "+number2);
            }
            else if (number3<number1 || number3<number2)
            {
                Console.WriteLine("Number 3 is smallest than other :"+ number3);

            }
            Console.ReadLine();
        }
    }
}
