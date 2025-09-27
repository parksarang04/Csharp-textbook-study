namespace _1_8760정수에_해당하는_날짜_변환
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(GetDateTimeFromYearlyHourNumber(1));
            Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760/2));
            Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760));
        }

        static DateTime GetDateTimeFromYearlyHourNumber(int number)
        {
            return (new DateTime(2025, 1, 1, 0, 0, 0)).AddHours(--number);
        }
    }
}
