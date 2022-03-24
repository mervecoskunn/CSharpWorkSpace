using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (Conversion from miles to kilometers) Write a program that displays the follow-
            //ing table(note that 1 mile is 1.609 kilometers):

            Console.WriteLine("Miles\tKilometers");

            for (int mile = 1; mile < 11; mile++)
            {
                double kilometer;
                kilometer = mile * 1.609;
                Console.WriteLine(mile +"\t"+kilometer);
            }
            Console.ReadLine();
        }
    }
}
