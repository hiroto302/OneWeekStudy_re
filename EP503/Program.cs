using System;

namespace EP503
{
    class Program
    {
        static void Main(string[] args)
        {
            // ビンゴのサイズ
            int size;
            // ビンゴのサイズ入力
            Console.Write("ビンゴのサイズ : ");
            size = int.Parse(Console.ReadLine());
            // ビンゴクラスのインスタンス
            Bingo bingo = new Bingo(size);
            // ビンゴカードの作成
            // bingo.MakeBingoCard(bingo.Size);
            // カードの表示
            bingo.ShowCard();
        }
    }
}
