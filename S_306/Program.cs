using System;

namespace S_306
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列のインスタンス生成
            double[] d = new double[3];
            // 変数の初期化
            d[0] = 1.2;
            d[1] = 3.7;
            d[2] = 4.1;
            // 合計、平均値の変数
            double sum, avg;
            sum = 0;
            // 合計値
            for(int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + " ");
                sum += d[i];
            }
            Console.WriteLine();
            // 平均値
            avg = sum / d.Length;
            Console.WriteLine("合計値 : " + sum);
            Console.WriteLine("平均値 : " + avg);
        }
    }
}
