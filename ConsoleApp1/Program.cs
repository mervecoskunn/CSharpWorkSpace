using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Sort three integers) Write a program that prompts the user to enter three integers
            //and display the integers in non - decreasing order.
            int a;
            int b;
            int c;
            Console.Write("a= ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b= ");
            int.TryParse(Console.ReadLine(),out b);
            Console.Write("c= ");
            int.TryParse(Console.ReadLine(),out c);


         
            
            

           Console.ReadLine();
        }   
        
    }
}
