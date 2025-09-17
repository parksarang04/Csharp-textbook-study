namespace 메서드_함수__오버로드_MethoodOverloadNumber
{
    internal class Program
    {
        // 함수 오버로드 = 같은 이름의 함수를 매개변수의 타입과 개수로 구분하여 여러 개 정의하는 것
        static void Main(string[] args)
        {
            GetNumber(1234);
            GetNumber(1234L);

            Hi();
            Hi("반갑습니다.");

            Multi();
            Multi("반갑습니다.");
            Multi("또 만나요", 3);
        }

        static void GetNumber(int number)       //GetNumber 함수 : int 매개변수
        {
            Console.WriteLine($"Int32 : {number}");
        }

        static void GetNumber(long number)      //GetNumber 함수 : long 매개변수
        {
            Console.WriteLine($"Int64 : {number}");
        }

        //매개변수가 없거나 있는 함수 오버로드

        static void Hi()                        // 매개변수가 없는 Hi() 함수
        {
            Console.WriteLine("안녕하세요");
        }

        static void Hi(string msg)              //매개변수가 있는 Hi() 함수
        {
            Console.WriteLine(msg);
        }

        //서로 다은 매개변수를 갖는 함수 오버로드
        static void Multi()
        {
            Console.WriteLine("안녕하세요,");
        }

        static void Multi(string massage)
        {
            Console.WriteLine(massage);
        }

        static void Multi(string massage, int count)
        {
            for (int i =0; i< count; i++)
            {
                Console.WriteLine("{0}", massage);
            }
        }
    }
}
