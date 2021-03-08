using System;

namespace S_401
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            // Personクラスのメソッドのインスタンス生成
            p1 = new Person();
            p2 = new Person();
            // 一人目の設定
            p1.name = "hiro";
            p1.age = 19;
            // 二人目
            p2.SetAgeAndName("kelly", 21);
            // それぞれの情報開示
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
