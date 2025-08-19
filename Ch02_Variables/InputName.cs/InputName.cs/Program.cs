namespace InputName.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하시오 => ");
            string name = Console.ReadLine();
            Console.WriteLine("안녕하세요 {0}님", name);

        }

    }
    

}
