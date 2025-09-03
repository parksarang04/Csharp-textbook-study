namespace StringKeyword.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "박사랑";
            Console.WriteLine("안녕하세요. {0} 입니다.", name);

            string bb = "문자열은";
            string aa = "이렇게 쓰는 겁니다.";
            Console.WriteLine("{0},{1}", bb ,aa);
        }
        //인덱스는 변수의 선언 순서랑은 전혀 상관이 없고
        //그 Console.WriteLine 한 줄 안에서 전달된 인수 배열의 위치만 의미
    }
}
