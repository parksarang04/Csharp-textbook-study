namespace 식_본문_메서드_사용
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log("함수축약");    //아래에 함수를 먼저 만들고 호출
            Console.WriteLine(IsSame("A", "B"));
        }

        static void Log(string message) => Console.WriteLine(message);
        static bool IsSame(string a, string b) => a == b;
    }
}
