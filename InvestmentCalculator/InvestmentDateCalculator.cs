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
        public DateTime GetBuyDate(DateTime referenceDate)
        {

            int lastDay = DateTime.DaysInMonth(referenceDate.Year, referenceDate.Month);
            DateTime lastDate = new DateTime(referenceDate.Year, referenceDate.Month, lastDay);

            while(lastDate.DayOfWeek != DayOfWeek.Thursday)
            {
                lastDate = lastDate.AddDays(-1);
            }
            return lastDate.AddDays(1);
        }

    }
}