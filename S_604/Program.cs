using System;
using System.Collections.Generic;

namespace S_604
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(3);
            a.Add(1);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
