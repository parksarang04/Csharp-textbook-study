namespace 함수생성_호출_FunctionDemo
{
    internal class Program
    {
        static void Show()
        {
            Console.WriteLine("Hello, World!");
        }
        static void Main(string[] args)
        {
            Show();
            ShowMessage("매개변수");
            ShowMessage("Parameter");
            string returnValue = GetString();
            Console.WriteLine(returnValue);

            int r = SquareFunction(5);  //함수 호출 및 반환값 받기'
            Console.WriteLine(r);

            double result = GetSum(3.0, 0.14);
            Console.WriteLine(result);

            
            Console.WriteLine(Max(3, 5));
            Console.WriteLine(Min(-3, -5));
        }



        static void ShowMessage(string message)
        {
            //매개변수가 있는 함수를 만들고 호출
            Console.WriteLine(message);
        }

        static string GetString()
        {
            // 반환값이 있는 함수를 만들고 호출
            return "반환값(Return Value)";     // return 키워드로 단순 문자열 반환
        }

        static int SquareFunction(int x)    //입력 : 매개변수도 있고
        {
            int r = x * x;               //처리 : 함수의 본문
            return r;                   //출력 : 반환값도 있는
        }

        static double GetSum(double x, double y)
        {
            //두 수의 합을 구하는 함수
            double r = x + y;
            return r;
        }

        static int Max(int x, int y)        //Max 함수 : 두 수 중에서 큰 수를 반환시켜 주는 함수
        {
            return (x > y) ? x : y;   //삼항 연산자로 큰 수 구하기
        }

        static int Min(int x, int y)        //Min 함수 : 두 수 중에서 작은 수를 반환시켜 주는 함수
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

    }


}

