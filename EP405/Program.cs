using System;

namespace EP405
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力 : ");
            string str = Console.ReadLine();
            Console.WriteLine("文字数 : {0}", str.Length);
        }
    }
}
