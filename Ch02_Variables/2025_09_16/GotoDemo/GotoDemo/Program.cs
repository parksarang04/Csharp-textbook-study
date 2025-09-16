namespace GotoDemo
{
    internal class Program
    {
        // Goto 구문은 요즘 잘 쓰이지 않음. 가독성과 유지보수가 어려워질 수 있음.
        static void Main(string[] args)
        {
            // Goto 문으로 지정한 책갈피로 이동

            Console.WriteLine("시작");
        Start:
            Console.WriteLine("0, 1, 2 중 하나 입력 : _\b");
            int chapter = Convert.ToInt32(Console.ReadLine());

            if (chapter == 1)
            {
                goto Chapter1;
            }
            else if (chapter == 2)
            {
                goto Chapter2;
            }
            else
            {
                goto End;
            }

        Chapter1:
            Console.WriteLine("1장 입니다.");

        Chapter2:
            Console.WriteLine("2장 입니다.");

            goto Start;

        End:
            Console.WriteLine("종료");


        }
    }
}
