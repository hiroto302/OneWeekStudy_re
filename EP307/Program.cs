using System;

namespace EP307
{
    class Program
    {
        static void Main(string[] args)
        {
            // Randomクラスのインスタンス生成
            Random rnd = new Random();
            // 整数の配列
            int[] n = new int[10];
            // 1~100乱数10個生成
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 101);
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            // 偶数と奇数の判定と表示
            string[] names = {"偶数 : ", "奇数 : "};
            for(int i = 0;  i < names.Length; i++)
            {
                Console.Write(names[i]);
                foreach( int j in n)
                {
                    if(j % 2 == i)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
