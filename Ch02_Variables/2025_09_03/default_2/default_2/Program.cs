using System;
using System.Text;

namespace default_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intDefault = default(int);        // int 형식의 기본값 (0)
            Console.WriteLine(intDefault);

            bool boolDefault = default(bool);     // bool 형식의 기본값 (false)
            Console.WriteLine(boolDefault);

            string stringDefault = default(string); // string 형식의 기본값 (null)
            Console.WriteLine(stringDefault);

            StringBuilder sbDefault = default(StringBuilder); // 참조 형식 기본값 (null)
            Console.WriteLine(sbDefault);
        }
    }
}
