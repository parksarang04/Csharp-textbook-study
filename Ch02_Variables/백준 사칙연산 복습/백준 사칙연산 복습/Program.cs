namespace 백준_사칙연산_복습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 개의 숫자를 입력하시오"); 

            string[] input = Console.ReadLine().Split();

            if (input.Length < 2)
            {
                Console.WriteLine("숫자를 입력하지 않으셨군요. 프로그램을 종료하겠습니다.");
                return;
            }

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            Console.WriteLine((double)A / B);
        }
    }
}
