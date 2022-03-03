using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TODO 
             * kullanicidan input al 
             * year
             * month ---->january 1 i 13 olarak tanimla ve february 2 yi 14 olarak guncelle.
             * day
             * formulu tanimla
             * swich ile sonuc ne ise kosullari yazdir
             */

            Console.Write("Enter year: ");
            int year;
            int.TryParse(Console.ReadLine(), out year);
            Console.Write("Enter month(1-12): ");
            int m;
            int.TryParse(Console.ReadLine(), out m);
            if (m == 1)
            {
                m = 13;
                year = year - 1;
            }
            if (m == 2)
            {
                year = year - 1;
                m = 14;
            }
            Console.Write("Enter day of the month (1-31): ");
            int q;
            int.TryParse(Console.ReadLine(), out q);
            int h;
            int j = year / 100;
            int k = year % 100;

            h = (q + (26 * (m + 1)) / 10 + k + (k / 4) + (j / 4) + 5 * j) % 7;

            switch (h)
            {

                case 0:
                    Console.WriteLine(" Day of the week is Saturday.");
                    break;

                case 1:
                    Console.WriteLine("Day of the week is Sunday.");
                    break;

                case 2:
                    Console.WriteLine("Day of the week is Monday.");
                    break;

                case 3:
                    Console.WriteLine("Day of the week is Tuesday.");
                    break;

                case 4:
                    Console.WriteLine("Day of the week is Wednesday.");
                    break;

                case 5:
                    Console.WriteLine("Day of the week is Thursday.");
                    break;

                case 6:
                    Console.WriteLine("Day of the week is Friday.");
                    break;
            }
            Console.ReadLine();


        }
    }
}
