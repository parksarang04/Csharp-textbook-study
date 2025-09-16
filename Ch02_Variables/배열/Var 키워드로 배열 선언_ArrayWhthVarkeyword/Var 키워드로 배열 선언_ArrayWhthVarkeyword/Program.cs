namespace Var_키워드로_배열_선언_ArrayWhthVarkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 5;                          //var -> 자동으로 정수 형식이 설정됨(int)

            Console.WriteLine("i : {0}, 타입 : {1}", i, i.GetType());

            var s = "Hello";
            Console.WriteLine("s : {0}, 타입 : {1}", s, s.GetType());

            var numbers = new int[] { 1, 2, 3 };
            foreach (var item in numbers)       //var item 에서 item은 numbers 형식
            {
                Console.WriteLine("item : {0}, 타입 : {1}", item, item.GetType());
            }
        }
    }
}
