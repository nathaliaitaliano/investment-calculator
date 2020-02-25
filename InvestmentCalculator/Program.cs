using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime referenceDate = new DateTime(2001, 5, 23);
            DateTime sellingDate = new DateTime(2017, 12, 28);
            int amount = 50;
            StockHistory history = new CsvReader().Read();
            Broker broker = new Broker(2);
            Wallet wallet = new Wallet();
            Investment investment = new Investment(history, broker);
            double stocksQuantity = investment.Open(referenceDate, sellingDate, amount);
            wallet.AddStocks(stocksQuantity);
            double totalPrice = investment.Close(wallet, sellingDate);

            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}