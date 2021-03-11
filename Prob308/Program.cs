using System;

namespace Prob308
{
    // 1~100の素数を表示するプログラム
    class Program
    {
        // 引数の値が素数であるか
        private static bool PrimNumberTest(int n)
        {
            // 引数が持つ約数の数 初期化
            int i = 0;
            // nを1~nの順で剰余
            for(int j = 1; j <= n; j++)
            {
                if(n % j == 0)
                {
                    i++;
                }
            }
            // 素数の判定 約数の数により判断
            if(i > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            // 素数の表示
            // 1~100生成
            for(int i = 1; i <= 100; i++)
            {
                // 素数判定
                if(PrimNumberTest(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
