using System;

namespace S_508
{
  // 抽象クラス
  abstract class Bird
  {
    // フィールド　名称
    private string name;
    // コンストラクタ
    public Bird(string name)
    {
      this.name = name;
    }
    // プロパティー
    public string Name
    {
      get { return name; }
    }
    // 抽象メソッド 鳴き声
    public abstract void Sing();
  }
}