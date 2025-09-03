namespace ConstantDemo.cs
{
    internal class Program
    {
        //const 는 상수 또는 지역 상수 라고 한다.
        static void Main(string[] args)
        {
            const int MAX = 100;    //선언과 동시에 초기화
            Console.WriteLine("최댓값 : {0}", MAX);
            //인덱스({0}) 값이 없으면 어디에 출력해야 할지 몰라서 적어줘야한다 => 규칙
        }
    }
}
