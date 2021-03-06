using System;

namespace EP201
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数の宣言
            int a,b;
            // コンソールからの入力 a
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            // コンソールからの入力 b
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            // 計算式の表示
            Console.WriteLine(" a + b = {0}", a + b);
            Console.WriteLine(" a - b = {0}", a - b);
            Console.WriteLine(" a * b = {0}", a * b);
            Console.WriteLine(" a / b = {0}", a / b);
            Console.WriteLine(" a % b = {0}", a % b);
        }
    }
}
