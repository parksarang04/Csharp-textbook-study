using System;

namespace 구조체_배열
{
    //BusinessCard , Name, Age

    struct BusinessCard
    {
        public string Name;
        public int Age;
    }

    class StructArry
    {
        static void Print(string name, int age)
            => Console.WriteLine($"{name}은 {age}입니다.");

        static void Main()
        {
            BusinessCard biz;
            biz.Name = "박사랑";
            biz.Age = 25;
            Print(biz.Name, biz.Age);

            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "장경민"; names[0].Age = 24;
            names[1].Name = "이연주"; names[1].Age = 26;
            for(int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}
