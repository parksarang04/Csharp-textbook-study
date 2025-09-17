namespace 기본_매개변수_사용_DefaultParamenter
{
    internal class Program
    {
        // 기본 매개변수 사용
        static void Main(string[] args)
        {
            Log("디버그");
            Log("에러",4);
        }

        static void Log(string message, byte level =1)
        {
            Console.WriteLine($"{message},{level}");
        }
    }
}
