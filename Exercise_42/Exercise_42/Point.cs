using System;

namespace Exercise_42
{
    public class Point
    {
        private int _x;
        private int _y;
        public Point(int X, int Y)
        {
            _x = X;
            _y = Y;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"Coordinates: ({_x}, {_y})");
        }
    }
}