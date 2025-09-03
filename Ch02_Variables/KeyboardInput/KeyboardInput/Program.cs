namespace KeyboardInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아무거나 누르세요.");

            ConsoleKeyInfo cki = Console.ReadKey(false);     //키보드 키 값 입력
            Console.WriteLine("{0}", cki.Key);              //키
            Console.WriteLine("{0}", cki.KeyChar);          //유니코드
            Console.WriteLine("{0}", cki.Modifiers);        //Ctrl, Shift, Alt 조합
            {
                Console.WriteLine("Q를 입력하셨군요...");
            }
        }
    }
}
