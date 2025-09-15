namespace ForFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 0;

            for (int i =1; i<=4; i++)
            {
                Console.Write($"{i}! -> ");
                fact = 1;
                for (int j =1; j <= i; j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
