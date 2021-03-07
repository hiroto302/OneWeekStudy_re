using System;

namespace EP306
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数の配列生成
            int[] n = new int[5];
            // 整数の入力
            Console.WriteLine("整数を５回入力");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("{0}回目 : ", i+1);
                n[i] = int.Parse(Console.ReadLine());
            }
            // 表示
            foreach(int i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // 最大値と最小値の変数
            int max = n[0];
            int min = n[0];
            // 最大値と最小値の割出し
            foreach(int i in n)
            {
                if(max < i)
                {
                    max = i;
                }
                if(min > i)
                {
                    min = i;
                }
            }
            // 表示
            Console.WriteLine("最大値 : " + max);
            Console.WriteLine("最小値 : " + min);
        }
    }
}
