using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_HomeworkMail_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choice a number between 0 and 9: ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1: 
                case 2: 
                case 3: Console.WriteLine("You have earned 10 times the points! Point:  " + (choice * 10)); break;
                case 4: 
                case 5: 
                case 6: Console.WriteLine("You have earned 100 times the points! Point: " + (choice * 100)); break;
                case 7: 
                case 8: 
                case 9: Console.WriteLine("You have earned 1000 times the points! Point:" + (choice * 1000)); break;

                default:
                    Console.WriteLine("There is a problem!Please try again!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
