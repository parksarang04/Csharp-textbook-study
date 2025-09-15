namespace ForSumEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"1부터 {n}까지 짝수의 합 : {sum}");
            Ex_1();
            Ex_2();
            Ex_3();
        }

        static void Ex_1()
        {
            // 1부터 100까지의 합을 구하는 프로그램
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"1부터 100까지의 합 : {sum}"); ;
        }

        static void Ex_2()
        {
            // 숫자를 증가시키거나 감소시켜 출력하기
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}\t");
            }

            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i - 1}\t");
            }
        }

        static void Ex_3()
        {
            // 1~100까지 짝수의 합 구하기
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"1~100까지 짝수의 합 {sum}");
        }
    }
}


    

