using System;
using System.Xml.Linq;

namespace 구조체_매개변수_함수의_매개변수에_구조체_사용
{
    //Member
    //StructParamrter
    
    //1. 구조체 선언
    struct Member
    {
        public string Name;
        public int Age;
    }

    public class StructParamrter
    {
        static void Main()
        {
            string name = "박사랑";
            int age = 25;
            Print(name, age);

            Member m;
            m.Name = "장경민";
            m.Age = 24;
            Print(m);
        }
        static void Print(string name, int age) =>
            Console.WriteLine($"이름 : {name}, 나이 : {age}");

        static void Print(Member member) =>
            Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
    }

}
