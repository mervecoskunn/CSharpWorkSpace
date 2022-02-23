using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_HomeworkFindBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;
            int c = 10;
            if (a>b)
            {
                Console.WriteLine("a bigger than b.");
                if (b>c)
                {
                    Console.WriteLine("a is also  biggest number.");
                }
                Console.ReadLine();
            }
        }
    }
}
