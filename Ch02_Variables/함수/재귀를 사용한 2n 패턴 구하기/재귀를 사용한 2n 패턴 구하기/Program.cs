namespace 재귀를_사용한_2n_패턴_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(2,2));
            Console.WriteLine(Fact(5));
        }

        static int MyPower(int num, int cnt)
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }

        ////- 팩토리얼 계산하기
        //n!을 재귀로 구현하세요.
        //입력: n = 5 → 출력: 120
 
        static int Fact (int n)
        {
            if (n == 0 || n ==1)
            {
                return 1;
            }
            return n * Fact(n - 1);
        }
    }
}
