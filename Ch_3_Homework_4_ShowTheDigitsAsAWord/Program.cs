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
            else if (number == 1)
                Console.WriteLine("The number is one");
            else if (number == 2)
                Console.WriteLine("The number is two.");
            else if (number == 3)
                Console.WriteLine("The number is three.");
            else if (number == 4)
                Console.WriteLine("The number is four.");
            else if (number == 5)
                Console.WriteLine("The number is five.");
            else if (number == 6)
                Console.WriteLine("The number is six.");
            else if (number == 7)
                Console.WriteLine("The number is seven.");
            else if (number == 8)
                Console.WriteLine("The number is eight.");
            else if (number == 9)
                Console.WriteLine("The number is nine.");
            else 
                Console.WriteLine("Please select between 0 and 9!");
            Console.ReadLine();
            







        }
    }
}
