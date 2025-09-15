namespace Yes__No__Cancel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자를 입력하세여 (y,n ) : ");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'y')
            {
                Console.WriteLine("Yes");
            }
            else
            {
                if (input == 'n')
                {
                    Console.WriteLine("No");
                }
                else
                {
                    {
                        Console.WriteLine("Cancle");
                    }
                }
            }
            
        }
    }
}
