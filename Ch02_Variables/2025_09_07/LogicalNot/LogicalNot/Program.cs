namespace LogicalNot
{
    internal class Program
    {
        //! 연산자는 조건식 결과를 반대로 바꾸어준다.
        static void Main(string[] args)
        {
            Console.WriteLine($"!true ->{!true}");
            Console.WriteLine($"!false -> {!false}");
        }
    }
}
