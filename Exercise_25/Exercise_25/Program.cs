using System;
using System.Linq;

namespace Exercise_25
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();

                var words = sentence.Split(' ').ToList();

                foreach (var item in words)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nWould you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
