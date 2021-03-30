using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradingAccount.Service.Model;

namespace StockManagementService.Controllers
{
    [Route("api/stock-prices")]
    [ApiController]
    public class StockPriceController : ControllerBase
    {
        // GET api/stock-prices
        [HttpGet]
        public ActionResult<IList<Stock>> GetAllStockPricess()
        {
            return new List<Stock>
            {
                new Stock {
                    StockCode = "AAPL",
                    LatestPrice = 115.69
                },
                new Stock
                {
                    StockCode = "MSFT",
                    LatestPrice = 109.50
                },
                new Stock
                {
                    StockCode = "TSLA",
                    LatestPrice = 850
                }
            };
        }

        // GET api/stock-prices/AAPL
        [HttpGet("{stockCode}")]
        public ActionResult<Stock> Get(string stockCode)
        {
            return new Stock
            {
                StockCode = "AAPL",
                LatestPrice = 115.69
            };
        }

        // GET api/stock-prices/AAPL/history
        [HttpGet("{stockCode}/history")]
        public ActionResult<StockPriceHistory> GetStockPriceHistory(string stockCode)
        {
            return new StockPriceHistory
            {
                StockCode = "AAPL",
                PriceHistory = new Dictionary<DateTime, double>()
                {
                    { DateTime.UtcNow, 116 }
                }
            };
        }
    }
}