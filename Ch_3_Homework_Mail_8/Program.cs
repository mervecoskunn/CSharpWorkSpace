using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_Mail_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1]- For integer or double variables:");
            Console.WriteLine("[2]- For only string variable:");
            Console.Write("Please,make a choice from the menu:  ");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1: Console.WriteLine(choice + 1);break;
                    case 2: Console.WriteLine( "The program appends * at the end.");break;
                
            }
            Console.ReadLine();
        }
    }
}
