using System;

namespace EP505
{
  abstract class Mammals
  {
    // 名前
    protected string name;
    // プロパティー
    public string Name
    {
      get { return name; }
    }
    // コンストラクタ
    public Mammals(string name)
    {
      this.name = name;
    }
    // 鳴き声
    public abstract void Sing();
  }
}