using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homework_12_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  b. verilen bir karakteri tüm stringden sil
            Örn; "abbc" stringinden b karakterini silersen "ac" üretmeli
            */
            string str1 = "abbc";
            string str2 = "";
            bool b = false; 
            int i = 0;
            for ( i = 0; i < str1.Length; i++)
            {
                if (str1.ElementAt(i)!='b')
                {
                    str2+=str1.ElementAt(i);
                    b = true;
                }
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
