using System;

namespace Excersize_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String userInput, condition = "n";

            do
            {
                Console.WriteLine("Enter some text: ");
                userInput = Console.ReadLine();

                Console.WriteLine("Would you like to continue?");
                condition = Console.ReadLine();
            } while (condition == "y");
            Console.WriteLine("Goodbye!");
        }

    }
}
