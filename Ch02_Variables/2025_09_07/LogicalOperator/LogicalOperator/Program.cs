namespace LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 3;
            var j = 5;
            var r = false;
            
            if ((i == 3) && (j !=5) || (i !=3) || (j==3))
            {
                Console.WriteLine(true);
            }
            else
            {
                {
                    Console.WriteLine(false);
                }
            }

            r = (i >= 5);
            Console.WriteLine("{0}", !r);
        }
    }
}
