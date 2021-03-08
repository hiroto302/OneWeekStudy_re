using System;

namespace S_406
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person(); //　インスタンス生成　引数なし　
            p2 = new Person("hiro", 17); // 引数あり
            p1.Name = "kelly";
            p1.Age = 19;
            p1.Show();
            p2.Show();
        }
    }
}
