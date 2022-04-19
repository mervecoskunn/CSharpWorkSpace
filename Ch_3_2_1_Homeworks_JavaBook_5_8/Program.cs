using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_2_1_Homeworks_JavaBook_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* (Find the highest score) Write a program that prompts the user to enter the num-
              ber of students and each student’s name and score, and finally displays the name 
              of the student with the highest score.
             * 
             */
            int higestScore = 0;
            string nameOfTheHigestScore = "";
            int numberOfStudents;
            Console.Write("Enter your students number: ");
            int.TryParse(Console.ReadLine(), out numberOfStudents);
            string name;
            int score;


            for (int i = 0; i < numberOfStudents; i++)
            {
            
               
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                Console.Write("Enter your score: ");
                int.TryParse(Console.ReadLine(), out score);
                Console.WriteLine("--------------------");
                if (score>higestScore)
                {
                    higestScore=score;
                    nameOfTheHigestScore=name;
                }
                Console.WriteLine("The student with the highest score is " + nameOfTheHigestScore);
                Console.WriteLine("The highest score is " + higestScore);

                
            }



            Console.ReadLine();

        }
    }
}
