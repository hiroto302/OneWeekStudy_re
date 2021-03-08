using System;

namespace S_403
{
  class Person
  {
    // フィールド　名前・年齢
    private string name = "";
    private int age = 0;
    // 情報の設定
    public void SetNameAndAge(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
    // 情報の開示
    public void ShowNameAndAge()
    {
      Console.WriteLine("名前 : {0} 年齢 : {1}", name, age);
    }

    // 情報の設定
    public string Name
    {
      set { name = value; }
      get { return name; }
    }

    public int Age
    {
      set { age = value;}
      get {return age;}
    }
  }
}