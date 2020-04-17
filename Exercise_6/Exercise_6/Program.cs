using System;

namespace Exercise_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String condition;

            do
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue (y/n)?");
                condition = Console.ReadLine().ToUpper();
            } while (condition == "Y");

            Console.WriteLine("Goodbye!");
        }
    }
}
