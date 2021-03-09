using System;

namespace S_506
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p2 = new Program();

            Sub s = new Sub();

            // オブジェクトクラスのメソッド
            Console.WriteLine("ToStringメソッド : " + s.ToString());
            Console.WriteLine("GetTypeメソッド : " + s.GetType());
            Console.WriteLine("Equalsメソッド : " + p.Equals(p));
        }
    }
}
