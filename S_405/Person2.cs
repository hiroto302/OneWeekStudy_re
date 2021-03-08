using System;

namespace S_405
{
  class Person2
  {
    // 自動実装プロパティー(フィールドを必要としない)
    public string Name
    {
      // private クラス内のみプロパティーにアクセス可能
      // 読み込み専用
      private set;
      get;
    }
    public int Age
    {
      set; get;
    }

    // 情報の設定
    public void SetNameAndAge(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }
}