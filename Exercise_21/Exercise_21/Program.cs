using System;
using System.Collections.Generic;

namespace Exercise_21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;

            do
            {

                var sentence = new List<string>();
                do
                {
                    Console.WriteLine("Enter a word: ");
                    sentence.Add(Console.ReadLine());

                    Console.WriteLine("Do you want to enter another word? (y/n) ");
                    condition = Console.ReadLine().ToLower();
                } while (condition == "y");

                foreach (var item in sentence)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\nWould you like to continue? (y/n)");
                condition = Console.ReadLine().ToLower();
            } while (condition == "y");
        }
    }
}
