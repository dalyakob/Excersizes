using System;

namespace Exercise_21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;

            do
            {

                var sentence = new string[30];
                var x = 0;
                do
                {
                    Console.WriteLine("Enter a word: ");
                    sentence[x] = Console.ReadLine();
                    x++;

                    Console.WriteLine("Do you want to enter another word? (y/n) ");
                    condition = Console.ReadLine().ToLower();
                } while (condition == "y");

                for (int i = 0; i < x; i++)
                {
                    Console.Write(sentence[i] + " ");
                }

                Console.WriteLine("\nWould you like to continue? (y/n)");
                condition = Console.ReadLine().ToLower();
            } while (condition == "y");
        }
    }
}
