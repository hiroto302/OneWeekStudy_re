using System;

namespace EP310
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5*5の二次元配列作成
            const int SIZE = 5;
            int[,] data = new int[SIZE, SIZE];
            // 値を0で初期化
            for(int i = 0;  i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = 0;
                }
            }
            // 乱数の設定
            Random rnd = new Random();
            // セットする値
            int num = 1;
            while(num <= SIZE * SIZE)
            {
                while(true)
                {
                    // 数値の置く位置の決定
                    int m = rnd.Next(SIZE);
                    int n = rnd.Next(SIZE);
                    // まだその位置が０の時、値を設置する
                    if(data[m, n] == 0)
                    {
                        data[m, n] = num;
                        // セットする値の増加
                        num ++;
                        break;
                    }
                }
            }

            // 結果の表示
            for(int i = 0; i < data.GetLength(0); i++)
            {
                // 数値と縦線を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", data[i, j]);
                }
                Console.WriteLine();
                // 下線を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
    }
}
