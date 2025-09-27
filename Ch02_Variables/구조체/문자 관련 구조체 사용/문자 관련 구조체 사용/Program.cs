namespace 문자_관련_구조체_사용
{
    class CharSturct
    {
        static void Main()
        {
            char a = 'A'; char b = 'a';
            char c = '1'; char d = '\t';    //이스케이프 시퀀스도 문자 하나로 인식

            if (Char.IsUpper(a))
            {
                Console.WriteLine("{0}은 대문자", a);
            }
            if (Char.IsLower(b))
            {
                Console.WriteLine("{0}은 소문자", b);
            }
            if (Char.IsUpper(c))
            {
                Console.WriteLine("{0}은 숫자형", c);
            }
            if (Char.IsUpper(d))
            {
                Console.WriteLine("{0}은 공백 문자", d);
            }

            Console.WriteLine(Char.ToLower(a)); //A -> a
            Console.WriteLine(Char.ToUpper(b)); //a -> A

            string s = "abc";
            if (Char.IsUpper(s[0])) //첫 글자가 대문자인가?
            {
                Console.WriteLine(" 첫 글자가 대문자로 시작합니다.");
            }
            else
            {
                Console.WriteLine(" 첫 글자가 소문자로 시작합니다.");
            }

            Console.WriteLine(Char.MinValue); //문자의 최솟값
            Console.WriteLine(Char.MaxValue); //문자의 최댓값

        }
    }
}
