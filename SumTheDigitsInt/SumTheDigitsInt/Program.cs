using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTheDigitsInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  calculate the digits of the a number!");
            Console.Write("Enter a number: ");
            int number1;
            int.TryParse(Console.ReadLine(), out number1);
            int total= 0;
            int number2;
            int number3;
           
                
                number2= number1 % 10;
                number3=number1/10;
                total = number3 + number2;

                Console.WriteLine("Digits of the number: "+total);
                Console.ReadLine();
            

            
           
           
        }
           
        
        
    }
}
