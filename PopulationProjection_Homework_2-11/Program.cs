using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationProjection_Homework_2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the population projection program!");
            Console.Write("Enter the number of years: ");
            int year;
            int.TryParse(Console.ReadLine(), out year);
            int day = year * 365;
            int hour = day* 24; 
            int minute = hour * 60;
            int second = minute * 60;
            
            int population = 312032486 +((second / 7) + (second / 45) - (second / 13));


            Console.Write("The population in 5 years is " + population);
            Console.ReadLine();
        }
    }
}
