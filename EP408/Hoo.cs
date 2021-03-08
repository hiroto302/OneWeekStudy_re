using System;

namespace EP408
{
  class Hoo
  {
    public Hoo()
    {
      Console.WriteLine("Hooクラスのインスタンス生成されました");
    }
    public void Foo()
    {
      Console.WriteLine("FOooooooooooo!");
    }
    ~Hoo()
    {
      Console.WriteLine("デストラクタ発動");
    }
  }
}