using System;

namespace S_304
{
    class Program
    {
        static void Main(string[] args)
        {
            //乱数の初期設定
            Random rnd = new Random();
            Console.WriteLine("6が出たら終了");
            // 無限ループ
            while(true)
            {
                // 1以上7未満の乱数発生
                int dice = rnd.Next(1, 7);
                Console.WriteLine(dice);
                // ループ終了条件
                if(dice == 6)
                {
                    break;
                }
            }
            Console.WriteLine("終了");
        }
    }
}
