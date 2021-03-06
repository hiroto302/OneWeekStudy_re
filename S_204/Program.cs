using System;

namespace S_204
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, d;
            int c;
            a = 1.23;
            // キャストありの代入
            b = (double)12;
            c = (int)1.23;
            // キャストなしの代入
            d = 10;

            // 表示
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
        }
    }
}
