using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple1
{
    public class SedanCar: Vehicle
    {
        public override string VehicleType()
        {
            return "This is SedanCar Type Vehicle";
        }
    }
}
