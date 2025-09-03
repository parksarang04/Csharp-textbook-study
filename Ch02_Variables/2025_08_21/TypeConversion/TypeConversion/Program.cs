using System;
using System.Linq;

namespace TypeConversion;

public static class Program
{
    public static void Main()
    {
        Example1();
        Example2();
    }

    //Convert 클래스로 형식변환
    public static void Example1()
    {
        double d = 12.43;
        int i = 1234;

        d = i;    //큰 그릇(d)에 작은 그릇의 값(i) 을 저장
        Console.WriteLine("암시적 형식 변환 = " + d);

        d = 12.34;
        i = (int)d;
        Console.WriteLine("명시적 형식 변환 = " + i);

        string s = "";
        s = Convert.ToString(d);
        Console.WriteLine("형식 변환 = " + s);
    }

    // 정수 형식으로 변환하는 세 가지 방법
    public static void Example2()
    {
        string strNumber = "1234";
        int number1 = Convert.ToInt32(strNumber);
        Console.WriteLine($"{number1} - {number1.GetType()}");

        int number2 = int.Parse(strNumber);
        Console.WriteLine($"{number2} - {number2.GetType()}");

        int number3 = Int32.Parse(strNumber);
        Console.WriteLine($"{number3} - {number3.GetType()}");
        //GetType() 메서드는 닷넷에서 제공하고 이를 사용하면 모든 값의 데이터 형식을 알 수 있다.
        //1234(int 정수형) 을 GetType() 메서드로 데이터 형식을 확인하면 1234(정수형)가 .NET 형식인 System.Int32다. 
    }
}
