using System;
using System.IO;
using System.Globalization;

namespace InvestmentCalculator
{
	public class CsvReader
	{
		public StockHistory Read()
        {
			StockHistory history = new StockHistory();
            using (var reader = new StreamReader(@"C:\Users\usuario\source\repos\InvestmentCalculator\StockData\stocks-ITX.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    var quote = new Quote(Double.Parse(values[2]), Double.Parse(values[1]));
                    var date = DateTime.ParseExact(values[0], "dd-MMM-yyyy", new CultureInfo("es-US"));
                    history.Add(date, quote);
                }
            }
            return history;
        }
	}
}