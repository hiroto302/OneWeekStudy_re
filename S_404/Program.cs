using System;

namespace S_404
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            // 初期値data1とdata2の初期値表示
            a.ShowData();
            // data1は読み込み,data2は書き込みオンリー
            // a.Data1 = 2;
            a.Data2 = 2;
            a.ShowData();
            Console.WriteLine("data1 : {0}", a.Data1 );
            // Console.WriteLine("data2 : {0}", a.Data2 );
        }
    }
}
