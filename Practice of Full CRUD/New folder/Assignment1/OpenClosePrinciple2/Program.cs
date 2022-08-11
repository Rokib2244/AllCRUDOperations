using System;

namespace OpenClosePrinciple2
{
    class Program
    {
        static void Main(string[] args)
        {
           var partTimeIncome = new ParttimeIncome();
           var vacationalIncome = new VacationalAllowance();

           double partTimeIncomeAmount = partTimeIncome.CalculateSalary(25000);
           double vacationalIncomeAmount = vacationalIncome.CalculateSalary(25000);
           Console.WriteLine(partTimeIncomeAmount);
           Console.ReadKey();

        }
    }
}
