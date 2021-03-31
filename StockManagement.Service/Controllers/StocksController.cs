using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockManagementService.Service.Model;

namespace StockManagementService.Controllers
{
    [Route("api/stocks")]
    [Authorize]
    [ApiController]
    public class StocksController : ControllerBase
    {
        // GET api/stocks
        [HttpGet]
        public ActionResult<IList<Stock>> GetAllStocks()
        {
            return new List<Stock>
            {
                new Stock {
                    StockId = 1,
                    StockCode = "AAPL",
                    Description = "Apple INC."
                },
                new Stock
                {
                    StockId = 2,
                    StockCode = "MSFT",
                    Description = "Microsoft INC."
                },
                new Stock
                {
                    StockId = 3,
                    StockCode = "TSLA",
                    Description = "Tesla INC."
                }
            };
        }

        // GET api/stocks/5
        [HttpGet("{stockCode}")]
        public ActionResult<Stock> GetStockDetail(string stockCode)
        {
            return new Stock
            {
                StockId = 1,
                StockCode = "AAPL",
                Description = "Apple INC."
            };
        }

        // POST api/stocks
        [HttpPost]
        public void Post([FromBody] StockPriceEntry stockPrice)
        {
        }

        // DELETE api/stocks/5
        [HttpDelete("{stockCode}")]
        public void Delete(string stockCode)
        {
        }
    }
}