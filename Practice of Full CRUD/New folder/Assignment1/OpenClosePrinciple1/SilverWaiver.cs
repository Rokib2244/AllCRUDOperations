using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple1
{
    public class SilverWaiver : Waiver
    {
        public override double GetWaiver(double amount)
        {
            return base.GetWaiver(amount) - 8000;
        }
    }
}
