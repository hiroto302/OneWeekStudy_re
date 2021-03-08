using System;

namespace S_402
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcクラスのインスタンス生成
            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;
            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }
    }
}
