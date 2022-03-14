using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_SomeFunctionsReviewExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math.Max(6,4);
            Console.WriteLine("Math.Max(6,4):"+Math.Max(6,4));
            //Math.Min
            Console.WriteLine("Math.Min(2,6):"+Math.Min(2,6));
            //Math.Round
            Console.WriteLine("Math.Round(Math.PI,4):"+Math.Round(Math.PI,4));
            Console.WriteLine("Math.Round(Math.PI):"+Math.Round(Math.PI));
            //Math.Floor
            Console.WriteLine("Math.Floor(3.11):"+Math.Floor(3.11));
            //Math.Ceiling
            Console.WriteLine("Math.Ceiling(3.11):"+Math.Ceiling(3.11));
            // string

            string str1 = "C# Programming";
            Console.WriteLine("Str 1 Lenght: "+ str1.Length);
            //
            int strLen = "Java Programming".Length;
            Console.WriteLine("strLen Lenght: "+ strLen);
            // contains
            Console.WriteLine("str1.Contains(´C#´)"+str1.Contains("C#"));
            Console.WriteLine("str1.Contains(`C++`)" + str1.Contains("C++"));

            //if
            if (str1.Contains("C#"))
                Console.WriteLine("Contains C#");
            //equals
            if (str1.Equals("C# Programming"))
                Console.WriteLine("String is C# programming");
            // Insert
            string str2 = str1.Insert(3,"and Java ");
            Console.WriteLine("New string: "+ str2);
            Console.WriteLine("Old string: "+ str1);

            //Replace
            str2 = str1.Replace(" ","_");
            Console.WriteLine("new string : "+ str2);
            Console.WriteLine("Old string : "+ str1);

            //Substring
           str2 = str1.Substring(3);
            Console.WriteLine("New string : "+ str2);
            str2 = str1.Substring(0,3);
            Console.WriteLine("New string : "+ str2);

            // Index of 
            int ind = str1.IndexOf('#');
            Console.WriteLine("Index of # : "+ ind);
            Console.WriteLine("Index of m : "+ str1.IndexOf('m'));
            Console.WriteLine("Last index of m : "+ str1.LastIndexOf('m'));

            //ElementAt
            char a = str1.ElementAt(3);
            Console.WriteLine("Character at index 2 : " +  a);
            Console.WriteLine("Character at index 5 : "+ str1.ElementAt(5));
            Console.WriteLine("Character at index 9 : "+ str1.ElementAt(9));

            //First and Last
            Console.WriteLine("Last character : "+ str1.Last());
            Console.WriteLine("First character :"+ str1.First());

            // Min and Max
            str1 ="923456781";
            Console.WriteLine("Max: "+ str1.Max());
            Console.WriteLine("Min: "+ str1.Min());

            // Char.IsDigit
            Console.WriteLine("Char.IsDigit('1'): "+ Char.IsDigit('1'));
            Console.WriteLine("Char.IsDigit('a'): "+ Char.IsDigit('a'));

            str1 = "1.C#";

            if (Char.IsDigit(str1.First())) 
                Console.WriteLine("The first character is  a digit.");
            // isLetter
            Console.WriteLine("Char.IsLetter('C')"+Char.IsLetter('C'));
            Console.WriteLine("Char.Isletter('#')"+Char.IsLetter('#'));
            //ToUpper and ToLower

            string c = Char.ToUpper('c').ToString();
            Console.WriteLine(c);

            string M = char.ToLower('M').ToString();
            Console.WriteLine(M);

            string x = Char.ToString(Char.ToLower('x'));

        






            Console.ReadLine();
        }
    }
}
