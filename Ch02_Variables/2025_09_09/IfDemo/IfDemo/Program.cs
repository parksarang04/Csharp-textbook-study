namespace IfDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if(x == 10)
            {
                Console.WriteLine($"x는{x} 입니다");
            }
            if (x !=20)
            {
                Console.WriteLine($"x는 20이 아닙니다.");
            }

            Test();
        }

        static void Test()
        {
            string s1 = "Hello";
            string s2 = "Hello";

            if (s1 ==s2)
            {
                Console.WriteLine("Same");
            }
        }
    }
}
