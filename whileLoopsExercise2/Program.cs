using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of the digits(from 1 to 10)
            int i = 0;
            int n = 10;
            int sum = 0;
            while (i<=n)
            {
                sum += i;
                i++;

            }
            Console.WriteLine("Sum: "+ sum);
            Console.ReadLine();
            

            
        }
    }
}
