using System;

namespace EP501
{
    class Program
    {
        // 四則演算の静的メソッド
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        // エントリーポイント
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Add(a,b));
            Console.WriteLine(Sub(a,b));
            Console.WriteLine(Mul(a,b));
            Console.WriteLine(Div(a,b));
        }
    }
}
