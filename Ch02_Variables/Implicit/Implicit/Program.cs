using System;
using System.Linq;
using System.Collections.Generic;

namespace implicitExample
{
    public static class Program
    {
        public static void Main()
        {
            int number1 = 1234;
            long number2 = number1;    // number1 값을 그보다 큰 long 형식 변수인 number2에 저장
            Console.WriteLine(number2);
        }
    }
}
