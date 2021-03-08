using System;

namespace S_406
{
    class Person
    {
        // フィールド
        string name = "";
        int age = 0;
        // コンストラクタ 引数なし
        public Person() : this("名無し", 0)
        {
          Console.WriteLine("引数なしコンストラクタ");
        }
        // コンストラクタ 引数あり
        public Person(string name, int age)
        {
          this.name = name;
          this.age = age;
          Console.WriteLine("引数ありコンストラクタ name : {0} age : {1}", name, age);
        }
        // 情報の開示
        public void Show()
        {
          Console.WriteLine("{0} age : {1}", name, age);
        }
        // プロパティー
        public string Name
        {
          set { name =  value;}
          get { return name;}
        }
        public int Age
        {
          set { age =  value;}
          get { return age;}
        }
    }
}
