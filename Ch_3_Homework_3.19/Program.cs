using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (Compute the perimeter of a triangle) Write a program that reads three edges for 
              a triangle and computes the perimeter if the input is valid. Otherwise, display that 
              the input is invalid. The input is valid if the sum of every pair of two edges is 
              greater than the remaining edge.*/

            Console.Write("Enter a:");
            double a,b,c;
            Double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter b:");
            Double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter c:");
            Double.TryParse(Console.ReadLine(), out c);
            if (a+b>c &&  a+c>b && b+c>a )
            {
                double perimeter = a + b + c;
                Console.WriteLine("Perimeter= "+perimeter);
            }
            Console.ReadLine();

        }
    }
}
