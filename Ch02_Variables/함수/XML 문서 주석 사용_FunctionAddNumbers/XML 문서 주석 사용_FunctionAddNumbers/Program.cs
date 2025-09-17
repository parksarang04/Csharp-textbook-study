namespace XML_문서_주석_사용_FunctionAddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///두 수를 더하여 그 결과값을 반환시켜 주는 함수
            ///</summary>
            ///<param name="a"> 첫 번째 매개변수</param>
            ///<param name="b"> 두 번째 매개변수</param>
            ///<returns>a+b의 결과값</returns>
            static int AddNumbers(int a, int b)
            {
                return a + b;
            }

            int a = 3;
            int b = 5;
            int c = AddNumbers(3, 5);
            Console.WriteLine($"{a}+{b} = {c}");
        }
    }
}
