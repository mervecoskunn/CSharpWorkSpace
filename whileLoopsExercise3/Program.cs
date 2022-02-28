using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //even numbers (from 1 to 10) 10 not included.
            int i = 1;
            int n = 10;
            int evenNumbers = 0;
            while (i<n)
            {
                if (i%2==0)
                
                    evenNumbers++;
                    i++;
                
                

            }
            Console.WriteLine("Even numbers:" + evenNumbers);
            Console.ReadLine();






        }

        
        

    }
}
