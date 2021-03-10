using System;
using System.Collections.Generic;
using System.Linq;

namespace EP601
{
    class Program
    {
        static void Main(string[] args)
        {
            // List 変数
            List<int> n = new List<int>();
            // 最大値・最小値・合計・平均
            int max = 0, min = 0;
            float sum = 0;
            // 値の挿入
            Console.WriteLine("正の整数を入力");
            int j = 1;
            while(true)
            {
                int i = 0;
                Console.Write("{0}つ目 : ", j);
                i = int.Parse(Console.ReadLine());
                if( i < 0)
                {
                    break;
                }
                else
                {
                    n.Add(i);
                    j++;
                }
            }
            // 最大値と最小値を代入
            max = n[0];
            min = n[0];
            // 表示 と 計算
            foreach(int i in n)
            {
                Console.Write(i + " ");
                // 最大値と最小値の更新
                if( max < i)
                {
                    max = i;
                }
                if( min > i)
                {
                    min = i;
                }
                // 合計値
                sum += i;
            }
            Console.WriteLine();
            // 計算結果
            Console.WriteLine("max : {0}", max);
            Console.WriteLine("max : {0}", n.Max());
            Console.WriteLine("min : {0}", min);
            Console.WriteLine("min : {0}", n.Min());
            Console.WriteLine("sum : {0}", sum);
            Console.WriteLine("sum : {0}", n.Sum());
            Console.WriteLine("avg : {0}", sum / n.Count);
            Console.WriteLine("avg : {0}", n.Average());
        }
    }
}
