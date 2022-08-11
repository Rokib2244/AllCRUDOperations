using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegragationPrinciple1
{
    interface IVehicleTask
    {
        public void CarWash()
        {
            Console.WriteLine("Car must be washed");
        }

        //interface IEngineReplace
        //{
        //    public void EngineReplacing()
        //    {
        //        Console.WriteLine("Engine replacing");
        //    }
        //}
        //interface ICarPolish
        //{
        //    public void CarPolishing()
        //    {
        //        Console.WriteLine("Car Polishing");
        //    }
        //}
    }
}
