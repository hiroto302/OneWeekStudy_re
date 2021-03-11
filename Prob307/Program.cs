using System;

namespace Prob307
{
    // forの2重ループを用いて文字列を表示
    class Program
    {
        // 縦・横列の数
        int verticalNum = 0;
        int horizontalNum = 0;
        // 表示する文字
        string s1 = "$";
        string s2 = "!";
        // 縦列・横列の設定
        void SetNum()
        {
            Console.Write("縦列 : ");
            verticalNum = int.Parse(Console.ReadLine());
            Console.Write("横列 : ");
            horizontalNum = int.Parse(Console.ReadLine());
        }
        // 文字列の表の生成・表示
        void MakeAndShow()
        {
            for(int i = 0;  i < verticalNum; i++)
            {
                for(int j = 0; j < horizontalNum; j++)
                {
                    if((j + i) % 2 == 0)
                    {
                        Console.Write(s1 + " ");
                    }
                    else
                    {
                        Console.Write(s2 + " ");
                    }
                }
                Console.WriteLine();
            }
                // if(i % 2 == 0)
                // {
                //     for(int j = 0; j < horizontalNum; j++)
                //     {
                //         if(j % 2 == 0)
                //         {
                //             Console.Write(s1 + " ");
                //         }
                //         else
                //         {
                //             Console.Write(s2 + " ");
                //         }
                //     }
                //     Console.WriteLine();
                // }
                // else
                // {
                //         for(int j = 0; j < horizontalNum; j++)
                //     {
                //         if(j % 2 == 0)
                //         {
                //             Console.Write(s2 + " ");
                //         }
                //         else
                //         {
                //             Console.Write(s1 + " ");
                //         }
                //     }
                //     Console.WriteLine();
                // }
            // }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.SetNum();
            p1.MakeAndShow();
        }
    }
}
