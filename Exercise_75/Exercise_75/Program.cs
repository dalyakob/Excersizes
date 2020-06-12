using System;

namespace Exercise_75
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                var valid = int.TryParse(Console.ReadLine(), out var num);

                var root = FindRoot(num);

                if(!valid)
                {
                    Console.WriteLine("Error! Invalid number.");
                }
                else if (root == -1)
                    Console.WriteLine($"{num} is not a perfect root");
                else
                    Console.WriteLine($"The square root of {num} = {root}");
                Console.WriteLine("Would you like to check another number?");
            } while (Console.ReadLine().ToLower().Trim() == "y");

            Console.WriteLine("Thanks for using David'd perfect squareroot checker!");
        }
        public static int FindRoot(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (i * i == num)
                    return i;
                else if (i * i > num)
                    return -1;
            }
            return -1;
        }
    }
}
