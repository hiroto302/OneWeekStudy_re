using System;
using System.Collections.Generic;

namespace S_601
{
    class Program
    {
        static void Main(string[] args)
        {
            // List変数
            List<int> a = new List<int>();
            // Add 値を0番目から順に挿入
            a.Add(3);
            a.Add(2);
            a.Add(1);
            // Insert 1番目に4を挿入 a[1] = 4 となる
            a.Insert(1, 4);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
        }
    }
}
