namespace OperatorRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 3;
            int k = i % j;
            Console.WriteLine(k);
            Ex();
        }

        public static void Ex()
        {
            var a = int.Parse(Console.ReadLine());

            if (a % 3 ==0)
            {
                Console.WriteLine($"{a}는 3의 배수 입니다.");
            }
            else
            {
                Console.WriteLine($"{a}는 3의 배수가 아닙니다");
            }
        }
    }
}
