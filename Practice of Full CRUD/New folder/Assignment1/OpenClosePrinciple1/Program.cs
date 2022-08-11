using System;

namespace OpenClosePrinciple1
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiver goldenWaiver = new GoldenWaiver();
            Waiver silverWaiver = new SilverWaiver();
            Waiver diamondWaiver = new DimanodWaiver();


            double goldenWaiverAmount = goldenWaiver.GetWaiver(50000);
            double silverWaiverAmount = silverWaiver.GetWaiver(50000);
            double diamondWaiverAmount = diamondWaiver.GetWaiver(500000);
            Console.WriteLine(goldenWaiverAmount);
            Console.ReadKey();
        }
    }
}
