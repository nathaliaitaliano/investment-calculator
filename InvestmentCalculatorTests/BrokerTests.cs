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
    public class StockBuyTests
    {
        [TestMethod()]
        public void Test_if_broker_can_make_a_stock_buy()
        {
            var broker = new Broker(0);
            Quote quote = new Quote(2, 1);

            double investment = 10;
            double stocksQuantity = 5;

            Assert.AreEqual(stocksQuantity, broker.BuyStocks(investment, quote));
        }

        [TestMethod()]
        public void Test_if_broker_discount_fifty_percent_from_investment_money()
        {
            var broker = new Broker(50);
            Quote quote = new Quote(4, 3);

            double investment = 8;
            double stocksQuantity = 1;

            Assert.AreEqual(stocksQuantity, broker.BuyStocks(investment, quote));
        }

        [TestMethod()]
        public void Test_if_broker_can_make_a_stock_selling()
        {
            var broker = new Broker(0);
            Quote quote = new Quote(1, 2);

            double stocksQuantity = 5;
            double totalPrice = 10;

            Assert.AreEqual(totalPrice, broker.SellStocks(stocksQuantity, quote));
        }
    }
}