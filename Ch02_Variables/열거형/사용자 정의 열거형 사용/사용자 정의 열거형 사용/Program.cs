namespace 사용자_정의_열거형_사용
{
    enum Priority   //우선순위를 묶어 관리할 수 있는 Priority 열거형 사용
    {
        High,
        Normal,
        Low
    }

    class EnumrationDemo
    {
        static void Main()
        {
            Priority high = Priority.High;  //인텔리센스의 도움을 받을 수 있어 편리함
            Priority noraml = Priority.Normal;
            Priority low = Priority.Low;

            Console.WriteLine($"{high}, {noraml}, {low}");
        }
    }
}
