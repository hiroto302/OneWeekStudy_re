using System;

namespace S_210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("サイコロの目（１〜６）を入力 : ");
            // サイコロの目を入力
            int dice = int.Parse(Console.ReadLine());
            // サイコロの目が範囲内であるか
            if ( 1 <= dice && dice <= 6)
            {
                // サイコロの目が偶数の時
                if (dice % 2 == 0)
                {
                    Console.WriteLine("チョウです");
                }
                // 奇数の時
                else if( dice % 2 == 1)
                {
                    Console.WriteLine("ハンです");
                }
            }
            else
            {
                Console.WriteLine("範囲内の値ではありません");
            }
        }
    }
}
