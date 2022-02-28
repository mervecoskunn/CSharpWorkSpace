using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_HomeworkMenuSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the payment options menu!");
            Console.WriteLine("[1]- To Pay With Credit Cart");
            Console.WriteLine("[2]- To Pay With Cash");
            Console.WriteLine("[3]- To Pay with Swish");
            Console.WriteLine("[4]- To Pay with Invoice");
            Console.Write("Please,make a choice from the menu:  ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You will make a payment by credit cart!"); break;
                case 2:
                    Console.WriteLine("You will make a payment with cash!"); break;
                case 3:
                    Console.WriteLine("You will make a payment  via switch!"); break;
                case 4:
                    Console.WriteLine("You will make a payment with invoice!"); break;
                default:
                    Console.WriteLine("You made an invalid choice!Please,select a number between 1 and 4!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
