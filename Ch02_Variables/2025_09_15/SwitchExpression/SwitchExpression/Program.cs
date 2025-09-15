namespace SwitchExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            switch (x)
            {
                case 1:
                    Console.WriteLine("1입니다.");
                    break;
                case 2:
                    Console.WriteLine("2입니다.");
                    break;

                
            }
            Ex_1();
        }

        static void Ex_1()
        {
            Console.WriteLine("정수를 입력하세요");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch(answer)
            {
                case 1:
                    Console.WriteLine("1을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2를 선택했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3를 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("그냥 찍으셨군요");
                    break;
            }
                
        }


    }
}
