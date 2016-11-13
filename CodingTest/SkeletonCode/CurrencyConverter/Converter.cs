using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            decimal convertedAmount = 0;

            List<CurrencyRate> currencyRateTable = new List<CurrencyRate>
            {
                new CurrencyRate("GBP", "USD", 1.25m),
                new CurrencyRate("USD", "GBP", 0.8m)
            };

            CurrencyRate currency = currencyRateTable.Find(x => (string.Compare(x.InputCurrency, inputCurrency) == 0 
                                                            && string.Compare(x.OutputCurrency, outputCurrency) == 0));

            if (currency != null)
            {
                convertedAmount = amount * currency.ConversionRate;
            }
            else
            {
                throw new System.InvalidOperationException("Invalid input currency supplied");
            }
                       
			return convertedAmount;
		}

        private class CurrencyRate
        {
            public string InputCurrency { get; set; }
            public string OutputCurrency {get; set;}
            public decimal ConversionRate { get; set; }

            CurrencyRate() {}

            public CurrencyRate(string inputCurrency, string outputCurrency, decimal conversionRate)
            {
                InputCurrency = inputCurrency;
                OutputCurrency = outputCurrency;
                ConversionRate = conversionRate;
            }
        }
	}
}
