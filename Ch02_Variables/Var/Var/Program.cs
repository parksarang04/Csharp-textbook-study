namespace Var
{
    internal class Program
    {
        //var 키워드 = 입력되는 값에 따라 자동으로 형식이 결정
        static void Main(string[] args)
        {
            var name = "C#";            //string 형식으로 변환함
            Console.WriteLine(name);

            var version = 8.0;          //double 형식으로 변환함
            Console.WriteLine(version);

            var number = 1234;
            Console.WriteLine(number.GetType());

            var message = "안녕하세요";
            Console.WriteLine(message.GetType());
        }
    }
}
