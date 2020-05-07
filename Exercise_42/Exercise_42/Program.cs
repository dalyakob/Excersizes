using System;

namespace Exercise_42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                bool valid;
                int x, y;
                do
                {
                    Console.Write("Enter an X coordinate: ");
                    var boolX = int.TryParse(Console.ReadLine(), out x);
                    Console.Write("Enter a Y coordinate: ");
                    var boolY = int.TryParse(Console.ReadLine(), out y);
                    valid = boolX && boolY;
                } while (!valid);
                var firstPoint = new Point(x, y);
                firstPoint.PrintPoint();
                Console.WriteLine("Would you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
