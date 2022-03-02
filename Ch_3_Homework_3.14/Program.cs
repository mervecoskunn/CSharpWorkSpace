using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
             int result = random.Next(0,2);
            Console.Write("Guess: ");
            int guess;
            int.TryParse(Console.ReadLine(), out guess);
            if (guess==0 || guess==1)
            {
                if (guess==result)
                {
                    Console.WriteLine("You won!!!");
                }
                else
                {
                    Console.WriteLine("You lost!!!");
                    
                }
                

            }
            else
            {
                Console.WriteLine("Please,enter 0 or 1.");
            }
            




            Console.ReadLine();
        }
    }
}
/*
 * 
 * 
 */
