using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancalApplication_Homework_2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to financal application!");
            Console.Write("Enter the monthly saving amount: ");
            double monthlySavingMoney;
            Double.TryParse(Console.ReadLine(), out monthlySavingMoney);
            double monthlyInterestRate=0.05 / 12;
            double onemonthAmount = monthlySavingMoney * (1 + monthlyInterestRate);
            double twomonthAmount =(monthlySavingMoney+onemonthAmount)*(1+ monthlyInterestRate);
            double threeMonthAmount= (monthlySavingMoney+twomonthAmount)*(1+ monthlyInterestRate);
            Console.WriteLine("After the third month, the value in the account becomes: "+ Math.Round(threeMonthAmount, 3));
            Console.ReadLine();

        }
    }
}
