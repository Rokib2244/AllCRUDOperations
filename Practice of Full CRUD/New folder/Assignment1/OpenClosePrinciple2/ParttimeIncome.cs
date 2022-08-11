using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple2
{
    public class ParttimeIncome :Salary
    {
        public override double CalculateSalary(double amount)
        {
            return base.CalculateSalary(amount) * 0.25;
        }
    }
}
