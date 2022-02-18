using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfCyclinder
{
    internal class VolumeOfCyclinder
    {
        static void Main(string[] args)
        {
            //(Compute the volume of a cylinder) Write a program that reads in the radius
            //and length of a cylinder and computes the area and volume using the following
            // formulas:
            //area = radius * radius * p
            //volume = area * length

            
            Console.WriteLine("Welcome to volume calculator");
            Console.Write("Enter radius: ");
            double r;
            Double.TryParse(Console.ReadLine(), out r);
            Console.Write("Enter length: ");
            double l;
            Double.TryParse(Console.ReadLine(),out l);
            double p = 3.14;
            double area = r*r*p;
            Console.WriteLine("Area: " +area);

            double volume = area * l;
            Console.WriteLine("Volume: "+ volume);





            Console.ReadLine();


        }
    }
}
