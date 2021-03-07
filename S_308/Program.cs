using System;

namespace S_308
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列の宣言と初期化
            int[] n = {1, 2, 3, 4, 5};
            // 要素の表示
            foreach (var i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
