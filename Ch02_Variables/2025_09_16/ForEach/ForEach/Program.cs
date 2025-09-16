namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열에서 문자 하나씩 뽑아 출력
            string str = "ABC123";

            foreach (char c in str)
            {
                Console.WriteLine($"{c}\t");
            }
            Console.WriteLine();

            Ex_1();
        }

        static void Ex_1()
        {
            // 문자열에서 문자 하나씩 뽑아 출력2

            var str = "ABC123";

            foreach (var c in str)
            {
                Console.WriteLine($"{c}\t");
            }
            Console.WriteLine();
        }
    }
}
