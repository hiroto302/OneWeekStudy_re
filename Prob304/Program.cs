using System;

namespace Prob304
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 正の整数の入力
                Console.Write("整数を入力 : ");
                int n = int.Parse(Console.ReadLine());
                // 負の整数が入力された時
                if(n < 1)
                {
                    throw new FormatException();
                }
                // 表示する倍数の数
                int[] nums = {2, 3, 5};
                // 倍数の表示
                for(int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}の倍数 : ", nums[i]);
                    int j = nums[i];
                    for(int k = j; k <= n; k += j)
                    {
                        Console.Write(k + " ");
                    }
                    // 改行
                    Console.WriteLine();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("正しい入力ではありません");
            }
        }
    }
}
