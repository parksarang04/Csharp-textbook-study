namespace LogicalAnd
{
    internal class Program
    {
        // && 연산자는 둘 다 참일 때만 참을 반환
        static void Main(string[] args)
        {
            Console.WriteLine($"true && true -> {true && true}");
            Console.WriteLine($"true && false -> {true && false}");
            Console.WriteLine($"false && true -> {false && true}");
            Console.WriteLine($"false && false -> {false && false}");
        }
    }
}
