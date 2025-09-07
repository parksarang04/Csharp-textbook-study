namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 28;
            Console.WriteLine($"2월달은 {days} 일 입니다.");
            Console.WriteLine("2월 달은 " + days + "일입니다.");
            Console.WriteLine("2월 달은" + days.ToString()+" 일 입니다.");
            Console.WriteLine("2월 달은" + Convert.ToString(days) + " 일 입니다.");
        }
    }
}
