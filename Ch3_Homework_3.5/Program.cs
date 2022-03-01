using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_Homework_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter today´s number: ");
            int input1;
            Int32.TryParse(Console.ReadLine(), out input1);
            string today = "";
            switch (input1)
            {
                case 1: today = "Monday"; break;
                case 2: today = "Tuesday"; break;
                case 3: today = "Wednesday"; break;
                case 4: today = "Thursday"; break;
                case 5: today = "Friday"; break;
                case 6: today = "Saturday"; break;
                case 7: today = "Sunday";  break;
            }


            Console.Write("Enter the number of days elapsed since today: ");
            int input2;
            Int32.TryParse(Console.ReadLine(), out input2);
            int newDay = input2 % 7 + input1;
            if (newDay != 7)
                newDay = newDay % 7; // 0,1,2,3,4,5,6
            Console.Write("Today ıs " + today);
            switch (newDay)
            {
                case 7:
                    Console.WriteLine(" and the future day is Sunday"); break;
                case 1:
                    Console.WriteLine(" and the future day is Monday"); break;
                case 2:
                    Console.WriteLine(" and the future day is Tuesday"); break;
                case 3:
                    Console.WriteLine(" and the future day is Wednesday"); break;
                case 4:
                    Console.WriteLine(" and the future day is Thursday"); break;
                case 5:
                    Console.WriteLine(" and the future day is Friday"); break;
                case 6:
                    Console.WriteLine(" and the future day is Saturday"); break;

            }



            Console.ReadLine();
        }

    }
}
