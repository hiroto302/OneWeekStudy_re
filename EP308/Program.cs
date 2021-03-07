using System;

namespace EP308
{
    class Program
    {
        static void Main(string[] args)
        {
            // ランダムクラスのインスタンス
            Random rnd = new Random();
            // 整数の配列
            int[] n = new int[10];
            // 1~100の乱数を10個生成し、表示
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            // 大きい値順にならべかえる
            for(int j = 0; j < n.Length; j++)
            {
                // 仮の最大値
                int max = 0;
                // 仮の最大値の位置
                int pos = 0;
                for(int i = 0; i < n.Length; i++)
                {
                    if(n[i] > max)
                    {
                        max = n[i];
                        pos = i;
                    }
                }
                // 最大値表示
                Console.Write(max + " ");
                // 表示した、最大値の要素を0にする
                n[pos] = 0;
            }
            Console.WriteLine();
        }
    }
}
