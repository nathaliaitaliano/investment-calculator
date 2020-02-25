using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//retornar o dia da compra de aÇoes
namespace InvestmentCalculator
{
    public class InvestmentDateCalculator
    {
        public DateTime GetBuyDate(DateTime referenceDate, StockHistory history, DateTime limitDate)
        {
            int lastDay = DateTime.DaysInMonth(referenceDate.Year, referenceDate.Month);
            DateTime lastDate = new DateTime(referenceDate.Year, referenceDate.Month, lastDay);
            DateTime buyDate = lastDate;

            while(buyDate.DayOfWeek != DayOfWeek.Thursday)
            {
                buyDate = buyDate.AddDays(-1);
            }

            buyDate = buyDate.AddDays(1);

            if (buyDate >= limitDate) {
                return limitDate;
            }

            while (buyDate < limitDate && !history.HasQuoteOnDate(buyDate))
            {
                buyDate = buyDate.AddDays(1);
            }
            return buyDate;
        }
    }
}