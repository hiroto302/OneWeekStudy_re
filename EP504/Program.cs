using System;

namespace EP504
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleShip bS = new BattleShip();
            Console.WriteLine("種類 : {0}", bS.Type);
            bS.Sail();
            bS.Battle();
        }
    }
}
