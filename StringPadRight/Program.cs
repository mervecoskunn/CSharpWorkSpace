using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPadRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String PadRight
            string str1 = "Merve";
            string str2 = "";
            int totalLength = 8;
            int i = 0;
            char c = '?';
            int addCharacterLength = totalLength - str1.Length;
            
            if (str1.Length<totalLength)
            {
                for ( i = 0; i < addCharacterLength+1; i++)
                    str2+= c;
                Console.WriteLine("New string: "+ str1 + str2);
            }
            Console.ReadLine();


        }
    }
}
