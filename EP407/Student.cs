using System;

namespace EP407
{
  class Student
  {
    // フィールド
    private string name;
    private int grade;
    private int age;

    // コンストラクタ
    public Student(string name, int grade, int age)
    {
      this.name = name;
      this.grade = grade;
      this.age = age;
    }

    public Student() : this("未登録子", 1, 1)
    {
      // 引数なしコンストラクタ
    }

    // 情報の開示
    public void ShowInformation()
    {
      Console.WriteLine("name : {0}, grade : {1}年 age : {2}", name, grade, age);
    }
  }
}