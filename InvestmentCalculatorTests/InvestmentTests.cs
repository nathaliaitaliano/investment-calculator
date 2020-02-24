using Microsoft.VisualStudio.TestTools.UnitTesting;
using InvestmentCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator.Tests
{
    [TestClass()]
    public class InvestmentTests
    {
        [TestMethod]
        public void Test_open_should_return_total_stocks_quantity()
        {
            StockHistory history = new StockHistory();
            Quote quote = new Quote(2, 4);
            Broker broker = new Broker(50);
            Investment investment = new Investment(history, broker);

            DateTime openDate = new DateTime(2020, 2, 10);
            DateTime closeDate = new DateTime(2020, 4, 10);
            DateTime februaryBuyDate = new DateTime(2020, 2, 28);
            DateTime marchBuyDate = new DateTime(2020, 3, 27);
            double stocksQuantity = 10;
            double amount = 20;
            history.Add(februaryBuyDate, quote);
            history.Add(marchBuyDate, quote);

            Assert.AreEqual(stocksQuantity, investment.Open(openDate, closeDate, amount));

        }

        [TestMethod()]
        public void Test_close_should_return_total_investment_amount()
        {
            StockHistory history = new StockHistory();
            Quote quote = new Quote(1, 2);
            Broker broker = new Broker(0);
            Investment investment = new Investment(history, broker);

            DateTime closeDate = new DateTime(2020, 3, 1);
            Wallet wallet = new Wallet();
            wallet.AddStocks(10);
            double totalPrice = 20;
            history.Add(closeDate, quote);

            Assert.AreEqual(totalPrice, investment.Close(wallet, closeDate));
        }
    }
}