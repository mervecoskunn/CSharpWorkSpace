using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // from 1 to 10 digits displayed
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
