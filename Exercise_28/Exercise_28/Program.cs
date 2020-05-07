using System;

namespace Exercise_28
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter some text: ");
                string someText = Console.ReadLine().ToLower();

                var lettersWithoutVowels= someText.Split('o', 'u', 'i', 'a', 'e');

                foreach (var letters in lettersWithoutVowels)
                {
                    Console.Write(letters);
                }

                Console.WriteLine("\n\nWould you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
