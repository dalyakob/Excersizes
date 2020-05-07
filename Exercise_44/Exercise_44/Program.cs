using System;

namespace Exercise_44
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
                Console.WriteLine(firstPoint.PrintPoint());
                firstPoint.CalculateDistance();

                do
                {
                    Console.Write("Enter an X coordinate: ");
                    var boolX = int.TryParse(Console.ReadLine(), out x);
                    Console.Write("Enter a Y coordinate: ");
                    var boolY = int.TryParse(Console.ReadLine(), out y);
                    valid = boolX && boolY;
                } while (!valid);

                var secondPoint = new Point(x, y);

                Console.WriteLine(secondPoint.PrintPoint());
                secondPoint.CalculateDistance();

                firstPoint.CalculateMidpoint(secondPoint);

                Console.WriteLine("Would you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
