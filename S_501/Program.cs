using System;

namespace S_501
{
    class Program
    {
        static void Main(string[] args)
        {
            // 要素2つの配列作成
            Data[] d = new Data[2];
            // dataの数習得
            Data.ShowData();
            // インスタンス生成
            for(int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                Data.ShowData();
            }
        }
    }
}
