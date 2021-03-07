using System;

namespace EP302
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力される値
            int n;
            // 入力
            Console.Write("正数を入力 : ");
            n = int.Parse(Console.ReadLine());
            // 正数であるか
            if( 0 < n )
            {
                // 約数を割出し、表示
                for(int i = n; 0 < i; i--)
                {
                    // 約数の判定
                    if(n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("正数を入力せよ");
            }
        }
    }
}
