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
    public class WalletTests
    {
        [TestMethod()]
        public void Test_if_add_stock_in_wallet()
        {
            Wallet wallet = new Wallet();

            double stocksQuantity = 3;
            double totalStocks = 3;
            wallet.AddStocks(stocksQuantity);

            Assert.AreEqual(totalStocks, wallet.TotalStocks());
        }

    }
}