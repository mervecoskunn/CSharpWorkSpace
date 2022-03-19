using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadLeft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PadLeft

            string str1 = "Merve";
            string str2 = "";
            char c = '?';
            int lenght = 10;
            int end =lenght-str1.Length;

            if (str1.Length<10)
            {
                for (int i = 0; i < end; i++)
                    str2 += c;
                Console.WriteLine("New string : "+ str2 + str1);
            }
            Console.ReadLine();

        }
    }
}
