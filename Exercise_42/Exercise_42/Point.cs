using System;

namespace Exercise_42
{
    public class Point
    {
        //long version
        //public int X { get { return _x; } set { _x = value; } }

        //short version
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})");
        }
        
        
        
        //old convention for get and set
        //public int GetX()
        //{
        //    return _x;
        //}
        //public int GetY()
        //{
        //    return _y;
        //}
        //public void SetX(int x)
        //{
        //    _x = x;
        //}
        //public void SetY(int y)
        //{
        //    _y = y;
        //}
    }
}