using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to David's Binary Search!\n");

            do
            {
                var numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.Write($"Our test numbers are ");
                foreach (var item in numList)
                {
                    Console.Write($"{item}  ");
                }

                Console.WriteLine("\nWhat number would you like to search?");
                var value = Validation(Console.ReadLine());


                
                var found = BinarySearch(numList, value);

                
                if (!found)
                    Console.WriteLine($"The number {value} was NOT found in list!");
                else
                    Console.WriteLine($"The number {value} was found in the list");

                Console.WriteLine("Would you like to check another number?");
            } while (YesNo(Console.ReadLine()) == "y");

        }

        private static string YesNo(string input)
        {
            input = input.ToLower().Trim();
            while (!Regex.IsMatch(input, "^[yn]$"))
            {
                Console.WriteLine("Please enter y or n: ");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }

        private static int Validation(string input)
        {
            var num = 0;
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine("Error! Invalid integer, please try again.");
                input = Console.ReadLine();
            }

            return num;
        }
                                                                   
        private static bool BinarySearch(List<int> numList, int value)// 1-10  looking for 5
        {
            var middle = numList.Count / 2;
            
            if (value == numList[middle]) // 6
            {
                
                return true;
            }
            else if (value < numList[middle] && numList.Count > 1)
            {
                
                numList.RemoveRange(middle, middle);

                return BinarySearch(numList, value);
            }
            else if (value > numList[middle] && numList.Count > 1)
            {
                numList.RemoveRange(0, middle);
                return BinarySearch(numList, value);
            }

            return false;
        }
    }
}
