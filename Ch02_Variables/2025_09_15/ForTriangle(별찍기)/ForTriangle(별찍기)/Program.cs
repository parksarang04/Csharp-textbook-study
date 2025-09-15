namespace ForTriangle_별찍기_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >=1; i--)
            {
                for (int j= 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i =2; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
