using System;

namespace Exercise_44
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
        public string PrintPoint()
        {
            return $"Coordinate: ({_x},{_y}) ";
        }
        public void CalculateDistance()
        {
            double distance = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));

            Console.WriteLine($"It has a distance of {distance.ToString("f")}\n");
        }
        public void CalculateMidpoint(Point point)
        {
            var tempX = (point._x + _x) / 2;
            var tempY = (point._y + _y) / 2;
            var midpoint = new Point(tempX, tempY);

            Console.WriteLine($"\nThe midpoint between {PrintPoint()} and {point.PrintPoint()} is {midpoint.PrintPoint()}\n");

        }
    }
}