﻿namespace 화살표_함수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hi();
            Multiply(3, 5);
        }

        static void Hi() => Console.WriteLine("안녕하세요.");
        static void Multiply(int a, int b) => Console.WriteLine(a + b);
    }
}
