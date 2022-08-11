using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNumber3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount1 = new FixedDiscount(1000, 9000);
            Discount discount2 = new PercentageDiscount(1000, 9000);
        }
    }
}
