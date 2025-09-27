namespace 재귀를_사용한_2n_패턴_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(2,2));
        }

        static int MyPower(int num, int cnt)
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }
    }
}
