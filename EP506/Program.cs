using System;

namespace EP506
{
    class Program
    {
        static void DriveACar(IDriver id)
        {
            id.Drive();
        }
        static void MaintainACar(IMechanical im)
        {
            im.Maintain();
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            DriveACar(car);
            MaintainACar(car);
        }
    }
}
