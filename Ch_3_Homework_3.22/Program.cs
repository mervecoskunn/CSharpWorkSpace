using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x2, y2;
            Console.WriteLine("Enter a point with two coordinates:");
            Console.Write("x2= ");
            double.TryParse(Console.ReadLine(), out x2);
            Console.Write("y2= ");
            int radius = 10;
            double.TryParse(Console.ReadLine(), out y2);
            double x1 = 0;
            double y1= 0;




            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            if (distance <= 10)
                Console.WriteLine("Point("+x2+","+y2+") is in the circle.");
            else
                Console.WriteLine("Point("+x2+","+y2+") is not in the circle.");




            Console.ReadLine();
        }
    }
}
