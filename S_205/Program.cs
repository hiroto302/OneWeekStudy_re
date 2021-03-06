using System;

namespace S_205
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            // 1つ目の文字列入力
            Console.Write("str1 = ");
            str1 = Console.ReadLine();
            // 2つ目の文字列入力
            Console.Write("str2 = ");
            str2 = Console.ReadLine();
            // 表示
            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
        }
    }
}
