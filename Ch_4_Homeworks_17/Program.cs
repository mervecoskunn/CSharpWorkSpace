using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4_Homeworks_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BasHarfiBuyukYap("derin coskun");

            SonunaNoktaKoy("I love C#");

            int count = CountPunctuation("11...........");
            Console.WriteLine("Count punctuation: " + count);

            int total = CountTurkishLetters("Göktuğ Işık İzmir");
            Console.WriteLine("Turkish letters count: " + total); 

            int countUpperCase = CountUpperCaseLetters("MERVE coskun");
            Console.WriteLine("Count uppercase letters: " + countUpperCase);

            int countWords = CountWords("Merve Coskun Derin Coskun Deniz Coskun.");
            Console.WriteLine("Count words: " + countWords);

            string new1 =ToUpper("ben c# ögreniyorum.");
            Console.WriteLine("To Upper: "+new1);

            string new2 = ToLower("BUGUN persemBE.");
            Console.WriteLine("To Lower: "+ new2);
            string new3 = CapitalizeEachWord("merve coskun derin coskun");
            Console.WriteLine("Capitalize each word: "+ new3);
          
            string new5 = Clone("yazilim");
            Console.WriteLine("Clone: "+ new5);

            ContainsCharakter("Merve", 'a');



            Console.ReadLine();
        }
        //1- Capitalize (baş harfi büyük yap) fonksiyonu yaz
        public static void BasHarfiBuyukYap(string str1)
        {

            string str2 = Char.ToUpper(str1.ElementAt(0)).ToString();
            for (int i = 1; i < str1.Length; i++)
            {
                if (str1.ElementAt(i) == ' ')
                {
                    str2 += str1.ElementAt(i);
                    char c = Char.ToUpper(str1.ElementAt(i + 1));
                    str2 = str2 + c.ToString();
                    i++;
                }
                else
                {
                    str2 += str1.ElementAt(i);
                }

            }
            Console.WriteLine("str1: " + str1 + "\nstr2: " + str2);

        }
        //2-Add period (sonuna nokta koy) fonksiyonu yaz
        public static void SonunaNoktaKoy(string str1)
        {
            Console.WriteLine(str1 + ".");
        }
        //3- Count punctuations fonksiyonu yaz
        public static int CountPunctuation(string str1)
        {
            int punctuationCount = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsPunctuation(str1.ElementAt(i)))
                    punctuationCount++;
            }
            return punctuationCount;

        }
        // 4- Count turkish letters fonksiyonu yaz
        public static int CountTurkishLetters(string str1)
        {
            int TurkishLettersCount = 0;
            for (int i = 0; i < str1.Length; i++)
            {

                if (str1.ElementAt(i) == 'ç' || str1.ElementAt(i) == 'ğ' || str1.ElementAt(i) == 'İ' || str1.ElementAt(i) == 'ü' || str1.ElementAt(i) == 'ş' || str1.ElementAt(i) == 'ı')
                    TurkishLettersCount++;
            }
            return TurkishLettersCount;


        }
        // 5- Count uppercase letters fonksiyonu yaz
        public static int CountUpperCaseLetters(string str1)
        {
            int countUpperCaseLetters = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsUpper(str1.ElementAt(i)))
                    countUpperCaseLetters++;
            }
            return countUpperCaseLetters;
        }
        // Count words fonksiyonu yaz
        public static int CountWords(string str1)
        {
            int countWords = 0;
            for (int i = 0; i < str1.Length; i++)// son kelimeyi dahil edemedim.
            {
                if (str1.ElementAt(i) == ' ')
                    countWords++;
            }
            return countWords+1;
        }
        // 7- ToUpper fonksiyonu yaz
        public static string ToUpper(string str1)
        {
            string str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {
                str2 += Char.ToString(Char.ToUpper(str1.ElementAt(i)));
               
            }
            return str2;
        }
        // 8- ToLower fonksiyonu yaz
        public static string ToLower(string str1)
        {
            string str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {
               
                str2 += Char.ToString(Char.ToLower(str1.ElementAt(i)));
                
            }
            return str2 ;
        }
        // 9- Capitalize each word fonksiyonu yaz
        public static string CapitalizeEachWord(string str1)
        {
            
            string str2 = Char.ToUpper(str1.ElementAt(0)).ToString();
            for (int i = 1; i < str1.Length; i++)
            {
                if (str1.ElementAt(i) == ' ')
                {
                    str2 += str1.ElementAt(i);
                    char c = Char.ToUpper(str1.ElementAt(i + 1));
                    str2 = str2 + c.ToString();
                    i++;
                }
                else
                    str2 += str1.ElementAt(i);
            }
            return str2;

        }
        //11- Capitalize turkish letters, lower others fonksiyonu yaz
        //public static string CapitalizeTurkishLettersLowerOthers(string str1)
        //{
            


        //}
        // Clone fonksiyonu yaz
        public static string Clone(string str1)
        {
            string str2 = (string)str1.Clone();
            return str2;
        }
        //Contains character fonksiyonu yaz
        public static void ContainsCharakter(string str1,char c)
        {
            if (str1.Contains(c))
                Console.WriteLine(str1 + " " + c + " karakterini icermektedir.");
            else
                Console.WriteLine(str1 + " " + c + " karakterini icermemektedir.");
        }



    }
}
