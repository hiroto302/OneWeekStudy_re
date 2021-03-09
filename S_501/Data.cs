using System;

namespace S_501
{
  class Data
  {
    // データの数
    private static int n = 0;
    // データの値
    private int id;
    // コンストラクタ 引数あり
    public Data(int id)
    {
      this.id = id;
      n++;
      Console.WriteLine("id:{0} 数:{1}", this.id, n);
    }
    // dataの数取得
    public static void ShowData()
    {
      Console.WriteLine("dataの数 : {0}", n);
    }
  }
}