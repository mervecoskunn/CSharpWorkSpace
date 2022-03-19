using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsExercisesExtra_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text;
            Console.WriteLine("Write a text please: ");
            text =Console.ReadLine();
            int total = 0;
            
            for ( i = 0; i < text.Length; i++)
            {
                if (text[i]=='O' || text[i]=='o')
                {
                    total++;

                }
                
            }
            Console.WriteLine("Entered text have O: {0} ", total);
            Console.ReadLine();

        }
    }
}
