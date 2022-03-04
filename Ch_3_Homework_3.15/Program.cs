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
            int lotteryNumber= random.Next(100,1000);
             lotteryNumber = 123;
            string lotteryNumberStr = Convert.ToString(lotteryNumber);
            char lotteryDigit1 = lotteryNumberStr.ElementAt(0);
            char lotteryDigit2 = lotteryNumberStr.ElementAt(1);
            char lotteryDigit3 = lotteryNumberStr.ElementAt(2);

            int guess;
            Console.Write("Enter your guess :");
            int.TryParse(Console.ReadLine(), out guess);

            if (guess == lotteryNumber)
            {
                Console.WriteLine("You have earned $ 10.000!!");

            }
            else
            {
                string guessStr = Convert.ToString(guess);
                char guessDigit1 = guessStr.ElementAt(0);
                char guessDigit2 = guessStr.ElementAt(1);
                char guessDigit3 = guessStr.ElementAt(2);

                if (lotteryDigit1==guessDigit2 && lotteryDigit2==guessDigit3 && lotteryDigit3== guessDigit1 ||
                    lotteryDigit1==guessDigit3 && lotteryDigit2==guessDigit1 && lotteryDigit3==guessDigit2)
                {
                    Console.WriteLine("You have earned $ 3 000 !!");
                }
                else if  
                    (lotteryDigit1==guessDigit1 && lotteryDigit2==guessDigit3 && lotteryDigit3==guessDigit2 ||
                    lotteryDigit1==guessDigit2 && lotteryDigit2==guessDigit1 && lotteryDigit3==guessDigit3 ||
                    lotteryDigit1==guessDigit3 && lotteryDigit2==guessDigit2 && lotteryDigit3 == guessDigit1)

                    Console.WriteLine("You have earned $ 1000");
                }

            Console.ReadLine();
            
        }
    }
}
