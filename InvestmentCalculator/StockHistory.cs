using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    public class StockHistory
    {
        private Dictionary<DateTime, Quote> history;

        public StockHistory()
        {
             this.history = new Dictionary<DateTime, Quote>();
        }

        public void Add(DateTime date, Quote quote)
        {
            this.history.Add(date, quote);
        }

        public Quote Get(DateTime date)
        {
            return this.history[date];
        }

        public bool HasQuoteOnDate(DateTime date)
        {
            return history.ContainsKey(date);
        }
    }
}
