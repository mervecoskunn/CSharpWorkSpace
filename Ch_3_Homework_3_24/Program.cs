using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_3_Homework_3_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            int card = random.Next(1, 14);
           
            if (card == 1)
                Console.Write("The card you picked is Ace of ");
            else if (card == 11)
                Console.Write("The card you picked is Jack of ");
            else if (card == 12)
                Console.Write("The card you picked is Queen of ");
            else if (card == 13)
                Console.Write("The card you picked is King of ");
            // diger sayilari ata
            

            int suit = random.Next(1, 5);
            if (suit == 1)
                Console.Write("Clubs");
            else if (suit == 2)
                Console.Write("Diamonds");
            else if (suit == 3)
                Console.Write("Hearts");
            else
                Console.Write("Spades");


            

            Console.ReadLine();
        }
    }
}
