namespace ArrayGetLEngthDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rank 와 Length() 사용

            // 3차원 배열 선언(요소 개수 생성), 초기화(층,행,열)
            int[,,] arr = new int[2, 2, 2]
                { { {1,2 }, { 3,4} }, {{ 5,6}, { 7,8} }};

            Console.WriteLine("차수 출력 : {0}", arr.Rank);
            Console.WriteLine("길이 출력 : {0}", arr.Length);


            //층(면), 행, 열 구분해서 출력
            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    for(int k =0; k < arr.GetLength(2); k++) 
                    {
                        Console.Write("{0}\t", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
