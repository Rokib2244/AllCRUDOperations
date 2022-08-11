using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSegregationPrinciple1;

namespace InterfaceSegragationPrinciple1
{
    class CarMaintenence:IVehicleTask, ICarPolish, IEngineReplace
    {
        public void CarWash()
        {
            throw new NotImplementedException();
        }

        public void CarPolishing()
        {
            throw new NotImplementedException();
        }

        public void EngineReplacing()
        {
            throw new NotImplementedException();
        }
    }
}
