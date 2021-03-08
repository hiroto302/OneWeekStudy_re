using System;

namespace S_403
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personクラスの変数, インスタンス生成
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            // p1,p2の情報設定
            p1.Name = "hiro";
            p1.Age = 17;
            p2.SetNameAndAge("kelly", 21);
            // 情報の開示 メソッド
            p1.ShowNameAndAge();
            // 情報の開示 プロパティー
            Console.WriteLine("名前 : {0} 年齢 : {1}", p2.Name, p2.Age);
        }
    }
}
