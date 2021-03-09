using System;

namespace S_503
{
    class Program
    {
        static void Main(string[] args)
        {
            // 計算クラスのインスタンス生成
            Calculator c = new Calculator();
            ExCalculator exC = new ExCalculator();
            // 入力
            Console.WriteLine("2つの整数の四則演算結果");
            Console.Write("1つ目 : ");
            c.Num1 = int.Parse(Console.ReadLine());
            exC.Num1 = c.Num1;
            Console.Write("２つ目 : ");
            c.Num2 = int.Parse(Console.ReadLine());
            exC.Num2 = c.Num2;
            // 結果
            c.Add();
            c.Sub();
            exC.Mul();
            exC.Div();
            exC.Add();
        }
    }
}
