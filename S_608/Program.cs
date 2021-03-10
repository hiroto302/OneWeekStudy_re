using System;

namespace S_608
{
    class Program
    {
        static int GetNum(int i)
        {
            int[] nums = {300, 600, 900};
            // 範囲外の時の処理
            if(i > nums.Length)
            {
                // 例外を発生させる
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
        static void Main(string[] args)
        {
            try
            {
                int result =  GetNum(4);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("範囲外");
            }
        }
    }
}
