using System;

namespace EP408
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoo hoo = new Hoo();
            hoo.Foo();
            hoo = null;
            // デストラクタ発動せん
        }
    }
}
