using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple1
{
   public class Bus : Vehicle
    {
        public override string VehicleType()
        {
            return "This is Bus type Vehicle";
        }
    }
}
