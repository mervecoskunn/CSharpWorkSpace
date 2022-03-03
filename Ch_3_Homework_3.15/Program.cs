using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {/* (Game: lottery) Revise Listing 3.8, Lottery.java, to generate a lottery of a three-
           digit number. The program prompts the user to enter a three-digit number and 
           determines whether the user wins according to the following rules:
           1. If the user input matches the lottery number in the exact order, the award is 
           $10,000.
           2. If all digits in the user input match all digits in the lottery number, the award is 
           $3,000.
           3. If one digit in the user input matches a digit in the lottery number, the award is 
           $1,000.*/

            
            Random random = new Random(1);
            int lotteryNumber= random.Next(123,999);

            int lotteryDigit1 = lotteryNumber / 100;
            int lotteryDigit2 = 10*(lotteryNumber/10) % 10;
            int lotteryDigit3 = lotteryNumber % 10;
            int guess;
            Console.Write("Enter your guess :");
            int.TryParse(Console.ReadLine(), out guess);

          
           
            
                if (guess == lotteryNumber)
                {
                    Console.WriteLine("You have earned $ 10.000!!");

                }
            else
            {
                int guessdigit3 = guess / 100;
                int guessdigit2 = 10 * (guess / 10) % 10;
                int guessdigit1 = guess % 10;
                int guessReverse = guessdigit1 + guessdigit2 + guessdigit3;
                if (guessReverse== lotteryNumber)
                {
                    Console.WriteLine("You have earned $ 3 000!!!");

                }







            }
                  

                

            Console.ReadLine();
        }
    }
}
