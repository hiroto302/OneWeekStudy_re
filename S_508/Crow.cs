using System;

namespace S_508
{
  class Crow : Bird
  {
    // コンストラクタ
    public Crow() : base("カラス")
    {
    }
    // 鳴き声
    public override void Sing()
    {
      Console.WriteLine("ka-ka-");
    }
  }
}