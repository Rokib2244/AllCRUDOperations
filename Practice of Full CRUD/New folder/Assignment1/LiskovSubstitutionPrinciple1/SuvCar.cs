using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple1
{
   public  class SuvCar :Vehicle
    {
        public override string VehicleType()
        {
            return "This is SuvCar type Vehicle";
        }
    }
}
