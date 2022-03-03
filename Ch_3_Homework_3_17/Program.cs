using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*(Game: scissor, rock, paper) Write a program that plays the popular scissor-rock -
            paper game. (A scissor can cut a paper, a rock can knock a scissor, and a paper can
            wrap a rock.) The program randomly generates a number 0, 1, or 2 representing
            scissor, rock, and paper.The program prompts the user to enter a number 0, 1, or
            2 and displays a message indicating whether the user or the computer wins, loses,
            or draws.Here are sample runs:*/
            // ask user to choose;
            Console.WriteLine("Welcome to the scissor, rock, papers game!!");
            Console.WriteLine("\nScissor: 0" + "\nRock:1" + "\nPapper:2");
            Console.Write("Your choice: ");
            int yourChoice;
            Int32.TryParse(Console.ReadLine(), out yourChoice);


            // Generate random number;
            Random random = new Random();
            int computerGuess = random.Next(0, 3);


            if (computerGuess == 0 && yourChoice == 1)
                Console.WriteLine("The computer is scissor. You are rock. You won!!");
            else if (computerGuess == 1 && yourChoice == 2)
                Console.WriteLine("The computer is rock. You are papper.You won!!");
            else if (computerGuess == 2 && yourChoice == 1)
                Console.WriteLine("The computer is papper.You are rock.You lost!!");
            else if (computerGuess == 1 && yourChoice == 0)
                Console.WriteLine("The computer is rock.You are scissor.You lost!!");
            else if (computerGuess == 2 && yourChoice == 0)
                Console.WriteLine("The computer is papper.You are scissor.You won!!");
            else if (computerGuess == 0 && yourChoice == 1)
                Console.WriteLine("The computer is scissor.You are rock.You won!!");
            else if (computerGuess == 0 && yourChoice == 2)
                Console.WriteLine("The computer is scissor.You are papper.You lost!!");
            else if (computerGuess == yourChoice)
                Console.WriteLine("It is a draw!!");
            else
                Console.WriteLine("Please select e number between 0 and 2!!");
            




            Console.ReadLine();
        }
    }
}
