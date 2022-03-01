using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopsHomework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int questionNumber = 10;
            int correctAnswerForAddition = 0;
            int correctAnswerForSubtraction = 0;
            int correctAnswerForMultiplication = 0;
            int correctAnswerForDivision = 0;
            double n1, n2;
            Random random = new Random();
            double answer;
            int currentQuestion = 1;
            int op;


            while (currentQuestion <= questionNumber)
            {


                n1 = random.Next(10);
                n2 = random.Next(10);

                op = random.Next(1, 5);


                switch (op)
                {
                    case 1:
                        Console.Write(currentQuestion + ")" + n1 + "+" + n2 + "= ");
                        Double.TryParse(Console.ReadLine(), out answer);
                        if (n1 + n2 == answer)
                            correctAnswerForAddition++;
                        break;

                    case 2:
                        Console.Write(currentQuestion + ")" + n1 + "-" + n2 + "= ");
                        Double.TryParse(Console.ReadLine(), out answer);
                        if (n1 - n2 == answer)
                            correctAnswerForSubtraction++;
                        break;

                    case 3:
                        Console.Write(currentQuestion + ")" + n1 + "*" + n2 + "=");
                        Double.TryParse(Console.ReadLine(), out answer);
                        if (n1 * n2 == answer)
                            correctAnswerForMultiplication++;
                        break;

                    case 4:
                        Console.Write(currentQuestion + ")" + n1 + "/" + n2 + "=");
                        Double.TryParse((Console.ReadLine()), out answer);
                        if (n2 == 0)
                            n2 = random.Next(1, 10);

                        if (Math.Round(n1 / n2, 2) == answer)
                            correctAnswerForMultiplication++;
                        break;

                }
                currentQuestion++;
            }
            Console.WriteLine("You have entered " + correctAnswerForAddition + " correct answers for addition.");
            Console.WriteLine("You have entered " + correctAnswerForSubtraction + " correct answers for subtraction.");
            Console.WriteLine("You have entered " + correctAnswerForMultiplication + " correct answers for multiplication.");
            Console.WriteLine("You have entered " + correctAnswerForDivision + " correct answers for division.");
            Console.ReadLine();
        }
    }
}
