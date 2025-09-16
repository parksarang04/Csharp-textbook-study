namespace Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continue 문으로 코드 건너뛰기

            for(int i =1; i <=5; i++)
            {
                if (i % 2 ==0)
                {
                    //현재 반복 중지 후 다음 반복으로 넘어감
                    continue;   //짝수 건너뛰기
                }
                Console.WriteLine(i); //1,3,5 출력
            }
            Ex_1();
            Ex_2();
        }

        static void Ex_1()
        {
            // Continue 문으로 3의 배수를 제외한 수의 합 구하기

            int sum = 0;
            for(int i =1; i <= 100; i++)
            {
                if (i % 3 ==0)
                {
                    continue;
                    
                }
                sum += i;
            }
            Console.WriteLine($"3의 배수를 제외한 정수의 합 {sum}");
        }

        static void Ex_2()
        {
            // Continue 문으로 2의 배수와 3의 배수를 제외한 수의 합 구하기

            int sum = 0;
            for(int i=0; i<=100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine($"2의 배수와 3의 배수를 제외한 수의 합 {sum}");
        }
    }
}
