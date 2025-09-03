namespace defauit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = default;
            double d = default;
            char c = default;
            string s = default;
            Console.WriteLine($"{i},{d},{c},{s}");                   //c = \c, s=null => 눈에 안보이는 결과값
            Console.WriteLine($"[{i}],[{d}],[{c}],[{s}]");           //값이 비어도 대괄호가 양쪽에 붙어서 "여기에 출력된게 정말 없는 것인지, 아니면 안보이는 문자인지" 확인 할 수 있다.
            Console.WriteLine($"[{i}],[{d}],[{c==Char.MinValue}],[{s==null}]");
        }
    }
}
