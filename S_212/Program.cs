using System;

namespace S_212
{
    class Program
    {
        static void Main(string[] args)
        {
            // サイコロの目の入力
            Console.Write("サイコロの目(1~6)を入力 : ");
            int dice = int.Parse(Console.ReadLine());
            // 入力値が、偶数か奇数であるか
            switch( dice )
            {
                // 奇数の時
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("奇数");
                    break;
                // 偶数の時
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("偶数");
                    break;
                // 範囲外の入力の時
                default:
                    Console.WriteLine("範囲外");
                    break;
            }
        }
    }
}
