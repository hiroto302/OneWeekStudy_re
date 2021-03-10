using System;
using System.Collections.Generic;

namespace S_603
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , string> capital = new Dictionary<string, string>();
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["中国"] = "北京";
            Console.WriteLine("世界の首都");
            foreach(string a in capital.Keys)
            {
                Console.WriteLine("{0}の首都 : {1}", a, capital[a]);
            }
            foreach(string a in capital.Values)
            {
                Console.WriteLine(a);
            }
        }
    }
}
