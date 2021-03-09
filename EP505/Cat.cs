using System;

namespace EP505
{
  class Cat : Mammals
  {
    // 種類
    public static string type = "cat";
    // コンストラクタ
    public Cat() : base(type)
    {
    }
    // 鳴き声
    public override void Sing()
    {
      Console.WriteLine("nya-");
    }
  }
}