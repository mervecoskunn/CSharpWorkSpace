using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_Homework_3_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TODO
             * INPUT AL X1,X2,X3,X4,Y1,Y2,Y3,Y4
             *  if cozum varsa kesisme noktasini yazdir
             * else yoksa cozum paralel yazdir.
             * 
             * 
             * (y1 - y2)x - (x1 - x2)y = (y1 - y2)x1 - (x1 - x2)y1
                (y3 - y4)x - (x3 - x4)y = (y3 - y4)x3 - (x3 - x4)y3
                ax + by = e
                cx + dy = f
            
             * 
             */
            double x1, x2, x3, x4, y1, y2, y3, y4;
            Console.Write("x1= ");
            Double.TryParse(Console.ReadLine(), out x1);
            Console.Write("x2= ");
            Double.TryParse(Console.ReadLine(), out x2);
            Console.Write("x3= ");
            Double.TryParse(Console.ReadLine(), out x3);
            Console.Write("x4= ");
            Double.TryParse(Console.ReadLine(), out x4);

            Console.Write("y1= ");
            Double.TryParse(Console.ReadLine(), out y1);
            Console.Write("y2= ");
            Double.TryParse(Console.ReadLine(), out y2);
            Console.Write("y3= ");
            Double.TryParse(Console.ReadLine(), out y3);
            Console.Write("y4= ");
            Double.TryParse(Console.ReadLine(), out y4);
        }
    }
}
