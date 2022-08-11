using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple1
{
    interface IEngineReplace
    {
        public void EngineReplacing()
        {
            Console.WriteLine("Engine replacing");
        }
    }
}
