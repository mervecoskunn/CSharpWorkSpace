using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                /*(Find numbers divisible by 5 or 6, but not both) Write a program that displays
                   all the numbers from 100 to 200, ten per line, that are divisible by 5 or 6, but not
                   both.Numbers are separated by exactly one space.*/

            int counter=0;
            int perLineCount = 10;
            
            for (int i = 100; i <=200; i++)
            {
                if (i % 5 == 0 || i % 6 == 0)
                {
                    counter++;
                    if (counter== perLineCount)
                    {
                        Console.WriteLine(i);
                        counter = 0;    
                    }
                        
                    else
                        Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
