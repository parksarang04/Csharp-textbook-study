namespace ArrayTWo
{
    internal class Program
    {
        //2차원 배열 새성 및 반복문으로 사용하기
        static void Main(string[] args)
        {
            int[,] intArray;                // 2차원 배열 선언
            intArray = new int[2, 3];       // 2행 3열 배열 생성

            intArray[0, 0] = 1;
            intArray[0, 1] = 2;
            intArray[0, 2] = 3;
            intArray[1, 0] = 4;
            intArray[1, 1] = 5;
            intArray[1, 2] = 6;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{intArray[i, j]}_");
                }
                Console.WriteLine();        // 행 출력 후 개행
            }
            Ex_1();
            Ex_2();
            Ex_3();
            Ex_4();
        }
        static void Ex_1()
        {
            // 2차원 배열 선언과 동시에 초기화

            int[,] intArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{intArray[i, j]}_");
                }
                Console.WriteLine("\n");
            }
        }

        static void Ex_2()
        {
            // 2차원 배열을 for문으로 반복해서 출력

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"arr{i},{j} = {arr[i, j]}");
                }
            }
        }

        static void Ex_3()
        {
            // 2차원 배열에 행과 열이 같으면 1, 다르면 0을 입력한 후 출력

            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 1;  //행과 열이 같으면 1
                    }
                    else
                    {
                        {
                            arr[i, j] = 0;
                        }
                    }
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Ex_4()
        {
            // 2차원 배열을 사용하여 합계와 평균 구하기

            int[,] scores = { { 90, 100, 0, 0 }, { 80, 90, 0, 0 }, { 100, 80, 0, 0, } };

            
            for(int i = 0; i < 3; i++)
            {
                scores[i, 2] = scores[i, 0] + scores[i, 1]; // 합계
                scores[i, 3] = scores[i, 2] / 2;              // 평균

            }
            Console.WriteLine("국어 영어 합계 평균");

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write($"{scores[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
