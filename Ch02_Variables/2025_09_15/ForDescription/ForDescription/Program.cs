namespace ForDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("안녕하세요");
            }
            Ex_1();
            Ex_2();
            Ex_3();
        }
        static void Ex_1()   // 1~5까지 출력
        {
           for (int i = 0; i <=5; i++)
           {
                Console.WriteLine("Count : {0}", i);
           }

        }

        static void Ex_2()   // 0~4까지 2씩 증가
        {
            for (int i = 0; i <= 5; i = i +2)
            {
                Console.WriteLine(i);
            }

        }

        static void Ex_3()   // 1~3까지 반복하여 합계 구하기
        {
            int n = 3;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"1부터 {n}까지의 합 : {sum}");
        }
    }
}
