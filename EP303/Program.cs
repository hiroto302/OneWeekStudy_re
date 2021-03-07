using System;

namespace EP303
{
    class Program
    {
        static void Main(string[] args)
        {
            // ランダムに生成される数
            int rndNumber;
            // 入力される数
            int inputNumber;
            // ランダムクラスのインスタンス生成
            Random rnd = new Random();
            // 乱数生成 (0~10)
            // rndNumber = rnd.Next(0,11);
            rndNumber = rnd.Next(11);

            // ゲーム開始
            Console.WriteLine("数当てゲーム");
            Console.WriteLine("0~10の値を入力して下さい");
            // ３回以内に当てる
            for(int i = 1; i <= 3; i++)
            {
                Console.Write(i + "回目 : ");
                inputNumber = int.Parse(Console.ReadLine());
                // 正解の場合
                if(inputNumber == rndNumber)
                {
                    Console.WriteLine("正解です");
                    return;
                }
                // 数が大きい時
                else if( inputNumber > rndNumber)
                {
                    Console.WriteLine("大きい数です");
                }
                // 小さい時
                else
                {
                    Console.WriteLine("小さい数です");
                }
            }
            // 3回以内に当てれない時
            Console.WriteLine("ゲームオーバー");
            Console.WriteLine("正解は," + rndNumber + "です！");
        }
    }
}
