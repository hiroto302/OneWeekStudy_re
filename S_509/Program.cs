using System;

namespace S_509
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.X = 1.1;
            v.Y = 2.1;
            Console.WriteLine("(x, y) = ({0}, {1})", v.X, v.Y);
        }
    }
}
