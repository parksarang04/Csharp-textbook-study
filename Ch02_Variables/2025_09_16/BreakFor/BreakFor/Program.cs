namespace BreakFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //아무것도 하지 않는 프로그램
            for (int i = 0; i < 5; i++)
            {
                if (i >= 0)
                {
                    break;
                }
            }
            Ex_1();
            Ex_2();
            Ex_3();

            static void Ex_1()
            {
                // 무한 루프 빠져나오기

                int number = 0;

                while (true)
                {
                    Console.WriteLine(++number);

                    if (number <= 5)
                    {
                        break;
                    }
                }
            }

            static void Ex_2()
            {
                // break로 반복문 끝내기

                for(int i =0; i < 100; i++)
                {
                    if (i == 5)
                    {
                        break;
                    }
                    Console.Write($"{i + 1} 번 반복");
                }
                Console.WriteLine();
            }

            static void Ex_3()
            {
                // break문을 사용하여 while 문 빠져나오기

                int goal = 22;
                int sum = 0;

                int i = 1;
                while(i <= 10)
                {
                    sum += i;

                    if (sum >= goal)
                    {
                        break;
                    }
                    i++;
                }
                Console.WriteLine($"1부터 7까지의 합은 {sum} 이고, 목표치 {goal} 이상을 달성하셨습니다.");

            }

        }
    }
}
