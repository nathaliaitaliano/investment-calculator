using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Quote
    {
        public double opening { get; private set; }
        public double closing { get; private set; }

        public Quote(double opening, double closing)
        {
            this.opening = opening;
            this.closing = closing;
        }
    }
}
