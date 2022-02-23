using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3_DescendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            if (a<b)
            {
                Console.WriteLine("a smaller than b.");
                if (b<c)
                {
                    Console.WriteLine("b smaller than c."+"\na is also smallest number.");
                    
                }
                Console.ReadLine();
            }
        }
    }
}
