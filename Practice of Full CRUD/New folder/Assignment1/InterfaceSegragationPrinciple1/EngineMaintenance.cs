using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple1
{
    class EngineMaintenance:IEngineReplace
    {
        public void EngineReplacing()
        {
            throw new NotImplementedException();
        }
    }
}
