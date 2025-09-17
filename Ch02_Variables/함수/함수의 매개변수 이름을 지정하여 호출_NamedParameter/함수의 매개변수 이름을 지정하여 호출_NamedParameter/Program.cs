namespace 함수의_매개변수_이름을_지정하여_호출_NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(first: 10, second: 20);
            Sum(second: 20, first: 10); //매개변수의 순서를 바꿔도 된다.
        }

        static void Sum(int first, int second)  //명명된 매개변수
        {
            Console.WriteLine(first + second);
        }
    }
}
