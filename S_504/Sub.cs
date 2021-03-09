using System;

namespace S_504
{
  // Superクラスを継承
  class Sub : Super
  {
    // コンストラクタ　引数なし
    public Sub()
    {
      Console.WriteLine("子クラス引数なしコンストラクタ");
    }
    // コンストラクタ 引数あり
    // base(引数) をつけるとbase内の引数を親クラス引数ありのコンストラクタで実行してくれる
    // baseがなければ、親クラス引数なしが呼ばれる
    public Sub(int param) : base(param)
    {
      Console.WriteLine("子クラス引数ありコンストラクタ param = {0}", param);
    }
    // コンストラクタ 引数２つ
    // base で　引数を１つだけ渡すと、親クラスの引数１つを持つコンストラクタが呼ばれる
    public Sub(int param, int second) : base(param)
    {
      Console.WriteLine("子クラス引数ありコンストラクタ param = {0}, second = {1}", param, second);
    }
  }
}