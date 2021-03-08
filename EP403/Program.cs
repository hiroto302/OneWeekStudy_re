using System;

namespace EP403
{
    class Program
    {
        static void Main(string[] args)
        {
            // ビンゴクラスのインスタンス
            Bingo bingo = new Bingo();
            // ビンゴのサイズ入力
            Console.Write("ビンゴのサイズ : ");
            bingo.size = int.Parse(Console.ReadLine());
            // ビンゴカードの作成
            bingo.MakeBingoCard(bingo.size);
            // カードの表示
            bingo.ShowCard();
        }
    }
}
