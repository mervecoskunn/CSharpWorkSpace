using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_10
{
    internal class Program
    {
        static void Main(string[] args)
        { /* (Find numbers divisible by 5 and 6) Write a program that displays all the num-
              bers from 100 to 1,000, ten per line, that are divisible by 5 and 6.  Numbers are 
              separated by exactly one space.
           */
            int perLineCount = 10;
            int counter = 0;
            for (int i = 100; i <=1000; i++)
            {
                if (i%5==0 && i%6==0 )
                {
                    counter++;
                    if (counter%perLineCount==0)
                        Console.WriteLine(i);
                    else
                        Console.Write(i + " ");
                }
            }
         Console.ReadLine();
        }
    }
}
