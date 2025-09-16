namespace ArrayTotalAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 국어 점수의 총점과 평균 구하기

            int[] kor = new int[3];
            int sum = 0;
            float avg = 0;

            kor[0] = 100;
            kor[1] = 90;    
            kor[2] = 80;

            sum = kor[0] + kor[1] + kor[2]; //총점 계산
            avg = sum / 3.0f; //평균 계산

            //총점과 평균 출력 : 평균은 소수점 두 자리까지 출력
            Console.WriteLine($"총점 : {sum}, 평균 : {avg:f2}");

            Ex_1();
            Ex_2();
        }

        static void Ex_1()
        {
            // 1차원 배열 문자열 선언과 초기화
            string[] languages = { "korean", "English", "SPanish" };
            Console.WriteLine($"{languages[0]},{languages[1]},{languages[2]}");
        }

        static void Ex_2()
        {
            // 1차원 배열 값을 입력받아 저장한 후 출력하기

            //요소가 3개인 1차원 배열 선언
            int[] students = new int[3];

            //사용자에게 정수 데이터 3개를 입력받아 배열에 저장
            students[0] = Convert.ToInt32(Console.ReadLine());
            students[1] = Convert.ToInt32(Console.ReadLine());
            students[2] = Convert.ToInt32(Console.ReadLine());

            //총점을 구하고 출력
            int total = students[0] + students[1] + students[2];
            float avg = total / 3.0f;
            Console.WriteLine($"총점 : {total}, 평균: {avg:F1}");
            
        }
    }
}
