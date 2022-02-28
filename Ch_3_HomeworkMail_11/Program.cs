using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_HomeworkMail_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            switch (number)
            {
               case 0:
                    Console.WriteLine(number +":"+" zero");break;
                    case 1:
                    Console.WriteLine(number +":"+"one");break;
                case 2:
                    Console.WriteLine(number +":"+" two");break;
                case 3:
                    Console.WriteLine(number +":"+" three");break;
            }

            Console.ReadLine();
        }
    }
}
