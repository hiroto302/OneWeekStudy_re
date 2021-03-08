using System;

namespace EP401
{
    class Program
    {
        static void Main(string[] args)
        {
            // インスタンス生成
            Rectangle rec = new Rectangle();
            // recの情報設定と開示
            rec.width = 5;
            rec.height = 10;
            double area = rec.GetArea();
            double perimeter = rec.GetPerimeter();
            Console.WriteLine("幅 : {0}", rec.width);
            Console.WriteLine("高さ : {0}", rec.height);
            Console.WriteLine("面積 : {0}", rec.GetArea());
            Console.WriteLine("周 : {0}", rec.GetPerimeter());
        }
    }
}
