using System;

namespace EP206
{
    class Program
    {
        static void Main(string[] args)
        {
            // 温度の変数
            int temperature;
            // 入力
            Console.Write("H2Oの温度 : ");
            temperature = int.Parse(Console.ReadLine());
            // 判定
            if(100 <= temperature)
            {
                Console.WriteLine("気体");
            }
            else if( 0 >= temperature)
            {
                Console.WriteLine("固体");
            }
            else
            {
                Console.WriteLine("液体");
            }
        }
    }
}
