using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingEnergy_Homework_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculating energy!");
            Console.Write("Enter the amount of water in kilograms: ");
            double M;
            Double.TryParse(Console.ReadLine(), out M);
            Console.Write("Enter the initial temperature: ");
            double initialTemp;
            Double.TryParse(Console.ReadLine(),out initialTemp);
            Console.Write("Enter the final temperature: ");
            double finalTemp;
            Double.TryParse(Console.ReadLine(),out finalTemp);
            double Q = M * (finalTemp - initialTemp) * 4184;
            Console.WriteLine("The energy needed is "+ Q);
            Console.ReadLine();
        }
    }
}
