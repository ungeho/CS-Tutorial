using System;

//名前空間
namespace List1_3Point2D
{
    //２次元の点を表す
    class Point2D
    {
        //X座標
        public int X { get; set; }
        //Y座標
        public int Y { get; set; }
        public override string ToString() => $"({X},{Y})";
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point2D { X = 1, Y = 2 };
            Console.WriteLine(p);
        }
    }
}
