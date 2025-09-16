namespace WhileFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 피보나치 수열 : 1 1 2 3 5 8 1 3 21

            int first = 0;
            int second = 1; 

            while(second <= 20)
            {
                Console.WriteLine(second);
                int temp = first + second;
                first = second;
                second = temp;
            }
        }

    }
}
