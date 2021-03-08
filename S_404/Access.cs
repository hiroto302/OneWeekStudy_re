using System;

namespace S_404
{
  class Access
  {
    // 読み込みオンリーのデータ
    private int data1 = 5;
    // 書き込みオンリーのデータ
    private int data2 = 0;
    // データの表示
    public void ShowData()
    {
      Console.WriteLine("data1 = {0} data2 = {1}", data1, data2);
    }
    // data1のプロパティー（読み込みオンリー)
    public int Data1
    {
      get {return data1;}
    }
    // data2 プロパティー (書き込みオンリー)
    public int Data2
    {
      set { data2 = value;}
    }

  }
}