using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_4_ShowTheDigitsAsAWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number between 0 and 9: ");
            int.TryParse(Console.ReadLine(), out  number);
            if (number == 0)
                Console.WriteLine("The number is zero");
            if (number == 1)
                Console.WriteLine("The number is one");
            if (number == 2)
                Console.WriteLine("The number is two.");
            if (number == 3)
                Console.WriteLine("The number is three.");
            if (number == 4)
                Console.WriteLine("The number is four.");
            if (number == 5)
                Console.WriteLine("The number is five.");
            if (number == 6)
                Console.WriteLine("The number is six.");
            if (number == 7)
                Console.WriteLine("The number is seven.");
            if (number == 8)
                Console.WriteLine("The number is eight.");
            if (number == 9)
                Console.WriteLine("The number is nine.");
            Console.ReadLine();
            







        }
    }
}
