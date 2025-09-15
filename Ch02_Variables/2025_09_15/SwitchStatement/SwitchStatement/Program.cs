namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            Console.Write("1. C\t");
            Console.Write("2. C++\t");
            Console.Write("3. C#\t");
            Console.Write("4. Java\t");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("C 선택");
                    break;
                case 2:
                    Console.WriteLine("C++ 선택");
                    break;
                case 3:
                    Console.WriteLine("C# 선택");
                    break;
                default:
                    Console.WriteLine("Java 선택");
                    break;

            }
            Ex();
        }
        static void Ex()
        {
            Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈 ...)");
            string weather = Console.ReadLine();

            switch (weather)
            {
                case "맑음":
                    Console.WriteLine("오늘 날씨는 맑군요.");
                    break;
                case "흐림":
                    Console.WriteLine("오늘 날씨는 흐리군요.");
                    break;
                case "비":
                    Console.WriteLine("오늘 날씨는 비가 오는군요.");
                    break;
                default:
                    Console.WriteLine("혹시 눈이 내리나요?.");
                    break;
            }
        }
    }
}
