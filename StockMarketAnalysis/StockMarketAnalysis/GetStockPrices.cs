using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketAnalysis
{

    public class GetStockPrices_Hardcoded : IGetStockPrices
    {
        public List<StockPrice> GetStockPrices()
        {
            List<StockPrice> stockPrices = new List<StockPrice>()
            {
                new StockPrice() {Epic="BARC.L", Open = 99, High = 99, Low = 94, Close =102, Volume = 1000 },
                new StockPrice() {Epic="LLOY.L", Open = 193, High = 230, Low = 193, Close =220, Volume = 2000 },
            };

            return stockPrices;
        }

    }

}
