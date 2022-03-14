using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter a point with two coordinates:");
            Console.Write("x= ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("y= ");
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= 200 || y >= 0 && y <= 100)
            {
                Console.WriteLine("Enter a point's x- and y-coordinates: " + x + "," + y);
                Console.WriteLine("The point is in the triangle.");
            }
            else 
            {
                Console.WriteLine("Enter a point's x- and y-coordinates: " + x + "," + y);
                Console.WriteLine("The point is not in the triangle.");
            }
                Console.ReadLine();
           
        }
    }
}
