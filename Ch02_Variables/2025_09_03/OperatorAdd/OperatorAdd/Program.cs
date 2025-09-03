namespace OperatorAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            int k = i + j;
            Console.WriteLine(k);

           var a = Console.ReadLine();
           var b = Console.ReadLine();
           var c = a + b;
            Console.WriteLine(c);   // 숫자 연산이 아니고 문자열 붙여주기라서 이상하게 출력.

            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            var f = d + e;
            Console.WriteLine(f);   //문자열 -> 정수로 바꿔준다 (int.parse / Covert.ToInt32)
        }
    }
}
