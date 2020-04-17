using System;

namespace Exercise_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;
            do
            {
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();
                for (int num = int.Parse(userInput); num >= 0; num--)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                condition = Console.ReadLine().ToLower();
            } while (condition == "y");
        }
    }
}
