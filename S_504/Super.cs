using System;

namespace S_504
{
  // Super・ベース・親クラス
  class Super
  {
    // パラメーター
    private int param = 0;
    // コンストラクタ 引数なし
    public Super()
    {
      Console.WriteLine("親クラス引数なしコンストラクタ");
    }
    // コンストラクタ　引数あり
    public Super(int param)
    {
      Console.WriteLine("親クラス引数ありコンストラクタ param = {0}", param);
      this.param = param;
    }
    // コンストラクタ　引数あり2つ
    public Super(int param, int second)
    {
      Console.WriteLine("親クラス2つ引数ありコンストラクタ param = {0} Second = {1}", param, second);
      this.param = param;
    }
  }
}