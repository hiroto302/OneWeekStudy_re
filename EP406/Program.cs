using System;

namespace EP406
{
    class Program
    {
        static void Main(string[] args)
        {
            // ビンゴクラスのインスタンス
            Bingo bingo = new Bingo();
            // ビンゴのサイズ入力
            Console.Write("ビンゴのサイズ : ");
            bingo.Size = int.Parse(Console.ReadLine());
            // ビンゴカードの作成
            bingo.MakeBingoCard(bingo.Size);
            // カードの表示
            bingo.ShowCard();
        }
    }
}
