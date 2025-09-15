namespace GreateThanEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫 번째 수 : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 수 : ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first >= second)
            {
                Console.WriteLine("큰 값 {0}" , first);
            }
            else
            {
                Console.WriteLine("큰 값 {0}", second);
            }
        }
    }
}
