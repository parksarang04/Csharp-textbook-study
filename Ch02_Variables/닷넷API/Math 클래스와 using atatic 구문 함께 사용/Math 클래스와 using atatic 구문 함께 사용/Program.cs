using System;
using static System.Math;
using static System.Console;

namespace Math_클래스와_using_atatic_구문_함께_사용
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본 사용 방식
            WriteLine(Math.Pow(2, 10));

            // using static 지시문으로 줄여서 표현
            WriteLine(Pow(2, 10));
            WriteLine(Max(3, 5));
        }
    }
}
