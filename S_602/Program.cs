using System;
using System.Collections.Generic;

namespace S_602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            // data追加
            a.Add("one");
            a.Add("two");
            a.Add("three");
            a.Add("two");
            a.Add("four");
            // data削除
            a.Remove("two");
            a.RemoveAt(3);
            foreach( string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
