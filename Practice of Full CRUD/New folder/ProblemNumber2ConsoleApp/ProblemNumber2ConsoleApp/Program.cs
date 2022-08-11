using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNumber2ConsoleApp
{
    class ShoppingCart<P1>
    {
        public P1 MyPropertyP1 { get; set; }
        

        public P1 AddItem(P1 p1)
        {

            return p1 += p1;
        }
        public P1 RemoveItem(P1 p1)
        {

            return p1 -= p1;
        }
        public P1 ClearCart(P1 p1)
        {

            return p1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart<int> shoppingCart1 = new ShoppingCart<int>();
            shoppingCart1.MyPropertyP1 = 10;
            shoppingCart1.AddItem(10);
            shoppingCart1.RemoveItem(10);
            shoppingCart1.ClearCart(10);
        }
    }
}
