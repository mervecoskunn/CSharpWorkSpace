using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_9_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HW9:
            // c. verilen iki index ile alt string alan (substring methodu gibi)
            Console.WriteLine("HW9: c. verilen iki index ile alt string alan (substring methodu gibi)");
            string str = "C# programming is fun";
            string substr = "";
            string substr1 = "";
            string substr2 = "";
            string substr3 = "";
            string substr4 = "";
            int start = 3;
            int end = 7;
            // if (end >= str.Length)
            //     end = str.Length;
            //
            if (!(end >= str.Length) && !(start < 0))
            {
                for (int i = start; i < end; i++)
                    substr += str.ElementAt(i);

                Console.WriteLine("substr from 3 to 7 : " + substr);
                Console.WriteLine("str.substring(3,7): " + str.Substring(3, end - start));
            }
            else
                Console.WriteLine("end or start index is not valid");

            if (!(start>end))
            {
                for (int i = start; i < end; i++)
                    substr1 += str.ElementAt(i);

                Console.WriteLine("substr from 3 to 7 is " + substr);
            }
            else
                Console.WriteLine("Start cannot be bigger than end.");
            if (!(end < start))
            {
                for (int i = start; i < end; i++)
                    substr2 += str.ElementAt(i);

                Console.WriteLine("substr from 3 to 7 is " + substr);
            }
            else
                Console.WriteLine("End cannot be smaller than start.");
            if (!(start < 0 && end > str.Length))
            {
                for (int i = start; i < end; i++)
                    substr3 += str.ElementAt(i);

                Console.WriteLine("substr from 3 to 7 is " + substr);
            }
            else
                Console.WriteLine("End or start index is not valid.");
            if (!(start < 0))
            {
                for (int i = start; i < end; i++)
                    substr4 += str.ElementAt(i);

                Console.WriteLine("substr from 3 to 7 is " + substr);
            }
            else
                Console.WriteLine("Start cannot be smaller than 0.");
            Console.ReadLine();









        }
    }
}
