using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Methods_Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method for BMI
            Console.Write("Enter your weight(kg): ");
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Enter your height(m): ");
            double height;
            double.TryParse(Console.ReadLine(), out height);
            double BMI=CalculateBMI(weight, height);
            if (BMI < 18.5)
            {
                Console.WriteLine("BMI is "+ Math.Round(BMI, 2) + " Underweight");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("BMI is " + Math.Round(BMI, 2) + " Normal");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("BMI is " + Math.Round(BMI, 2) + " Overweight");
            }
            else
            {
                Console.WriteLine("BMI is " + Math.Round(BMI, 2) + " Obese");
            }

            Console.ReadLine();


        }
        public static double CalculateBMI(double weight, double height)
        {
            double BMI = weight/(height*height);
            return BMI;

        }
    }
}
