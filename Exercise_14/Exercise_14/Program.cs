using System;

namespace Exercise_14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;
            do
            {
                int max;
                bool valid;
                do
                {
                    Console.Write("Enter a number: ");
                    valid = int.TryParse(Console.ReadLine(), out max);

                    if (!valid)
                        Console.WriteLine("Invalid integer, please try again!");

                } while (!valid);
                for (int i = 1; i <= max; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
                Console.Write("Would you like to continue (y/n)?");
                condition = Console.ReadLine().ToLower();
            } while (condition == "y");







        }
    }
}
