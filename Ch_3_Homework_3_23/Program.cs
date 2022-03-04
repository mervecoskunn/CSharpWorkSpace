using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TODO
             * input al 2 kordinat x,y
             * kontrol et icinde bir noktada mi yokda degil mi
             * 
             */
            double x2, y2;
            Console.WriteLine("Enter a point with two coordinates:");
            Console.Write("x2= ");
            Double.TryParse(Console.ReadLine(), out x2);
            Console.Write("y2= ");
            Double.TryParse(Console.ReadLine(), out y2);
            
            if (-5 <= x2 && x2 <= 5 && -2.5 <= y2 && y2 <= 2.5)
            {
                Console.WriteLine("Point (" + x2 + "," + y2 + ") is in the rectangle");

            }
            else
                Console.WriteLine("Point (" + x2 + "," + y2 + ") is not in the rectangle");

            Console.ReadLine();
        }
    }
}
