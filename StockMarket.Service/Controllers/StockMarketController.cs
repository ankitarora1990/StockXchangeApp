using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Service.Model;

namespace StockMarket.Service.Controllers
{
    [Route("api/stock-market")]
    [Authorize]
    [ApiController]
    public class StockMarketController : ControllerBase
    {
        // POST api/stock-market/buy
        [HttpPost("buy")]
        public void BuyStock([FromBody] TradeRequest tradeRequest)
        {
            
        }

        // POST api/stock-market/sell
        [HttpPost("sell")]
        public void SellStock([FromBody] TradeRequest tradeRequest)
        {

        }

        // GET api/stock-market/{customerEmail}/trade-history
        [HttpGet("{customerEmail}/trade-history")]
        public ActionResult<IList<TradeDetail>> Get(string customerEmail)
        {
            return new List<TradeDetail>
            {
                new TradeDetail
                {
                    StockCode = "AAPL",
                    Count = 5,
                    CommittedPrice = 121.50,
                    TradeType = TradeType.Buy,
                    FulfilledTimeStamp = DateTime.Now
                },
                new TradeDetail
                {
                    StockCode = "AAPL",
                    Count = 2,
                    CommittedPrice = 125.50,
                    TradeType = TradeType.Sell,
                    FulfilledTimeStamp = DateTime.Now
                }
            };
        }        
    }
}
