namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do ~ while 문 으로 안녕하세요 3번 출력하기
            int count = 0;
            do
            {
                Console.WriteLine("안녕하세요");
                count++;
            } while (count < 3);

            WhileExample_1();
            WhileExample_2();
        }

        static void WhileExample_1()
        {
            // do ~ while 문으로 합 구하기

            int sum = 0;

            int i = 1;
            do
            {
                sum += i;
                i++;
            } while (i <= 5);

            Console.WriteLine($"1부터 5까지의 합 : {sum}");
        }

        static void WhileExample_2()
        {
            // do ~ while 문으로 1~100까지 3의 배수이면서 4의 배수인 정수 합 구하기

            int sum = 0;

            int i = 0;
            do
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    sum += i;
                }
                i++;
            }
            while (i <= 100);
            Console.WriteLine(sum);
        }
    }
}
