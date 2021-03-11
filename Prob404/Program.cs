using System;
using System.Collections.Generic;

namespace Prob404
{
    class Program
    {

        static void Main(string[] args)
        {
            // key int型の月 , value 文字列の月
            Dictionary<int , string> month = new Dictionary<int, string>();
            // データの追加
            month[1] = "一月";
            month[2] = "二月";
            month[3] = "三月";
            month[4] = "四月";
            try
            {
                // ユーザーによる入力
                Console.Write("1~4を入力 : ");
                int m = int.Parse(Console.ReadLine());
                // 対応したvalueの表示
                Console.WriteLine("{0}", month[m]);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("適切な値を入力せよ");
            }
        }
    }
}
