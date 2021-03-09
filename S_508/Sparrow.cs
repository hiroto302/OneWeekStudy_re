using System;

namespace S_508
{
  class Sparrow : Bird
  {
    // コンストラクタ
    public Sparrow() : base("スズメ")
    {
    }
    // 鳴き声
    public override void Sing()
    {
      Console.WriteLine("chun chun");
    }
  }
}