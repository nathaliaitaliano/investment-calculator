using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Wallet
    {
        double stocksQuantity = 0;
        public void AddStocks(double stocksQuantity)
        {
            this.stocksQuantity += stocksQuantity;
        }

        public double TotalStocks()
        {
            return this.stocksQuantity;
        }
    }
}
