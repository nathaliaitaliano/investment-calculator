using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Broker
    {
        private readonly double brokerTax;

        public Broker(double brokerTax)
        {
            this.brokerTax = (1 - (brokerTax / 100));
        }

        public double BuyStocks(double investmentMoney, Quote quote)
        {
            return investmentMoney * this.brokerTax / quote.opening;
        }
    }
}