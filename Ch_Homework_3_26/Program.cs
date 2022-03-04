using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_Homework_3_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TODO
             * KULLANICIDAN INPUT AL
             * IF 5 VE 6 YA BOLUNUYORSA TRUE BOLUNMUYORSA FALSE YAZDIR
             * IF INPUT 5 E YADA 6 YA BOLUNUYORSA TRUE BOLUNMUYORSA FALSE YAZDIR
             * IF INPUT BESE YADA 6 YA BOLUNYORSA AMA IKISINE BIRDEN DEGILSE TRUE YADA FALSE YAZDIR.
             */
            Console.Write("Enter an integer: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            Console.Write("Is 10 divisible by 5 and 6?");

            if (number % 5 == 0 && number % 6 == 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.Write("Is 10 divisible by 5 or 6?");
            if (number % 5 == 0 || number % 6 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.Write("Is 10 divisible by 5 or 6, but not both?");
            if (number % 5 == 0 ^ number % 6 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            // Basitleştirilmiş hali
            Console.WriteLine("Is 10 divisible by 5 and 6? " + (number % 5 == 0 && number % 6 == 0));
            Console.WriteLine("Is 10 divisible by 5 or 6? " + (number % 5 == 0 || number % 6 == 0));
            Console.WriteLine("Is 10 divisible by 5 or 6, but not both? " + (number % 5 == 0 ^ number % 6 == 0));

            bool b;
            if (number % 5 == 0)
                b = true;
            else
                b = false;

            b = number % 5 == 0;

            Console.ReadLine();
        }
    }
}
