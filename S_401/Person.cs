using System;

namespace S_401
{
  class Person
  {
    // フィールド
    // 名前
    public string name = "";
    // 年齢
    public int age = 0;

    // メソッド
    // 情報の開示
    public void ShowAgeAndName()
    {
      Console.WriteLine("名前:{0}, 年齢:{1}", name, age);
    }
    //情報の設定
    public void SetAgeAndName(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

  }
}