# StocksAnalysisGetSharePricesIsLooselyCoupled

I have demonstrated how to loosely couple code of getting share prices.

AnalysisStocks class is passed the implementation of getting share prices.
Please note the  AnalysisStocks class and GetStockPrices classes are not tightly coupled,
they are both independent of each other. Later we could pass an implementation of getting
share prices via the web instead of the hardcoded share prices. 
