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
            // cift sayili indexleri bulamadim ve sesli harfi ayiramadim.(cift sayili indexleri i yi ikiser ikiser atlayarak bulabilirz bence)*/
            //string str2 = "1.Merve 2.Derin";
            //int totalDigit = 0;
            //int totalLetter = 0;
            //char ch;
            //for (int i = 0; i < str2.Length; i+=2)
            //{
            //    ch = str2.ElementAt(i);
            //    if (Char.IsDigit(ch))
            //    {

            //        Console.WriteLine(i + "."+ch);
            //        totalDigit++;
            //    }
            //    else if (ch=='a' || ch == 'e'|| ch == 'i'|| ch == 'o'
            //        || ch == 'u'|| ch == 'ö'|| ch == 'ü'|| ch == 'ı')
            //    {
            //        Console.WriteLine(i + "." + ch);
            //        totalLetter++;
            //    }

            //}
            //Console.WriteLine("Total letters : " + totalLetter);
            //Console.WriteLine("Total digits : " + totalDigit);
            //Console.ReadLine();

            // 2. çözüm
            //totalDigit = 0;
            //totalLetter = 0;
            //string vowels = "aeıioüoö";
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    ch = str2.ElementAt(i);
            //    if (Char.IsDigit(ch))
            //        totalDigit++;
            //    else if (vowels.Contains(ch))
            //        totalLetter++;

            //}


            //verilen stringin tek sayılı indexlerini gez ve bu indexlerde varsa sesli harfleri say

            //string str3 = "Derin";
            //int totalLetters = 0;
            //string vowels = "aeıioüoö";
            //for (int i = 1; i < str3.Length; i += 2)
            //{
            //    if (vowels.Contains(str3.ElementAt(i)))
            //    {
            //        totalLetters++;
            //    }

            //}
            //Console.WriteLine("Total letters: " + totalLetters);
            //Console.ReadLine();

            //string str3 = "Derin";
            //int i = 1;
            //int totalLetters = 0;
            //string vowels = "aeıioüoö";
            //while (i < str3.Length)
            //{
            //    if (vowels.Contains(str3.ElementAt(i)))
            //    {
            //        totalLetters++;
            //    }
            //    i += 2;
            //}


            //Console.WriteLine("Total Letters: " + totalLetters);
            //Console.ReadLine();

            // icindeki turkce karakterleri say      
            string str1 = "akşam yemeği";
            string str2 = "şğç";
            int turkishLetters = 0;


            for (int i = 0; i < str1.Length; i++)
            {
                if (str2.Contains(str1.ElementAt(i)))
                {
                    turkishLetters++;
                }
                i++;

            }
            Console.WriteLine("Total Turkish Letters : " + turkishLetters);
            Console.ReadLine();
        }
    }
}
