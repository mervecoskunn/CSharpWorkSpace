using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HW10: iki stringin eşitliğini kontrol eden program

            string str1 = "Merve Coskun";
            string str2 = "Merve Coskun";
            int i = 0;
            int j = 0;
            bool IsTwoStringisEqual = true;
            while (i<str1.Length)
            {
                if (str1.ElementAt(i) != str2.ElementAt(j))
                {
                    Console.WriteLine("String 1 : "+str1 + "\nString 2: "+str2+ " \nThey are not equal.");
                    IsTwoStringisEqual = false;
                    break;
                }
                i++;
                j++;


            }
            if (IsTwoStringisEqual)
                Console.WriteLine("String 1 : " + str1  + "\nString 2: " + str2 + "\nThey are equal.");
            Console.ReadLine();
        }
    }
}
