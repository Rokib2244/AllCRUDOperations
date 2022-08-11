using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple1
{
   public class Waiver
    {
        public virtual double GetWaiver(double amount)
        {
            return amount - 5000;
        }
    }
}
