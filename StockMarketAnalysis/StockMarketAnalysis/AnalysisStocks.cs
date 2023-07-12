using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketAnalysis
{
    public class AnalysisStocks
    {
        private IGetStockPrices _getStockPrices;
        private List<StockPrice> _stockPrices;


        // Constructor
        public AnalysisStocks(IGetStockPrices getStockPrices)
        {
            _getStockPrices = getStockPrices;
            _stockPrices = _getStockPrices.GetStockPrices();
        }
    
        public List<StockPrice> Strategy_OpenLow_Intraday()
        {
            var result = _stockPrices.Where(x => x.Open == x.Low);
            return result.ToList();          
        }

        public List<StockPrice> Strategy_OpenHigh_Intraday()
        {
            var result = _stockPrices.Where(x => x.Open == x.High);
            return result.ToList();
        }


    }
}
