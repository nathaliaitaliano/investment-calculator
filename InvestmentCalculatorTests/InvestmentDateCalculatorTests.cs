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
    public class InvestmentDateCalculatorTests
    {
        [TestMethod()]
        public void Test_if_28_is_the_buy_date_of_february_2020()
        {
            InvestmentDateCalculator investmentDate = new InvestmentDateCalculator();
            StockHistory history = new StockHistory();
            Quote quote = new Quote(2, 4);

            DateTime referenceDate = new DateTime(2020, 2, 1);
            DateTime buyDate = new DateTime(2020, 2, 28);
            history.Add(buyDate, quote);

            Assert.AreEqual(buyDate, investmentDate.GetBuyDate(referenceDate, history));
        }

        public void Test_if_return_the_next_quote_day()
        {
            InvestmentDateCalculator investmentDate = new InvestmentDateCalculator();
            StockHistory history = new StockHistory();
            Quote quote = new Quote(1, 2);

            DateTime referenceDate = new DateTime(2020, 1, 1);
            DateTime buyDate = new DateTime(2020, 1, 31);
            history.Add(buyDate, quote);

            Assert.AreEqual(buyDate, investmentDate.GetBuyDate(referenceDate, history));
        }
    }
}