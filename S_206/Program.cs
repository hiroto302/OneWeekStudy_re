using System;

namespace S_206
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER = 100;
            const string STRING = "Hoge";

            // const キーワード : 他のものを代入を防ぐ役割
            // NUMBER = 90;
            // STRING = "Fuga";

            Console.WriteLine(NUMBER);
            Console.WriteLine(STRING);

        }
    }
}
