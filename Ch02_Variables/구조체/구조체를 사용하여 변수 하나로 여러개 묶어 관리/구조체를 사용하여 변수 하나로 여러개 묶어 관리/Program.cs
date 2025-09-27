using System;
using System.Net.Http.Headers;

namespace 구조체를_사용하여_변수_하나로_여러개_묶어_관리
{
    class StructVariable
    {
        static void Main()
        {
            Product product;    //구조체 형식 변수 선언

            //구조체 변수의 각 멤버의 값을 할당
            product.Id = 1;
            product.Title = "좋은 책";
            product.Price = 100000M;

            //구조체 형식 변수 선언
            string message = $"번호 : {product.Id}\n상품명 :{product.Title}\n 가격 : {product.Price}";
            Console.WriteLine(message);
        }
    }
    struct  Product
    {
        public int Id;
        public string Title;
        public decimal Price;
    }
}
