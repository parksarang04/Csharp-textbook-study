namespace 열거형_값을_정수형이나_문자열로_사용
{
    enum Animal { Rabbit, Dragon, Snake }

    class EnumIndex
    {
        static void Main()
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal;
            string str = animal.ToString();
            Console.WriteLine($"Animal.Dragon : {num},{str}");
        }
    }
}
