namespace 열거형으로_관련_있는_항목_묶기
{
    class EnumAnimal
    {
        enum Animal { Mouse, Cow, Tiger }

        static void Main()
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);

            if (animal == Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }
        }
    }
}
