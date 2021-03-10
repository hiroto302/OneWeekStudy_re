using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob103
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力される実数値を格納するList
            List<double> n = new List<double>();
            // 文字列の配列
            String[] s = {"a", "b", "c"};
            // 実数値の入力
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write("{0} = ", s[i]);
                n.Add(double.Parse(Console.ReadLine()));
            }
            // 結果の表示
            Console.WriteLine("sum : " + n.Sum());
            Console.WriteLine("avg : " + n.Average());
        }
    }
}
