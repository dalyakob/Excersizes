using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_29
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter some text: ");
                string someText = Console.ReadLine().ToLower().Trim();

                var first = someText.FirstOrDefault();
                var last = someText.LastOrDefault();

                string newText="";
                for (int i = 1; i < someText.Length - 1; i++)
                {
                    newText += someText[i];
                }

                var lettersWithoutVowels = newText.Split('o', 'u', 'i', 'a', 'e').ToList();

                Console.Write(first);
                foreach (var letters in lettersWithoutVowels)
                {
                    Console.Write(letters);
                }
                Console.Write(last);

                Console.WriteLine("\n\nWould you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
