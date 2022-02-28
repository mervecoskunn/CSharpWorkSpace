using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int questionNumbers = 5;
            int correctAnswer = 0;
            int n1, n2;
            Random random =new Random();
            int answer;
            int currentQuestion = 1;
            while (currentQuestion<=questionNumbers)
            {
                n1 = random.Next(10);  
                n2 = random.Next(10);
                Console.Write(currentQuestion + ") " + n1 + " + "+ n2 + " = ");
                Int32.TryParse(Console.ReadLine(), out answer);
                if (answer==(n1+n2))
                    correctAnswer++;
                currentQuestion++;
                



            }
            Console.WriteLine("you have entered " + correctAnswer + " correct answers.");
            Console.ReadLine();


        }
    }
}
