using System;

namespace EP505
{
    class Program
    {
        public static void Line()
        {
            Console.WriteLine("--------------");
        }
        static void Main(string[] args)
        {
            Mammals[] mammals = new Mammals[2];
            mammals[0] = new Cat();
            mammals[1] = new Mice();
            foreach(Mammals m in mammals)
            {
                Console.WriteLine("type : {0}", m.Name);
                m.Sing();
                Line();
            }
        }
    }
}
