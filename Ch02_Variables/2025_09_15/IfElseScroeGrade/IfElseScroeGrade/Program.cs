namespace IfElseScroeGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수 : ");
            int scroe = Convert.ToInt32(Console.ReadLine());
            string geade;

            if (scroe >= 90)
            {
                geade = "금메달";
            }
            else
            {
                if (scroe >= 80)
                {
                    geade = "은메달";
                }
                else
                {
                    if (scroe >= 70)
                    {
                        geade = "동메달";
                    }
                    else
                    {
                        geade = "메달없음";
                    }
                }
            }
            Console.WriteLine($"{geade} 을 수상했습니다.");
        }
    }
}
