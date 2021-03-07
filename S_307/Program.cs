using System;

namespace S_307
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = {5, 4, 3, 2, 1 };
            string[] s = {"a", "b", "c"};
            int i;
            // 整数型配列の要素表示
            for(i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
            // 文字列型配列の要素表示
            for(i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
