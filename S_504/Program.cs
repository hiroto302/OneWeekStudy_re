using System;

namespace S_504
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub[] sub = new Sub[3];
            // 引数なし 子クラスのインスタンス生成
            sub[0] = new Sub();
            // 引数あり 子クラスのインスタンス生成
            sub[1] = new Sub(100);
            // 引数2つあり 子クラスのインスタンス生成
            sub[2] = new Sub(100,200);
        }
    }
}
