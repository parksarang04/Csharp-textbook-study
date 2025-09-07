namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x++;
            Console.WriteLine(y);
            Console.WriteLine(x);

            Operator();
        }

        static void Operator()
        {
            int x = 3;
            int y = 5;
            Console.WriteLine(x == y);  //false
            Console.WriteLine(x != y);  //true
            Console.WriteLine(x >= y);  //false
            Console.WriteLine(x <= y);  //true
        }
    }
}
