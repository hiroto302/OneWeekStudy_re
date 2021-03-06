using System;

namespace EP203
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数の宣言
            int num1, num2;
            float avg;

            // 変数への代入と入力
            Console.Write("num1 = ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            num2 = int.Parse(Console.ReadLine());

            // 平均値の算出
            avg = (float)(num1 + num2) / 2;

            // 平均値の出力
            Console.WriteLine("{0}と{1}の平均値 : {2}", num1, num2, avg);
        }
    }
}
