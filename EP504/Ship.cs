using System;

namespace EP504
{
  // 抽象クラス 船
  abstract class Ship
  {
    // 抽象プロパティー
    public abstract string Type
    {
      set;
      get;
    }
    // 航海メソッド
    public void Sail()
    {
      Console.WriteLine("航行する");
    }

  }
}
