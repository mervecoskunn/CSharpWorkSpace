using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            (Random point) Write a program that displays a random coordinate in a rectangle. 
           The rectangle is centered at (0, 0) with width 100 and height 200.*/

            Console.Write("The coordinate in a rectangle: ");
            // Generate random width and height
            Random random = new Random();
            double x = random.Next(-50,50);
            double y = random.Next(-100,100);


            // Display coordinate
            Console.WriteLine(x+","+y);
            Console.ReadLine();
            
        }
    }
}
