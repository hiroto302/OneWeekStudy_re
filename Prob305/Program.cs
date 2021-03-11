using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob305
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生成するランダム値の個数
            int n = 5;
            // 生成したランダム値を格納するList
            List<int> nums = new List<int>();
            // ランダムクラスのインスタンス
            Random rnd = new Random();
            // Listに５個追加
            while( n > 0)
            {
                nums.Add(rnd.Next(1, 100));
                n--;
            }
            // Listの表示
            foreach(int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("最大値 : {0} 最小値 : {1}", nums.Max(), nums.Min());

        }
    }
}
