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

            DateTime referenceDate = new DateTime(2020, 2, 1);
            DateTime buyDate = new DateTime(2020, 2, 28);

            Assert.AreEqual(buyDate, investmentDate.GetBuyDate(referenceDate));
        }
    }
}