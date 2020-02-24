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
            double stocksQuantity = investmentMoney * brokerTax / quote.opening;
            return Math.Round(stocksQuantity, 3);
        }

        public double SellStocks(double stocksQuantity, Quote quote)
        {
            double totalPrice = stocksQuantity * quote.closing;
            return Math.Round(totalPrice, 3);
        }
    }
}