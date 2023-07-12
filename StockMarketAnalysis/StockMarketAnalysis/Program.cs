using System;
using System.Collections.Generic;

namespace StockMarketAnalysis
{
    public class Program
    {
        static void Main(string[] args)
        {

            GetStockPrices_Hardcoded sp = new GetStockPrices_Hardcoded();
            AnalysisStocks analysis = new AnalysisStocks(sp);

            List<StockPrice> stocks_strategyOpenLow = analysis.Strategy_OpenLow_Intraday();
            List<StockPrice> stocks_strategyOpenHigh = analysis.Strategy_OpenHigh_Intraday();

            Console.ReadLine();

        }
    }
}
