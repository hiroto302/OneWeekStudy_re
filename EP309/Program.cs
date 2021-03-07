using System;

namespace EP309
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1~99の乱数を10個生成
            Random rnd = new Random();
            int[] n = new int[10];
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 100);
                //表示
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();

            // 0以上10未満のｎ配列の要素を表示
            for(int i = 0; i < 100; i += 10)
            {
                Console.Write("{0}以上{1}未満 : ", i , i + 10);
                foreach( int j in n)
                {
                    if(i <= j && j < i +10)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
