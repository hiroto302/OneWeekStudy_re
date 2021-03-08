using System;

namespace EP402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力 : ");
            string str = Console.ReadLine();
            // 大文字で表示
            Console.WriteLine("大文字 : {0}", str.ToUpper());
            Console.WriteLine("小文字 : {0}", str.ToLower());
        }
    }
}
