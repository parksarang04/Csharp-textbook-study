namespace 가변배열_Zigzag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[2][] 형태로 두 번째를 비워 두면 동적으로 자료 n개로 초기화 가능
            int[][] zagArray = new int[2][];

            zagArray[0] = new int[] { 1, 2 };
            zagArray[1] = new int[] { 3, 4, 5 };

            for(int i = 0; i < 2; i++)
            {
                // n번째 형의 길이만큼 반복: 두번 세번 반복
                for(int j =0; j < zagArray[i].Length; j++)
                {
                    Console.Write($"{zagArray[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
