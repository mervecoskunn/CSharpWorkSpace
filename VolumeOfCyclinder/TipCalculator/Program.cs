using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Financial application: calculate tips) Write a program that reads the subtotal
            //and the gratuity rate, then computes the gratuity and total. For example, if the
            //user enters 10 for subtotal and 15 % for gratuity rate, the program displays $1.5
            // as gratuity and $11.5 as total.

            /* TO DO LIST
             * 1-subtotal iste
             * 2-gratuity rate iste
             * 3- gratuity hesapla
             * 4-total hesapla
             * 5-yazdir totali
             */
            Console.Write("Enter subtotal: ");
            double subtotal;
            Double.TryParse(Console.ReadLine(), out subtotal);
            Console.Write(" Enter gratuity: ");
            double gratuityRate;
            Double.TryParse(Console.ReadLine(),out gratuityRate);
            double gratuity = subtotal * gratuityRate / 100;
            Console.WriteLine("Gratuity: "+ gratuity);
            double total = subtotal + gratuity;
            Console.WriteLine("Total:"+total);
            Console.ReadLine();


        }

    }
}
