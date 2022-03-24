using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* (Find the two highest scores) Write a program that prompts the user to enter the 
                number of students and each student’s name and score, and finally displays the 
                student with the highest score and the student with the second-highest score.
             * 
             */
            int higestScore = 0;
            string nameOfHigestScore = "";
            int secondHigestScore = 0;
            string nameOfSecondHigestScore = "";
            Console.Write("Enter students of number: ");
            int numberOfStudents;
            int.TryParse(Console.ReadLine(), out numberOfStudents);
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Enter student of name: ");
                string name;
                name= Console.ReadLine();
                Console.Write("Enter student of score: ");
                int score;
                int.TryParse(Console.ReadLine(), out score);
                Console.WriteLine("------------------------------------");
                if (i==0)
                {
                    higestScore = score;
                    nameOfHigestScore=name;

                }
                else if (i==1 && score>higestScore)
                {
                    secondHigestScore = higestScore;
                    higestScore=score;
                    nameOfSecondHigestScore=nameOfHigestScore;
                    nameOfHigestScore = name;


                }
                else if (i>1 && score>higestScore && score>secondHigestScore)
                {
                    secondHigestScore =higestScore;
                    nameOfSecondHigestScore = nameOfHigestScore;
                    higestScore = score;
                    nameOfHigestScore = name;
                    

                }
                else if (i > 1 && score > secondHigestScore)
                {
                    nameOfSecondHigestScore = name;
                    secondHigestScore = score;

                }
               

            }
            Console.WriteLine("Higest scoring student: " + nameOfHigestScore + " Score:"+higestScore+
           "\nSecond Higest scoring student: " + nameOfSecondHigestScore+ " Score: " + secondHigestScore);
            Console.ReadLine();
        }
    }
}
