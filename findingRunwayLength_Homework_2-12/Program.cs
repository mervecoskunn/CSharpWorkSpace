using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findingRunwayLength_Homework_2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the finding runway lenght program!");
            Console.Write("Enter speed: ");
            double V;
            double.TryParse(Console.ReadLine(), out V);
            Console.Write("Enter acceleration: ");
            double a;
            double.TryParse(Console.ReadLine(),out a);
            double lenght = (V * V) / (2 * a);
            Console.WriteLine("The minimum runway lenght for this airplane is "+ lenght);
            Console.ReadLine();

        }
    }
}
