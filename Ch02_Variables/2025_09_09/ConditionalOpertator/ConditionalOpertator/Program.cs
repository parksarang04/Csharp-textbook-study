using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConditionalOpertator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아무 숫자 키를 입력하십시오.");
            int number = Convert.ToInt32(Console.ReadLine());
            //number 가 짝수이면 result 변수에 "짝수"를 담고, 그렇지 않으면 "홀수" 담기

            string result = (number % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine($"{number}은 {result}입니다.");

            Test();
            Test2();
            Test3();
        }

        static void Test()
        {
            const int max_size = 20;
            int pageSize = 0;
            pageSize = 10;
            pageSize = (pageSize > max_size) ? max_size : pageSize;
            Console.WriteLine(pageSize);

            pageSize = 50;
            pageSize = (pageSize > max_size) ? max_size : pageSize;
            Console.WriteLine(pageSize);
        }

        static void Test2()
        {
            string result = "";
            //A 는 B보다 작으므로 참 -> 앞의 문자열을 result 변수에 저장
            result = ('A' < 'B') ? "'A'는 B보다 작습니다" : "'A, B, C 순서로 커집니다 .";
            Console.WriteLine(result);

            //Z 는 a 보다 작으므로 참 -> 앞의 문자열을 result 변수에 저장
            result = ('Z' < 'a') ? "'Z'는 'a'보다 작습니다" : "대문자보다 소문자가 큽니다.";
            Console.WriteLine(result);
        }

        static void Test3()
        {
            var num = -21;
            var abs = (num < 0) ? -num : num;
            Console.WriteLine($"{num}의 절댓값 : {abs}");
        }
    }
}
