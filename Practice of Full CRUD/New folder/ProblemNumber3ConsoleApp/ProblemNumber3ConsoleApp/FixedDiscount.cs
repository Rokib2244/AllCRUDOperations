using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNumber3ConsoleApp
{
    class FixedDiscount : Discount
    {
        
        public FixedDiscount(double originalPrice, double discountPrice) : base(originalPrice, discountPrice)
        {
        }


        public override void CalculateDiscount(double discountAmount)
        {
            DiscountPrice = discountAmount;
        }
    }
}
