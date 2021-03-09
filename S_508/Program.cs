using System;

namespace S_508
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crow c = new Crow();
            // Sparrow s = new Sparrow();
            // Console.Write("{0}の鳴き声 : ", c.Name);
            // c.Sing();
            // Console.Write("{0}の鳴き声 : ", s.Name);
            // s.Sing();

            // 抽象クラスの変数 を用いて上記の書き換え
            Bird[] b = new Bird[2];
            b[0] = new Crow();
            b[1] = new Sparrow();

            foreach(Bird i in b)
            {
                Console.Write("{0}の鳴き声 : ", i.Name);
                i.Sing();
            }


        }
    }
}
