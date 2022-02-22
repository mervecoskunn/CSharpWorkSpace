using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_1_Homework_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculate average acceleration!");
            Console.Write("Enter the first velocity: ");
            double V0;
            Double.TryParse(Console.ReadLine(), out V0);
            Console.Write("Enter the ending velocity: ");
            double V1;
            Double.TryParse(Console.ReadLine(), out V1);
            Console.Write("Enter the time span:  ");
            double t;
            Double.TryParse(Console.ReadLine(), out t);
            double a;
            a = (V1 - V0) / t;
            Console.WriteLine("The average acceleration is " + a);
            Console.ReadLine();
        }
    }
}
