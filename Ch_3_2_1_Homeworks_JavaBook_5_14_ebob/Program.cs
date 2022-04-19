using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_14_ebob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ebob(10,50)
            int n1 = 10;
            int n2 = 50;
            int min = Math.Min(n1,n2);
            int ebob=0;
            for (int divider = 1; divider <= min ; divider++)
            {
                if (n1 % divider == 0 && n2 % divider == 0)
                    ebob = divider;
                Console.WriteLine("ebob( "+n1+","+n2+ ")"+ " ="+ebob);
                Console.ReadLine();
                

                

            }
        }
    }
}
