using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*verilen stringin çift sayılı indexlerini gez ve bu indexlerde varsa sesli harfleri ve sayıları say
            // cift sayili indexleri bulamadim ve sesli harfi ayiramadim.(cift sayili indexleri i yi ikiser ikiser atlayarak bulabilirz bence)
            string str2 = "1.Merve 2.Derin";
            int totalDigit = 0;
            int totalLetter = 0;

            for (int i = 0; i < str2.Length; i++)
            {
                if (Char.IsDigit(str2.ElementAt(i)))
                {
                    Console.WriteLine(str2.ElementAt(i) + "  : is a digit.");
                    totalDigit++;
                }
                if (Char.IsLetter(str2.ElementAt(i)))
                {
                    Console.WriteLine(str2.ElementAt(i) + "  : is a letter.");
                    totalLetter++;
                }
                
                i++;
            }
            Console.WriteLine("Total letters : " + totalLetter);
            Console.WriteLine("Total digits : " + totalDigit);
            Console.ReadLine();*/

            //verilen stringin tek sayılı indexlerini gez ve bu indexlerde varsa sesli harfleri say

            //string str3 = "Derin";
            //int totalLetters = 0;
            //for (int i = 1; i < str3.Length; i += 2)
            //{
            //    if (Char.IsLetter(str3.ElementAt(i)))
            //    {
            //        Console.WriteLine(str3.ElementAt(i) + " : is a letter.");
            //        totalLetters++;
            //    }
                
            //}
            //Console.WriteLine("Total letters: " + totalLetters);
            //Console.ReadLine();

            //string str3 = "Derin";                                // tek indexler bulundu fakat sesli harfleri ayirt edemedi.
            //int i = 1;
            //int totalLetters = 0;
            //while (i<str3.Length)
            //{
            //    if (Char.IsLetter(str3.ElementAt(i)))
            //    {
            //        Console.WriteLine(str3.ElementAt(i) + " : is a letter.");
            //        totalLetters++;
            //    }
            //    i += 2;
            //}


            //Console.WriteLine("Total Letters: " + totalLetters);
            //Console.ReadLine();

            // icindeki turkce karakterleri say       HATALI!!!!!!!
        //   string str1 = "akşam yemeği";
        //   string str2 = "ş,ğ,ç";
        //   int turkishLetters = 0;


        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        if (str1.Contains(str2[i]))
        //        {
        //            Console.WriteLine("It is a letter of turkish alfabet.");
        //            turkishLetters++;
        //        }
        //        i++;
                
        //    }
        //    Console.WriteLine("Total Turkish Letters : " + turkishLetters);
        //    Console.ReadLine();
        //}
    }
}
