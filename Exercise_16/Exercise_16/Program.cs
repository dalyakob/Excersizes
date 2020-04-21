using System;

namespace Exercise_16
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
                string str = "*";
                for (int i = 0; i < height; i++)
                {
                    Console.WriteLine(str);
                    str += " *";
                }
                Console.WriteLine("Would you like to continue(y/n)? ");
                userInput = Console.ReadLine().ToUpper();
            } while (userInput == "Y");
        }
    }
}
