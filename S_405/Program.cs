using System;

namespace S_405
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 p2 = new Person2();
            p2.SetNameAndAge("hiro", 302);
            p2.Age = 17;
            // p2.Name = "kelly";　Nameは読み込み専用
            Console.WriteLine(p2.Name + " " + p2.Age);
        }
    }
}
