﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketAnalysis
{
    public interface IGetStockPrices
    {
        List<StockPrice> GetStockPrices();
    }
}