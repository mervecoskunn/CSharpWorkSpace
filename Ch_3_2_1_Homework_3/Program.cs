using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //icindeki noktalama isaretlerini sayan while dongusu ile
            string  str1 = "1.Java, 2.C#!!";
            int i = 0;
            int punctuation=0;
            while (i<str1.Length)
            {
                if (Char.IsPunctuation(str1.ElementAt(i)))
                {
                    punctuation++;
                }
                i++;
            }
            Console.WriteLine("Total Punctuation: " + punctuation);

            Console.ReadLine();
        }
        
     
	


    }
}
