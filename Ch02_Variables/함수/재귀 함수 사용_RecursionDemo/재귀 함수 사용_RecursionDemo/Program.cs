using System.Reflection.Metadata.Ecma335;

namespace 재귀_함수_사용_RecursionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(4));
            Console.WriteLine(Factorial(4));
        }

        // 3항 연산자를 사용한 팩토리얼 구하기
        static int Fact(int n)
        {
            //삼항 연산자 조건? 참일 때 값: 거짓일 때 값
            return (n > 1) ? n * Fact(n - 1) : 1;
        }

        //재귀 함수를 사용항 팩토리얼 함수 만들기: 재귀 함수는 트리 구조 탐색에 유리
        static int Factorial(int n)
        {
            //종료
            if(n == 0 || n ==1)
            {
                return 1;
            }
            return n * Factorial(n - 1); //재귀호출
        }

        //단순한 팩토리얼은 이 방법이 좋음
        static int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}

