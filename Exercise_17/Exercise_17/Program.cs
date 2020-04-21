using System;

namespace Exercise_17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int height;
            bool valid;
            string userInput;
            do
            {
                do
                {
                    Console.Write("Enter a number: ");
                    valid = int.TryParse(Console.ReadLine(), out height);
                } while (!valid);
                for (int i = 0; i < height; i++)
                {
                    for (int x = 0; x < height - i; x++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Would you like to continue(y/n)? ");
                userInput = Console.ReadLine().ToUpper();
            } while (userInput == "Y");
        }
    }
}
