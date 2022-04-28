using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4_Homeworks_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Replace a charakter!");
            ReplaceACharacter("ab--ab--ab--ab",'b','c');
            Console.WriteLine("Replace string!");
            ReplaceWithAString(" ab--ab--ab", "ab", "xd");
            Console.WriteLine("Trim spaces!");
            TrimSpaces(" Merve Coskun ");
            Console.WriteLine("Trim End!");
            TrimEnd("Merve Coskun ");
            Console.WriteLine("Trim Start!");
            TrimStart(" Merve Coskun");
            Console.WriteLine("Compare To!");
            CompareTo("Merve","M");
            Console.ReadLine();



        }
        // 1- Replace a character at an index with another given character (index kontrolü yap)
        public static void ReplaceACharacter(string str, char oldChar, char newChar)
        {
            string str2 = "";
            str2 = str.Replace(oldChar,newChar);
            Console.WriteLine("New string: "+str2);
        }
        //3- Replace all strings: verilen bir stringi verilen başka bir string ile değiştir. Tüm eşleşmeler değiştirlecek
        //Örn; ab--ab--ab stringinde ab stringini xd ile değişirsek xd--xd--xd olur
       public static void ReplaceWithAString(string str, string oldStr,string NewStr )
        {
            string NewString = "";
            NewString = str.Replace(oldStr,NewStr);
            Console.WriteLine("New String: "+ NewString);

        }
        //  4- Trim spaces: Stringin başındaki ve sonundaki boşlukları sil
        public static void TrimSpaces(string str)
        {
            Console.WriteLine("New string:"+str.Trim());
        }
        // 5- Trim end: Stringin sonundaki boşlukları sil
        public static void TrimEnd(string str)
        {
            Console.WriteLine("New String: "+str.TrimEnd());
        }
        //6- Trim start: Stringin başındaki boşlukları sil
        public static void TrimStart(string str)
        {
            Console.WriteLine("New String :"+ str.TrimStart());

        }
        // 7- CompareTo**: İki stringi sözlük sırasına göre kıyasla. soldaki küçükse -1, ikisi eşitse 0, soldaki büyükse 1 bastır
        public static void CompareTo(string str1,string str2)
        {
            Console.WriteLine(str1+" with "+str2+ " compare to " +" : "+ str1.CompareTo(str2));
        }

    }  
}
