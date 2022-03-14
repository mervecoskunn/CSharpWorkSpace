using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromMinuteToDayCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculate from minutes to days!");
            Console.Write("Enter the number of minutes: ");
            int minute;
            int.TryParse(Console.ReadLine(), out minute);
            int hour = minute /60;
            int day = hour / 24;
            int year = day / 365;
            double days = day % 365;
            Console.WriteLine(minute+" minutes is approximately "+ year+ " years and "+days + " days.");
            


            Console.ReadLine();


        }
    }
}
