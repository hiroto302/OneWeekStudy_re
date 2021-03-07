using System;

namespace EP304
{
    class Program
    {
        static void Main(string[] args)
        {
            // 最大値と最小値の変数の初期化 for文で初期化してしまうとif文のローカル変数となるので、範囲外で使用するためにここで初期化を行う
            int max = 0;
            int min = 0;
            // 生成される値
            int n;
            // ランダムクラスのインスタンス生成
            Random rnd = new Random();
            // 1~100の値を10回生成
            for(int i = 0; i < 10; i++)
            {
                n = rnd.Next(1, 101);
                // 生成した値の表示
                Console.Write(n + " ");
                // 変数の初期設定
                if (i == 0)
                {
                    max = n;
                    min = n;
                }
                else
                {
                    // 最大値の取得
                    if( max < n)
                    {
                        max = n;
                    }
                    // 最小値の取得
                    else if (min > n)
                    {
                        min = n;
                    }
                }
            }
            Console.WriteLine();
            // 最大値、最小値の表示
            Console.WriteLine("最大値 : " + max);
            Console.WriteLine("最小値 : " + min);
        }
    }
}
