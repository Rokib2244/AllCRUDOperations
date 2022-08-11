using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNumber3ConsoleApp
{
   abstract class Discount
    {
        public double OriginalPrice { get; set; }
        public double DiscountPrice { get; set; }

        public Discount(double originalPrice, double discountPrice)
        {
            
        }
        public abstract void CalculateDiscount(double discountAmount);
    }
}
