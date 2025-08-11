namespace index_place_holder_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", "Hello, C#");
            Console.WriteLine("{0},{1}", "Hello", "C#");

            Console.WriteLine("{1}", "{0}", "Hello", "C#"); //책 에서 결과물은 C#, Hello로 나오는데 실행결과는 Hello만 출력됨
            //자리 표시자가 ""(큰 따움표) 밖을 넘어가면 평범한 문자열 값이 되서 책과 다른 결과물이 나옴

            Console.WriteLine("{1} , {0}", "Hello", "C#"); //올바른 자리 표시자의 순서 변경
        } 
       

    }
}
