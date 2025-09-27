namespace 문자열_형식의_날자를_날자_형식으로_변환
{
    class OutVariableDemo
    {
        static void Main()
        {
            if (DateTime.TryParse("2025/12/25", out DateTime/*var*/ xmas))
            {
                Console.WriteLine(xmas);
            }
        }
    }
}
