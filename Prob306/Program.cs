using System;

namespace Prob306
{
    // 入力した文字を返すプログラム
    class Program
    {
        static void Main(string[] args)
        {
            // while文を利用した記述
            while(true)
            {
                Console.Write("文字列を入力 : ");
                string s = Console.ReadLine();
                if(s == "")
                {
                    Console.WriteLine("終了");
                    break;
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
