namespace WhileDecription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("안녕하세요");
                count++;
            }
            Ex_1();
            Ex_2();
            Ex_3();
            Ex_4();
        }

        static void Ex_1()
        {
            // while 문을 사용하여 1부터 5까지 출력하기
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("카운트 : {0}", i);
                i++;
            }
        }

        static void Ex_2()
        {
            // while 문을 사용하여 1부터 3까지 출력하기
            int count = 1;
            while (count <= 3)
            {
                Console.WriteLine($"카운트 :{count}");
                count++;
            }
        }

        static void Ex_3()
        {
            // while 문을 사용하여 초기값을 감소시켜서 반복하기

            int index = 5;
            while (index > 0)
            {
                Console.WriteLine($"안녕하세요. {index}");
                index--;
            }
        }

        static void Ex_4()
        {
            // while 문을 사용하여 1부터 100까지 합 구하기

            const int N = 100;
            int sum = 0;

            int i = 1;
            while(i <= N)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"1부터 {N}까지의 합 : {sum}");
        }   
    }
}
