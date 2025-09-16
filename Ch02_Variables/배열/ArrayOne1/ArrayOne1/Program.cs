namespace ArrayOne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 선언 및 초기화

            int[] intArry;              //1차원 배열 선언
            intArry = new int[3];       //메모리 영역 확보 (0, 1, 2)

            //배열 초기화
            intArry[0] = 1;
            intArry[1] = 2;
            intArry[2] = 3;

            // for 문 사용 출력 : 정확하게 배열 범위를 알고 있을 때
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i} 번째 인덱스 : {intArry[i]}");
            }

            //foreach 문 사용 출력 : intArry에 데이터가 있는 동안 반복
            foreach (int intValue in intArry)
            {
                 Console.WriteLine("{0}",intValue);
            }
            ArrayOne2();
            ArrayOne3();
            ArrayOne4();
        }
        
        static void ArrayOne2()
        {
            //1차원 배열 선언과 동시에 초기화
            int[] intArray = new int[3] { 1, 2, 3 }; //선언과 동시에 초기화

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i} 번째 인덱스 : {intArray[i]}");
            }

            foreach(int intValue in intArray)
            {
                Console.WriteLine("{0}", intValue);
            }
        }

        static void ArrayOne3()
        {
            //1차원 배열 var 키워드 사용

            var intArray = new int[] { 1, 2, 3 }; //선언과 동시에 초기화

            for (int i =0; i <3; i++)
            {
                Console.WriteLine($"{i} 번째 인덱스 : {intArray[i]}");
            }

            foreach(int intValue in intArray)
            {
                Console.WriteLine("{0}", intValue);
            }
        }

        static void ArrayOne4()
        {
            //1차원 배열 new 키워드 생략 배열형[] 생략

            int[] intArray = { 1, 2, 3 }; //선언과 동시에 초기화

            for(int i=0; i < 3; i++)
            {
                Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
            }
            foreach (int intValue in intArray)
            {
                Console.WriteLine("{0}", intValue);
            }
        }
    }
}
