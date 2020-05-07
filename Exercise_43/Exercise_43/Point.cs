using System;

namespace Exercise_43
{
    public class Point
    {
        private double _x;
        private double _y;
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"Coordinate: ({_x},{_y}) ");
        }
        public void CalculateDistance()
        {
            double distance = Math.Sqrt(Math.Pow(_x,2) + Math.Pow(_y,2));

            PrintPoint();
            Console.WriteLine($"It has a distance of {distance.ToString("f")}");
        }
    }
}