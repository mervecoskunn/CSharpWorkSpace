using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*HW11: Verilen bir string için;
        *a. verilen bir indexine verilen bir karakteri koy. 
            Örn; "abc" stringinin 1. indexine 'X' koyarsan "aXbc" üretmeli
        *b. verilen bir indexteki karakteri sil. 
            Örn; "abc" stringinin 1. indexindeki karakteri silersen "ac" üretmeli
        *c. verilen bir indexteki karakteri verilen başka bir karakter ile değiş
            Örn; "abc" stringinin 1. indexindeki karakteri X ile değişirsen "aXc" üretmeli
        d. verilen bir stringin başındaki ve sonundaki boşlukları sil
            Örn; "   abc  " -> "abc"
        e. verilen bir stringin sadece başındaki boşlukları sil
            Örn; "   abc  " -> "abc  "
        f. verilen bir stringin sadece sonundaki boşlukları sil
                       Örn; "   abc  " -> "   abc"
         */

            /* *a. verilen bir indexine verilen bir karakteri koy. 
            Örn; "abc" stringinin 1. indexine 'X' koyarsan "aXbc" üretmeli
             */

            //string str1 ="abc";
            //char c = 'X';
            //int i = 0;
            //string str2 = "";
            //string str3 = "";
            //string str4 = "";

            //for ( i = 0; i <1; i++)
            //{
            //   str2+=str1.ElementAt(i);


            //}
            //for ( i = 1; i < str1.Length; i++)
            //{
            //    str3 += str1.ElementAt(i);

            //}
            //Console.WriteLine("NewString: " + str2+c+str3);
            //Console.ReadLine();

            // *b. verilen bir indexteki karakteri sil. 

            //string string1 = "abc";
            //string string2 = "";
            //string string3 = "";
            //string newString = "";
            //int i = 0;

            //for ( i = 0; i < 1; i++)
            //    string2+=string1.ElementAt(i);
            //for (i = 2; i < string1.Length; i++)
            //    string3 += string1.ElementAt(i);
            //newString= string2 + string3;
            //Console.WriteLine("New string : " + newString);
            //Console.ReadLine();

            //*c.verilen bir indexteki karakteri verilen başka bir karakter ile değiş
            //string str1 = "abc";
            //string str2 = "";
            //string str3 = "";
            //char c = 'X';
            //int index = 2;

            //for (int i = 0; i < index; i++)
            //    str2 += str1.ElementAt(i);
            //for (int i = index+1; i < str1.Length; i++)
            //    str3 += str1.ElementAt(i);
            //Console.WriteLine("New string: " + str2 + c + str3);
            //Console.ReadLine();

            //d.verilen bir stringin başındaki ve sonundaki boşlukları sil
            //string str1 = "...abc.yz.";
            //string str2 = "";
            //int i = 0;
            //int startIndex = 0;
            //int endIndex = 0;

            //for (i = 0; i < str1.Length; i++)
            //{
            //    if (str1.ElementAt(i) != '.')
            //    {
            //        startIndex = i;
            //        break;
            //    }
            //}

            //for (i = str1.Length - 1; i >= startIndex; i--)
            //{
            //    if (str1.ElementAt(i) != '.')
            //    {
            //        endIndex = i;
            //        break;
            //    }
            //}

            //for (i = startIndex; i < endIndex + 1; i++)
            //{
            //    str2 += str1.ElementAt(i);

            //}

            //Console.WriteLine(str2);

            //Console.ReadLine();

            //e.verilen bir stringin sadece başındaki boşlukları sil
            //string str1 = " abc";
            //string str2 = "";
            //int startIndex = 0;
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    if (str1.ElementAt(i)!=' ')
            //    {
            //        startIndex= i;
            //        break;
            //    }
            //}
            //for (int i = startIndex; i < str1.Length; i++)
            //{
            //    str2 += str1.ElementAt(i);
            //}
            //Console.WriteLine(str2);
            //Console.ReadLine();

            // e. çözüm 2
            //string str1 = " abc  xy";
            //string str2 = "";
            //bool hasStarted = false;
            //for (int i = 0; i < str1.Length; i++)
            //{

            //    if (hasStarted)
            //    {
            //        str2 += str1.ElementAt(i);
            //    }
            //    else
            //    {
            //        if(str1.ElementAt(i) != ' ')
            //        {
            //            hasStarted = true;
            //            str2 += str1.ElementAt(i);

            //        }
            //    }

            //}


            //f.verilen bir stringin sadece sonundaki boşlukları sil
            //string str1 = "-abc---";
            //string str2 = "";
            //int endIndex = 0;
            //for (int i = str1.Length-1; i>=0; i--)
            //{
            //    if (str1.ElementAt(i)!='-')
            //    {
            //        endIndex = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i < endIndex+1; i++)
            //{
            //    str2 += str1.ElementAt(i);

            //}
            //Console.WriteLine(str2);
            //Console.ReadLine();



















        }
    }
}
