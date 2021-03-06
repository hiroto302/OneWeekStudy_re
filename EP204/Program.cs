using System;

namespace EP204
{
    class Program
    {
        static void Main(string[] args)
        {
            // 日数
            string dayNumber;
            // 月の入力
            Console.Write("月(1~12)を入力して下さい : ");
            int month = int.Parse(Console.ReadLine());
            // 日数の判定
            switch ( month )
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = "31日";
                    break;
                case 2:
                    dayNumber = "28日か29日";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = "30日";
                    break;
                default:
                    Console.WriteLine("該当がありません");
                    // 該当の値がない時、メソッド処理の終了
                    return;
            }
            // 結果の表示
            Console.WriteLine("{0}月の日数は、{1}です", month, dayNumber);
        }
    }
}
