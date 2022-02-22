using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int i;
            int.TryParse(Console.ReadLine(), out i);
            
            if (i % 5 == 0)
                Console.WriteLine("This number is multiple of 5.");
            else
            {
                Console.WriteLine("This number is not multiple of 5.");
            }
            Console.ReadLine();
            

            
        }
    }
}
