using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsExercisesExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int number;
            int result = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if ((number>0)&& (number%2==1))
                {
                    result *= number;
                }
                
            }
            Console.WriteLine("Multiplication of positive and odd: " + result);
            Console.ReadLine();





        }
    }
}
