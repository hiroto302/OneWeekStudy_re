using System;

namespace EP205
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力キーワードの変数
            string keyWord = "Hello";
            // 入力されるワード
            string inputWord;
            // 指令
            Console.Write("{0}と入力して！ : ", keyWord);
            // 入力
            inputWord = Console.ReadLine();

            // 変数による判定
            // if( keyWord == inputWord )
            // {
            //     Console.WriteLine("World!!");
            // }
            // else
            // {
            //     Console.WriteLine("ちゃんと入力しろ!");
            // }

            // 文字列の比較による判定
            // if( inputWord.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            if( inputWord.Equals(keyWord, StringComparison.OrdinalIgnoreCase)) // 第二引数により比較のオプション追加できる
            {
                Console.WriteLine("World!!");
            }
            else
            {
                Console.WriteLine("ちゃんと入力しろ!");
            }
        }
    }
}
