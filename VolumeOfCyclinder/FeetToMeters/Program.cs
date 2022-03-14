using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToMeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Convert feet into meters) Write a program that reads a number in feet, converts it
            //to meters, and displays the result.One foot is 0.305 meter.

            Console.WriteLine("Welcome to feet converter!");
            Console.Write("Enter feet: ");
            double f;
            Double.TryParse(Console.ReadLine(), out f);
            double meter = f * 0.305;
            Console.WriteLine("Result:" + meter);
            Console.ReadLine();




        }
    }
}
