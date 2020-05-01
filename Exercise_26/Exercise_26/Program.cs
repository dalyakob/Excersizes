using System;

namespace Exercise_26
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do { 
                Console.Write("Enter some text: ");
                string someText = Console.ReadLine().ToLower();

                var vowels = someText.Split('o', 'u', 'i', 'a', 'e');

                Console.WriteLine("There are " + (vowels.Length - 1) + " vowels");

                Console.WriteLine("Would you like to continue? (y/n)");
            }while(Console.ReadLine().ToLower() == "y");
        }
    }
}
