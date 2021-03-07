using System;

namespace S_310
{
    class Program
    {
        static void Main(string[] args)
        {
            // ジャグ配列の宣言、および生成
            // 配列の中に配列を生成
            // 0番目の配列に0と１を格納,2番目の配列に2を格納,3番目の箱に3,4,5,6を格納
            int[][] a = new int[][]{new int[]{0, 1}, new int[]{2}, new int[]{3, 4, 5, 6}};
            // 要素の表示
            for(int m = 0; m < a.Length; m++) // a.Length ジャグ配列に格納している配列の個数
            {
                for(int n = 0; n < a[m].Length; n++) // a[m].Length m番目の配列の中に格納している要素の数
                {
                    Console.Write(a[m][n] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
