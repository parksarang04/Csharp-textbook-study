using System;
using System.Linq;

namespace TypeConversionErrors;

public static class Program
{
    public static void Main()
    {
        long l = long.MaxValue;
        Console.WriteLine($"l의 값 : {l}");    //long 형식 변수의 가장 큰 값을 l변수에 저장
        int i = (int)l;
        Console.WriteLine($"i의 값 : {i}");    //l의 변수 값을 int 형식으로 변환하여 i 변수에 저장
    }
}
