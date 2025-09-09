using System.ComponentModel;

namespace SequenceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kor = 100;
            int eng = 90;

            int total = 0;
            double avg = 0.0;

            total = kor + eng;
            avg = total / 2.0;

            Console.WriteLine($"총점 : {total}");
            Console.WriteLine($"평균 : {avg:F1}");
        }
    }
}
