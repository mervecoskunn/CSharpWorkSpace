using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display single digits of numbers
            int limit = 5;
            int number;
            int inputNumber = 1;
            int count = 0;
            while (inputNumber<=limit)
            {
                Console.WriteLine("Enter an integer: ");
                Int32.TryParse(Console.ReadLine(), out number);
                if (inputNumber>=0 && inputNumber<=9)
                {
                    count++;
                    inputNumber++;

                }

            }
            Console.WriteLine("You have entered "+ count + " digits");
            Console.ReadLine();
        }  



        }
    }
