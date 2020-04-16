using System;

namespace Excersize_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var condition = "n";

            do
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue (y/n)?");
                condition = Console.ReadLine();
            } while (condition == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}
