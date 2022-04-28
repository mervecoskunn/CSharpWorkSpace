using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4_Homeworks_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HW18: 1 - Substring fonksiyonu yaz. Hatalı inputlar için kullanıcı uyar.
            //Console.WriteLine("1- Substring!");
            //     Substring();
            //     Console.WriteLine("2-StartsWith!");
            //     DoesStartWith();
            //     Console.WriteLine("3-EndsWith!");
            //     DoesEndWith();
            //     Console.WriteLine("4-IndexOf!");
            //     FindIndexOf();
            //     Console.WriteLine("5-LastIndexOf!");
            //     FindLastIndexOf();
            //     Console.WriteLine("6- Equals!");
            //     DoesEquelThem();
            //     Console.WriteLine("7-Insert Character!");
            //    InsertCharacter("Merve Coskun", 12, "!");
            //    Console.WriteLine("8- Remove a character!");
            //    RemoveAllCharacter("Merve Coskun",'x');
            //    RemoveCharacters("ab--ab--ab--ab", 'a', -3);
            //    RemoveCharacterFrom("ab--ab--ab--ab",3,2,'a');


            Console.ReadLine();

        }
        public static void Substring()
        {
            Console.Write("Write a string: ");
            string stringInput = Console.ReadLine();
            bool a = true;
            while (a)
            {

                Console.Write("Enter a index number: ");
                int indexInput;
                int.TryParse(Console.ReadLine(), out indexInput);
                if (indexInput < 0 || indexInput >= stringInput.Length)
                    Console.WriteLine("Please enter an index 0 to " + stringInput.Length);
                else
                {
                    string newString = stringInput.Substring(indexInput);
                    Console.WriteLine("First String: " + stringInput);
                    Console.WriteLine("Substring : " + newString);
                    a = false;
                }

            }




        }
        // 2- StartsWith fonksiyonunu yaz. 
        public static void DoesStartWith()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Does start with : ");
            string doesStartWith = Console.ReadLine();
            Console.WriteLine(inputString.StartsWith(doesStartWith));
        }
        //3- EndsWith fonksiyonunu yaz. 
        public static void DoesEndWith()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Does end with : ");
            string doesEndWith = Console.ReadLine();
            Console.WriteLine(inputString.EndsWith(doesEndWith));

        }
        // 4- IndexOf fonksiyonunu yaz.
        public static void FindIndexOf()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Find its index number : ");
            string findIt = Console.ReadLine();
            Console.WriteLine(inputString.IndexOf(findIt));
        }
        //5- LastIndexOf fonksiyonunu yaz. 
        public static void FindLastIndexOf()
        {
            Console.Write("Enter a string: ");
            string str1 = Console.ReadLine();
            Console.Write("Find it : ");
            string str2 = Console.ReadLine();

            Console.WriteLine(str1.LastIndexOf(str2));
        }
        //6-  6- Equals fonksiyonunu yaz.
        public static void DoesEquelThem()
        {
            Console.Write("Write strig 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Write string 2: ");
            string str2 = Console.ReadLine();
            bool result = String.Equals(str1, str2);
            if (result == true)
            {
                Console.WriteLine("They are equal.");
            }
            else
            {
                Console.WriteLine("They are not equal.");
            }
        }
        //7-Insert character fonksiyonunu yaz. index kontrolü yap (Substring fonksiyonundaki gibi).
        public static void InsertCharacter(string inputString, int inputIndex, string inputForInsert)
        {
            if (inputIndex >= 0 && inputIndex <= inputString.Length)
                Console.WriteLine("New string: " + inputString.Insert(inputIndex, inputForInsert));
            else
                Console.WriteLine("Please enter 0 to " + inputString.Length);
        }
        // 8- Remove a character at an index fonksiyonunu yaz. index kontrolü yap (Substring fonksiyonundaki gibi).
        public static void RemoveACharacter(string str1, int index)
        {
            if (index >= 0 && index < str1.Length)
            {
                string str2 = str1.Remove(index, 1);
                Console.WriteLine("New string: " + str2);
            }
            else
                Console.WriteLine("Please enter index 0 to " + str1.Length);

        }
        //  9- Remove all characters** fonksiyonunu yaz. Karakter varsa siler yoksa silmez
        public static void RemoveAllCharacter(string str1, char ch)
        {
            string str2 = "";
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.ElementAt(i) != ch)
                {
                    str2 += str1.ElementAt(i);
                }
            }
            Console.WriteLine("New string: " + str2);

        }
        // 10- Remove a character as given number of times (2 tane sil, 5 tane sil vb) fonk. yaz. index ve kaç kez silineceğinin kontrollerini yap
        public static void RemoveCharacters(string str, char ch, int times)
        {

            string str1 = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str.ElementAt(i) != ch && count < times)
                    str1 += str.ElementAt(i);
                else if (count >= times)
                    str1 += str.ElementAt(i);
                else
                    count++;
            }
            Console.WriteLine("New String: " + str1);
        }
        //11- Remove a character starting from a given index as given number of times (2. indexten başla 3 tane sil gibi). index ve kaç kez silineceğinin kontrollerini yap
        public static void RemoveCharacterFrom(string str, int index, int times, char ch)
        {
            string str2 = "";
            int count = 0;
            for (int i = 0; i < index; i++)
                str2 += str.ElementAt(i);
            for (int i = index; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ch && count < times)
                    str2 += str.ElementAt(i);
                else if (count >= times)
                    str2 += str.ElementAt(i);
                else
                    count++;
            }
            Console.WriteLine("New string: " + str2);

        }
    }


}
