namespace 전역_변수와_지역_변수_사용
{
    internal class Program
    {
        static string message = "전역변수"; // 필드

        static void ShowMessage()
        {
            string message = "지역변수"; // 지역변수
            Console.WriteLine(message); // 지역변수 출력
        }

        static void Main(string[] args)
        {
            ShowMessage();
            Console.WriteLine(message);
        }
    }
}
