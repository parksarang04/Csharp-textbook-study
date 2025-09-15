namespace PositiveNegativeZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -10;

            if (number > 0)
            {
                Console.WriteLine($"{number} 은 양수입니다.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} 은 음수입니다.");
            }
            else
            {
                Console.WriteLine($"{number} 은 0 입니다.");
            }
               
        }
    }
}
