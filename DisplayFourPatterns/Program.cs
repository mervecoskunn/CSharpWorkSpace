using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFourPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a.Sola dayali dik ucgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i <=row; i++)
            //    {
            //        Console.Write(i+1+"  ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            // b. Sola dayalı   ici dolu ters dik üçgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 1; i < rowNumber - row + 1; i++)
            //    {
            //        Console.Write(i + "  ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //Cozum 2 MERVE
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = rowNumber; i >row; i--)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();








            //c. Sağa dayalı dik üçgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < rowNumber-row-1; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    for (int i = 0; i <=row; i++)
            //    {
            //        Console.Write(i+1+" ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();

            //d.saga dayali ters dik ucgen 
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 1; i < row; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    for (int i = 0; i<rowNumber-row; i++)
            //    {
            //        Console.Write(i+1+" ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //5.18 - 2 Display patterns below by start(*)
            //   * a. 5.18'deki şekilleri yıldız ile içi boş ve dolu olarak çizdir
            //a.Sola dayali dik ucgen ici yildiz ile dolu olan 
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < row+1; i++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            // b. Sola dayalı  ici yildiz dolu olan  ters dik üçgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < rowNumber-row; i++)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //b.Sola dayalı  ici yildiz dolu olan  ters dik üçgen             MERVE COZUM
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = rowNumber; i >row; i--)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();

            //}

            //Console.ReadLine();
            //b.Sola dayalı  ici BOS olan  ters dik üçgen yildizli


            //c.Sağa dayalı ici yildiz dolu olan dik üçgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < rowNumber - row - 1; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    for (int i = 0; i < row + 1; i++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //d.saga dayali ici yildiz dolu olan ters dik ucgen 
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 1; i <=row; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    for (int i = 0; i < rowNumber-row; i++)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //a.Sola dayali dik ucgen ici bos kenarlari yildiz olan 
            //int rowNumber = 6;
            //Console.WriteLine("*");// ilk satir dongu icinde olmasina gerek yok bir kere yaziliyor.
            //for (int row = 1; row <rowNumber-1; row++)
            //{
            //    Console.Write("* ");
            //    for (int i = 0; i <= row-2; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    Console.WriteLine("* ");


            //    Console.WriteLine();
            //}
            //for (int i = 0; i < rowNumber; i++)
            //{
            //    Console.Write("* ");

            //}
            //Console.ReadLine();
            // b. Sola dayalı  ici bos olan  ters dik üçgen
            //int rowNumber = 6;
            //for (int i = 0; i <= rowNumber; i++)
            //{
            //    Console.Write("* ");

            //}
            //for (int row = 1; row < rowNumber - 1; row++)
            //{
            //    for (int i = 1; i < rowNumber - row + 1; i++)
            //    {
            //        Console.Write("* ");

            //    }

            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //ici dolu ikizkenar ucgen                                       
            //int rowNumber = 9;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = rowNumber; i > row; i--) //bosluk
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int yildiz = 0; yildiz <= row; yildiz++) //yildiz
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            //ici dolu dikdortgen
            //int uzunKenar = 5;
            //int kisaKenar = 3;
            //for (int i = 0; i < kisaKenar; i++)
            //{
            //    for (int j = 0; j < uzunKenar; j++)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            //ici bos dikdortgen
            //int kisaKenar = 5;
            //int uzunKenar = 20;
            //for (int i = 0; i < uzunKenar; i++)//yukardaki uzun kenar
            //{
            //    Console.Write("* ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < kisaKenar - 1; i++) // yanlar
            //{
            //    Console.Write("* ");
            //    for (int bosluk = 1; bosluk <= uzunKenar - 2; bosluk++)//icindeki bosluklar
            //    {
            //        Console.Write("  ");
            //    }

            //    Console.WriteLine("* ");



            //}
            //for (int i = 0; i < uzunKenar; i++) //asagi uzun kenar
            //{
            //    Console.Write("* ");

            //}
            //Console.ReadLine();
            // ici bos sola dayali ters ucgen
            //int rowNumber = 13;
            //for (int i = 0; i < rowNumber; i++)
            //{
            //    Console.Write("* ");
            //}
            //Console.WriteLine();
            //int spaceCount = rowNumber - 3;
            //for (int row = 1; row < rowNumber-1; row++)
            //{
            //    Console.Write("* ");
            //    for (int bosluk = 0; bosluk < spaceCount; bosluk++)
            //    {
            //        Console.Write("  ");

            //    }
            //    spaceCount--;
            //    Console.Write("* ");
            //    Console.WriteLine();

            //}

            //    Console.Write("* ");

            //Console.ReadLine();
            //saga dayali ici bos yildizli ucgen 

            

