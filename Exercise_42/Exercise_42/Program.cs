using System;

namespace Exercise_42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                
                int x =GetSingleCoord(), y = GetSingleCoord();
                
                var firstPoint = new Point(x, y);
                firstPoint.PrintPoint();
                Console.WriteLine("Would you like to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
        public static int GetSingleCoord()
        {
            int coord;
            bool valid;
            do
            {
                Console.Write("Enter an X coordinate: ");
                valid = int.TryParse(Console.ReadLine(), out coord);

                if (!valid)
                    Console.WriteLine("Error, invalid integer please try again!");

            } while (!valid);

            return coord;
        }
    }
}
