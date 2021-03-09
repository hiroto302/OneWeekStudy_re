using System;

namespace EP505
{
  class Mice : Mammals
  {
    // 種類
    public static string type = "mice";
    // コンストラクタ
    public Mice() : base(type)
    {
    }
    // 鳴き声
    public override void Sing()
    {
      Console.WriteLine("cyu-");
    }
  }
}