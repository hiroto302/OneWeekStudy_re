using System;

namespace S_607
{
    class Program
    {
        // 計算処理 (例外を発生させる)
        private static int Calc(int a, int b)
        {
            return a / b;
        }
        // 範囲外出た時の処理
        public static int GetNum(int index)
        {
            // int[] num = { 1, 2, 3, 4, 5}; // 要素5つ
            int[] num = { 1, 2, 3, 4, 5, 6}; // 要素6つ
            return num[index];
        }
        static void Main(string[] args)
        {
            // 例外処理
            try
            {
                // 6回繰り返す処理
                for(int i = 0; i <= 5; i++)
                {
                    int a = GetNum(i);
                    int b = 5;
                    // int b = 0;
                    Console.WriteLine("{0} / {1} = {2}", a, b, Calc(a, b));
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("範囲外に接続");
            }
            finally
            {
                Console.WriteLine("終了します");
            }
        }
    }
}
