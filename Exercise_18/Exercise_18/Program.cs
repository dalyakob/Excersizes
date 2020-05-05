using System;

namespace Exercise_18
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                int result;
                do
                {
                    Console.WriteLine("Enter a number: ");

                } while (!int.TryParse(Console.ReadLine(), out result));
                int sum = 0;
                for (int i = 1; i <= result; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of every number to that number is " + sum);

                Console.WriteLine("Would you like to continue? (y/n)");
               
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
