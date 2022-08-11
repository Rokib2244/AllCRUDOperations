using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple2
{
   public class VacationalAllowance : Salary
    {
        public override double CalculateSalary(double amount)
        {
            return base.CalculateSalary(amount) * 0.10;
        }
    }
}
