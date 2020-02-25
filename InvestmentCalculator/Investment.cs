using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class Investment
    {
        private StockHistory history;
        private Broker broker;

        public Investment(StockHistory history, Broker broker)
        {
            this.history = history;
            this.broker = broker;
        }
        public double Open(DateTime openingDate, DateTime closeDate, double amount)
        {
            Wallet wallet = new Wallet();
            DateTime currentMonth = openingDate;
            DateTime limitDate = closeDate;
            InvestmentDateCalculator investmentDateCalculator = new InvestmentDateCalculator();

            while (currentMonth < closeDate)
            {
                DateTime investmentDate = investmentDateCalculator.GetBuyDate(currentMonth, history, limitDate);
                Quote quote = history.Get(investmentDate);
                double totalStocks = broker.BuyStocks(amount, quote);
                wallet.AddStocks(totalStocks);
                currentMonth = currentMonth.AddMonths(1);
            }
            return wallet.TotalStocks();
        }
        public double Close(Wallet wallet, DateTime closingDate)
        {
            double totalPrice = broker.SellStocks(wallet.TotalStocks(), history.Get(closingDate));
            return totalPrice;
        }
    }
}
