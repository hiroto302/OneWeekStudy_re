using System;

namespace S_302
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 2; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    Console.Write("{0}+{1}={2} ", i, j, i + j);
                }
                Console.WriteLine();
            }
        }
    }
}
