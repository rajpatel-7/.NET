using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class RBI
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("RBI interest calculation method.");
        }
    }

    class HDFC : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("HDFC interest rate is 7.5%.");
        }
    }

    class SBI : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("SBI interest rate is 6.8%.");
        }
    }

    class Kotak_Mahindra_Bank : RBI
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Kotak interest rate is 7.2%.");
        }
    }
}
