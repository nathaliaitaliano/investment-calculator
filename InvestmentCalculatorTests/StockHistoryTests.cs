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
    public class StockHistoryTests
    {
        [TestMethod()]
        public void Test_should_true_quote_exists_in_a_day()
        {
            StockHistory history = new StockHistory();
            Quote quote = new Quote(2, 4);
            DateTime date = new DateTime(2010, 2, 24);
            DateTime sameDate = new DateTime(2010, 2, 24);
            DateTime dateNotExist = new DateTime(2020, 8, 9);

            history.Add(date, quote);

            Assert.IsTrue(history.HasQuoteOnDate(date));
            Assert.IsTrue(history.HasQuoteOnDate(sameDate));
            Assert.IsFalse(history.HasQuoteOnDate(dateNotExist));
        }
    }
}