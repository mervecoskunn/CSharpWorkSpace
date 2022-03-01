using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            Console.Write("Enter weight in pounds: ");
            Double.TryParse(Console.ReadLine(), out weight);
            double weightKg = weight * 0.45359237;
            double heightFeet;
            Console.Write("Enter feet: ");
            Double.TryParse(Console.ReadLine(), out heightFeet);
            double heightInches;
            Console.Write("Enter inches: ");
            Double.TryParse(Console.ReadLine(), out heightInches);
            double height = (heightFeet * 0.3048) + (heightInches * 0.0254);

             double BMI =weightKg / (height*height);
            Console.WriteLine("BMI is " + BMI);
            if (BMI < 18.5)

                Console.WriteLine("Underweight");
            else if (BMI < 25)
                Console.WriteLine("Normal");
            else if (BMI < 30)
                Console.WriteLine("Overweight");

            
           
            
            Console.ReadLine();
        }
    }
}
