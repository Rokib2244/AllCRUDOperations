using System;

namespace LiskovSubstitutionPrinciple1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new SedanCar();
            Console.WriteLine(vehicle1.VehicleType());
            Vehicle vehicle2 = new SuvCar();
            Console.WriteLine(vehicle2.VehicleType());
            Console.ReadKey();
        }
    }
}
