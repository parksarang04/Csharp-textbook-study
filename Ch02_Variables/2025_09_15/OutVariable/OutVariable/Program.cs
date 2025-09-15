namespace OutVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            if (int.TryParse("안녕",out r))
            {
                // "안녕"은 int 형으로 변환이 불가능 하기에 이 코드는 실행되지 않습니다.
                Console.WriteLine("{0}", r);
            }
            if (int.TryParse("1234",out var result))
            {
                // "1234" 는 itn 형식으로 반환이 가능하기에 result 선언과 동시에 1234가 저장됨
                Console.WriteLine(result);
            }
        }
    }
}
