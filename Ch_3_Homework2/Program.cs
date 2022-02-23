using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            var c = 30;
            if (a < 0)
                Console.WriteLine("a*b*c= " + "The result will be negative.");
            if (b < 0)
                    Console.WriteLine("a*b*c= " + "The result will be negative.");
            if (c < 0)
                        Console.WriteLine("a*b*c= "+ "The result will be negative.");
            if (a > 0 && b > 0 && c > 0)
                Console.WriteLine("a*b*c= "+ "The result will be positive.");

            Console.ReadLine();
                
            


            
        }
    }
}