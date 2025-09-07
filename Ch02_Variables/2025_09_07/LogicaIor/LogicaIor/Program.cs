namespace LogicaIor
{
    internal class Program
    {
        // ||연산자는 하나라도 참이면 참을 반환한다. 둘 다 거짓일 때는 거짓을 반환한다.
        static void Main(string[] args)
        {
            Console.WriteLine($"true || true -> {true || true}");
            Console.WriteLine($"true || fales -> {true || false}");
            Console.WriteLine($"fales || true -> {false || true}");
            Console.WriteLine($"fales || fales -> {false | false}");
        }
    }
}
