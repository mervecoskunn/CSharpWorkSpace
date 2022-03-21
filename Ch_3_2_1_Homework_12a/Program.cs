using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homework_12a
{
    internal class Program
    {
        static void Main(string[] args)
        {    //Verilen bir string için;
            //a. verilen bir indexe verilen bir stringi yerleştir
            //Örn; "abc" stringinin 1.indexine "XYZ" koyarsan "aXYZbc" üretmeli

            string str1 = "abc";
            string str2 = "XYZ";
            string newString = "";
            int index = 1;
            int i = 0;
            for (i = 0; i <index; i++)
                newString+= str1.ElementAt(i); 

            for (i = 0; i < str2.Length; i++)
                newString+=str2.ElementAt(i);
            for (i = 1; i < str1.Length; i++)
                newString+=str1.ElementAt(i);
            Console.WriteLine("New string : "+ newString);
            Console.ReadLine();
            
        }
    }
}
