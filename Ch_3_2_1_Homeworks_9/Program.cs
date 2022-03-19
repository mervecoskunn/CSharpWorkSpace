using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilen bir string için;
            a.aynısından üreten*/

            //string str = "Merve Coskun";
            //int j = 0;
            //string str2 = "";
            //while (j < str.Length)
            //{
            //    str2+= str.ElementAt(j);
            //    Console.WriteLine(str2);
            //    j++;
            //}
            //Console.WriteLine(str2);
            //Console.ReadLine();






            // a. for ile
            //string str1 = "Merve Coskun";
            //string str3 = "";
            //for (int i = 0; i <str1.Length; i++)
            //    str3+=str1.ElementAt(i);

            //Console.WriteLine("str3: "+str3);
            //Console.ReadLine();

            // b. içinde herhangi bir karakter olup olmadığını bulan

            //string str = "Merve Coskun";
            //bool isCharAvailable = false;
            //char ch = 'e';
            ////int isCharAv = 0;
            ////string charAv = "no";
            //int i = 0;
            //while (i < str.Length)
            //{
            //    if (str.ElementAt(i)==ch)
            //    {
            //        Console.WriteLine(i+". charakter is " + ch);
            //        isCharAvailable = true;
            //        //isCharAv = 1;
            //        //charAv = "yes";
            //    }
            //    i++;
            //}
            // if(!isCharAvailable)
            //    Console.WriteLine("There is no Character " +  ch );



            ////c.verilen iki index ile alt string alan(substring methodu gibi)    // substring kullanildi!!!!!
            //string string1 = "Merve Coskun";
            //string str2 = "";
            //int i = 6;

            //while (i<string1.Length)
            //{
            //    str2 += string1.Substring(i);
            //    Console.WriteLine("str2: "+str2);
            //    break;
            //    i++;

            //}
            //Console.ReadLine();

            //verilen başka bir string ile başlayıp başlamadığını kontrol eden

            /* TODO:
             *      1. Döngü yardımı ile kontrol yapılacak
             *      2. Döngü kısa olan stringin sonuna kadar gitmeli.
             *      3. karşılıklı gelen harfleri kontrol et. 
             *          3.1. Tüm karşılıklı harfler aynı ise string verilen string ile baş¨lıyor demektir
             *              3.1.1. Karşı¨lıklı harflerin kontrolü ElementAt fonksiyonu ile yapılabilir
             *              3.1.2. Karşışıklı harflerin kontrolü olduğúndan ötürü indexler aynıdır
             *          3.2. Değílse bu stringle baş¨lamıyordur
             *                  
             * 
             * 
             * 
             */

            //string str1 = "Merveeeee Coskun";
            //string str2 = "MerVeeeee";
            //int i = 0;
            //bool IsStr1StartsWithStr2 = true;
            //while (i < str1.Length)
            //{
            //    if (str1.ElementAt(i)!=str2.ElementAt(i))
            //    {
            //        Console.WriteLine(str1 + " starts with " + str2);
            //        IsStr1StartsWithStr2 = false;
            //        break;
            //    }
            //    i++;
            //}
            //if (!IsStr1StartsWithStr2)
            //{
            //    Console.Write(str1 + " does not start with " + str2);

            //}
            //Console.ReadLine();

            //e.Verilen başka bir string ile bitip bitmediğini kontrol eden

            //string str1 = "Merve Coskun";
            //string str2 = "kun";
            //int i = str1.Length-1;
            //int j = str2.Length-1;
            //bool IsStr1EndsWithStr2 = true;
            //while (j >= 0)
            //{
            //    if (str1.ElementAt(i)!=str2.ElementAt(j))
            //    {
            //        Console.WriteLine(str1 + "  does not end with " + str2);
            //        IsStr1EndsWithStr2 = false;
            //        break;

            //    }
            //    i--;
            //    j--;

            //}
            //if (IsStr1EndsWithStr2)
            //{
            //    Console.WriteLine(str1 + " ends with " + str2);

            //    IsStr1EndsWithStr2 = true;
            //}
            //Console.ReadLine();


            // f. verilen bir karakterin baştan kaçıncı indexte olduğunu bulan (birden fazla varsa ilk index verilir)
            //string str1 = "Merve Coskun";
            //char c = 'P';
            //int i = 0;
            //bool IsCharacterFound = false;
            //while (i < str1.Length)
            //{
            //    if (str1.ElementAt(i) == c)
            //    {
            //        Console.WriteLine("Index of " + c + " : " + i);
            //        IsCharacterFound = true;
            //        break;
            //    }
            //    i++;
            //}
            //if (!IsCharacterFound)
            //{
            //    Console.WriteLine(str1 + " does not contain " + c);
            //}

            //Console.ReadLine();

            //g.verilen bir karakterin sondan kaçıncı indexte olduğunu bulan(birden fazla varsa ilk index verilir)
            //        string str1 = "Merve Coskun";
            //        char c = 'b';
            //        int i = str1.Length-1;
            //        bool IsCharFound = false;
            //        while (i>=0)
            //        {
            //            if (str1.ElementAt(i)==c)
            //            {
            //                Console.WriteLine("Index of " + c + " : " + i);
            //                IsCharFound = true;
            //                break;
            //            }
            //            i--;
            //        }
            //        if (!IsCharFound)
            //            Console.WriteLine(str1 + " does not contain "+ c );

            //        Console.ReadLine();

            //HW10: iki stringin eşitliğini kontrol eden program

            //string str1 = "Merve Coskun";
            //string str2 = "Coskun";
            //int i = 0;
            //bool IsSomeTwoString = true;
            //while (i < str2.Length)
            //{
            //    if (!str1.Equals(str2))

            //    {
            //        Console.WriteLine(str1 + " and " + str2 + " are not  some.");
            //        IsSomeTwoString = false;
            //        break;
            //    }

            //    i++;

            //}
            //if (IsSomeTwoString)
            //{
            //    Console.WriteLine(str1 + " and " + str2 + " are  some.");
            //}
            //Console.ReadLine();






        }
    }
        }
