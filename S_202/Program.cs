using System;

namespace S_202
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数の宣言
            int a;
            // 代入（初期化）
            a = 6;
            // 変数の宣言と初期化
            int b = 3;
            // 複数の変数宣言
            int add, sub;
            // 倍精度浮動小数の変数宣言
            double avg;
            // 和
            add = a + b;
            // 差
            sub = a - b;
            // 平均
            avg = (a + b) / 2.0;

            // 各変数の表示
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均は、{2}", a, b, avg);

        }
    }
}
