using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsExercises_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int totalName;
            
            for (int i = 1; i <=10 ; i++)
            {
                Console.Write("Enter your name :");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("{0}:{1}",i,name);

            }
            Console.ReadLine();
            
        }
    }
        
}
