namespace InputName.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //숫자를 하나만 입력했을 때 오류가 난다.
            //string[] input = Console.ReadLine().Split();
            //int A = int.Parse(input[0]);
            //int B = int.Parse(input[1]);
            //Console.WriteLine((double)A / B);

            string[] input = Console.ReadLine().Split();
                
            if (input.Length < 2)
            {
                Console.WriteLine("두 개의 숫자를 입력하세요 (예: 3 2");
                return;
            }
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            Console.WriteLine((double)A / B);
        }

    }
    

}
