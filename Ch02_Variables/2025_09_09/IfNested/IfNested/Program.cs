namespace IfNested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "C#";
            int version = 8;

            if (name == "C#")
            {
                if (version == 8)
                {
                    Console.WriteLine($"{name} {version}");
                }
            }
            Main2(args);
        }

        static void Main2(string[] args)
        {
            int number = 1234;
            if (number == 1234 && number >= 1000)
            {
                Console.WriteLine("맞습니다");
            }
            if (number ==1234 || number <= 1000)
            {
                Console.WriteLine("하나라도 참이면 참");
            }
        }
    }
}
