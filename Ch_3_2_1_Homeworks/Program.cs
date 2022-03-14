using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToUpper 
            //Hw7.a
            string str1 = "merve";
            string str2 = str1.Substring(1);
            Console.WriteLine(Char.ToUpper(str1.First())+str2);


            // sonuna nokta koyan
            str1 = "C# Programming";
             string newString = str1.Insert(str1.Length,"."); 
            Console.WriteLine(newString);
            // Console.WriteLine(str1+".");
            // str1.Concat(".");


            //icindeki noktalama isaretlerini sayan
            str1 = "1.Java, 2.C#!!";
            int totalPunktuation = 0; 
            for (int i = 0; i < str1.Length; i++)
            {
               
                if (Char.IsPunctuation(str1.ElementAt(i))) 
                {
                    Console.WriteLine("Character is a punctuation.");
                     totalPunktuation++;
                }

            }
            Console.WriteLine("Total punktuation: "+ totalPunktuation);


            // buyuk harfe cevir
            str1 = "merve coskun";
            for (int i = 0; i < str1.Length; i++)
            { 
               char c = Char.ToUpper(str1.ElementAt(i));
               string newC = Char.ToString(Char.ToUpper(str1.ElementAt(i)));
                
                Console.WriteLine( "new C : " + newC);   
            }
           
            //kucuk harfe cevir
            str1 = "MERVE COSKUN";
            for (int i = 0; i < str1.Length; i++)
            {
                char c = Char.ToLower(str1.ElementAt(i));

            }

            // HER KELIMENIN BAS HARFINI BUYUK HARFE CEVIR
            str1 = "merve coskun";
            string str3 = Char.ToUpper(str1.ElementAt(0)).ToString();
            for (int i = 1; i < str1.Length; i++)
            {
                if (str1.ElementAt(i)==' ')
                {
                    str3 += str1.ElementAt(i);
                    char c = Char .ToUpper(str1.ElementAt(i+1));
                    str3 = str3 + c.ToString();
                    i++;

                }
                else
                {
                    str3 += str1.ElementAt(i);
                }

            }
            Console.WriteLine(str3);

            Console.ReadLine();
            
        }
    }
}
