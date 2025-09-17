namespace 재귀_함수_사용_RecursionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 재귀 호출을 사용하여 팩토리얼 구하기 : 4! = 4 * 3* 2* 1 =24
            Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(FactorialFor(4));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Fact(4));
        }

        //3항 연사자를 통해 팩토리얼 구하기
        static int Fact(int n)
        {
            return (n > 1) ? n * Fact(n - 1) : 1;
        }

        //재귀 함수를 사용한 팩토리얼 함수 만들기 : 재귀 함수는 트리 구조 탐색에 유리
        static int Factorial(int n)
        {
            if (n == 0 || n ==1)    //종료
            {
                return 1;
            }
            return n * Factorial(n - 1); //재귀 호출
        }

        //단순한 팩토리얼은 이 방법이 좋음
        static int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
