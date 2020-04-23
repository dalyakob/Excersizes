using System;
using System.Linq;

namespace Example_J
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;
            do
            {
                int[] array = new[] { 1, 2, 3, 4, 5 };
                int number;
                do
                {
                    Console.WriteLine("Enter a Number: ");

                } while (!int.TryParse(Console.ReadLine(), out number));


                Console.WriteLine(BinarySearch(number, array));

                Console.WriteLine("Would you like to continue(y/n)? ");
                condition = Console.ReadLine().ToUpper();
            } while (condition == "Y");
        }

        public static bool BinarySearch(int number, int[] array)
        {
            int middle = array.Length / 2;

            if (array[middle] == number)
                return true;

            else if (array.Length == 1)
                return false;

            else if (array[middle] < number)
                return BinarySearch(number, Right(array));

            else if (array[middle] > number)
                return BinarySearch(number, Left(array));

            return false;
        }

        private static int[] Left(int[] array)        {            return array.Take(array.Length / 2).ToArray();        }        private static int[] Right(int[] array)        {            return array.Skip(array.Length / 2).ToArray();        }
    }
}
