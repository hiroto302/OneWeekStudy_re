using System;

namespace S_605
{
    // デリゲート　他のオブジェクトのメソッドを参照するオブジェクト 同一の戻り値の型、引数をとるメソッドに限る
    // delegate 戻り値　デリゲート名（引数のリスト)
    delegate void Operation(int a, int b);
    // クラス Calc
    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
    }
    // クラス Program
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Main(string[] args)
        {
            Calc c = new Calc();
            // デリゲートの設定
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);
            // 処理の追加
            o1 += new Operation(c.Mul);

            // デリゲートで設定したメソッドの呼び出し
            o1(2, 1);
            o2(2, 1);
        }
    }
}
