using System;

namespace 구조체를_사용하여_변수나_배열을_묶어_관리
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class StructDemo
    {
        static void Main()
        {
            Point point;     //Point 구조체 변수 point 선언
            point.X = 100;
            point.Y = 200;
            Console.WriteLine($"X : {point.X}, Y : {point.Y}");
        }
    }

   
}
