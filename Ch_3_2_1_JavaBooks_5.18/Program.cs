using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_JavaBooks_5._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.18.d.Sağa dayalı ters dik üçgen  ÖDEVV !!
            //int rowNumber = 6;

            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < row; i++)
            //        Console.Write("  ");

            //    for (int j = 0; j < rowNumber - row; j++)
            //    {
            //        Console.Write((j + 1) + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            // 5.18.b. Sola dayalı ters dik üçgen   ÖDEVV !!
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int j = 1; j < rowNumber - row + 1; j++)
            //        Console.Write(j + " ");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //a. 5.18'deki şekilleri yıldız ile içi boş ve dolu olarak çizdir
            // 1. sola dayali ici dolu dik ucgen 
            //int rowNumber = 6;
            //for (int row = 1; row <= rowNumber; row++)
            //{
            //    for (int i = 0; i < row; i++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();
            // 2.saga dayali ici dolu dik ucgen
            //int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < rowNumber-(row+1); i++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int i = row + 1; i >= 1; i--)
            //    {
            //        Console.Write((i) + " ");
            //    }

            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            /*                1
                    *       2 1
                    *     3 2 1 
                    *   4 3 2 1 
                    * 5 4 3 2 1
                   *6 5 4 3 2 1
                   */
            //saga dayali ici dolu (yildiz) dik ucgen 
            //  int rowNumber = 6;
            //for (int row = 0; row < rowNumber; row++)
            //{
            //    for (int i = 0; i < rowNumber-row; i++)
            //    {
            //        Console.Write("  ");

            //    }
            //    for (int i= row+1 ; i>=1 ; i--)
            //    {
            //        Console.Write("* ");

            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();

            // saga dayali ici bos dik ucgen
            int rowNumber = 6;
            for (int i = 0; i < rowNumber; i++)
            {
                Console.Write("  ");

            }
            
            Console.WriteLine("*");

            for (int row = 1; row < rowNumber; row++)
            {
                for (int i = 0; i < rowNumber - row; i++)
                    Console.Write("  ");
                Console.Write("* ");
                for (int i = row-1; i >=1; i--)
                {
                    Console.Write("  ");

                }
                Console.Write("*");
                Console.WriteLine();

             }
            for (int i =0; i < rowNumber+1; i++)
            {
                Console.Write("* ");

            }
                Console.ReadLine();














        }
    }
}
