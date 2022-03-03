using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_Homewrok_3_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the weight of the package: ");
            double packageWeight;
            Double.TryParse(Console.ReadLine(), out packageWeight);

            
            if (packageWeight<=50)
            {
                if (0 < packageWeight && packageWeight <= 1)
                {

                    double total = 3.5 * packageWeight;
                    Console.WriteLine("Total= " + total);

                }
                else if (1 < packageWeight && packageWeight <= 3)
                {
                    double total = 5.5 * packageWeight;
                    Console.WriteLine("Total: "+total);
                }
                else if (3<packageWeight && packageWeight<=10)
                {
                    double total = 8.5 * packageWeight;
                    Console.WriteLine("Total: "+total); 
                }
                else if (10<packageWeight &&packageWeight<=20)
                {
                    double total = 10.5 * packageWeight;
                    Console.WriteLine("Total:"+total);

                }
            }
            else
            {
                Console.WriteLine("The package cannot be shipped!!");

            }
            Console.ReadLine();
        }
    }
}
