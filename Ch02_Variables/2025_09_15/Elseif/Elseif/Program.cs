namespace Elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 59;

            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            Ex();
        }


        static void Ex()
        {
            int score = 0;
            char grade = 'F';

            Console.WriteLine("당신의 점수는 ? ");
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'E';
            }

            Console.WriteLine($" 점수 : {score}점 ");
            Console.WriteLine($" 학점 : {grade}학점 ");
        }
    }
}

