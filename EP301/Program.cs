using System;

namespace EP301
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力数
            int number;
            // 出力文字
            string word = "$";
            Console.Write( word + "の数を入力 : ");
            number = int.Parse(Console.ReadLine());
            // for文
            for(int i = 1; i <= number; i++)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            // while文
            int j = 0;
            while( j < number)
            {
                Console.Write(word + " ");
                j++;
            }
            Console.WriteLine();
            // do ~ while文
            int k = 0;
            if( 0 < number)
            {
                do
                {
                    Console.Write(word + " ");
                    k++;
                }
                while(k < number);
                Console.WriteLine();
            }
        }
    }
}
