using System;

namespace EP503
{
  class Bingo
  {
    // フィールド
    // ビンゴカードのマスのサイズ
    private int size = 0;
    // private化
    private int[,] data;

    // プロパティ
    public int Size
    {
      set{ size = value;}
      get{ return size;}
    }

    // コンストラクタ 引数あり
    public Bingo(int size)
    {
      MakeBingoCard(size);
    }
    // 引数なし
    public Bingo() : this (5)
    {
    }

    // dataの初期化
    private void Clear()
    {
      // ArrayクラスClearメソッドの利用
      Array.Clear(data, 0, data.Length);
      // 値を0で初期化
      // for(int i = 0; i < data.GetLength(0); i++)
      // {
      //   for(int j = 0; j < data.GetLength(1); j++)
      //   {
      //     data[i,j] = 0;
      //   }
      // }
    }
    // dataにに数をランダムに配置
    private void Shuffle()
    {
      // 乱数のインスタンス
      Random rnd = new Random();
      // マスの値（初期値)
      int num = 1;
      // マスに値を設定
      while(num <= size * size)
      {
        while(true)
        {
          int m = rnd.Next(size);
          int n = rnd.Next(size);
          // マスに値に設定されていない時,マス値をセット
          if(data[m, n] == 0)
          {
            data[m, n] = num;
            // マスの値を増加
            num ++;
          }
          break;
        }
      }
    }
    // ビンゴカードを作成するメソッド
    public void MakeBingoCard(int size)
    {
      this.size = size;
      // sizeに合わせた二次元配列を生成
      data = new int[size, size];
      // 値を0で初期化
      Clear();
      // 値の配置
      Shuffle();
    }

    // 作成したビンゴカードを表示するメソッド
    public void ShowCard()
    {
      for(int i = 0; i < data.GetLength(0); i++)
            {
                // 数値と縦線を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", data[i, j]);
                }
                Console.WriteLine();
                // 下線を表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
    }
  }
}