using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple2
{
   public  class Salary
    {
        public virtual double CalculateSalary(double amount)
        {
            return amount+25000;
        }
    }
}
