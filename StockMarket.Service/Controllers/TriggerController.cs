using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Service.Model;

namespace StockMarket.Service.Controllers
{
    [Route("api/triggers")]
    [ApiController]
    public class TriggerController : ControllerBase
    {
        // GET api/triggers
        [HttpGet]
        public ActionResult<IList<Trigger>> GetAllTrigger()
        {
            return new List<Trigger>
            {
                new Trigger {
                    StockCode = "AAPL",
                    Count = 10,
                    RequestedPrice = 150,
                    TradeType = TradeType.Sell,
                    RequestedTimeStamp = DateTime.Now,
                    IsActive = true
                },
                new Trigger {
                    StockCode = "MSFT",
                    Count = 4,
                    RequestedPrice = 100,
                    TradeType = TradeType.Buy,
                    RequestedTimeStamp = DateTime.Now,
                    IsActive = true
                }
            };
        }

        // GET api/triggers/5
        [HttpGet("{triggerId}")]
        public ActionResult<Trigger> GetTriggerDetails(int triggerId)
        {
            return new Trigger
            {
                StockCode = "AAPL",
                Count = 1,
                RequestedPrice = 90,
                TradeType = TradeType.Buy,
                RequestedTimeStamp = DateTime.Now,
                IsActive = true
            };
        }

        // POST api/triggers
        [HttpPost]
        public void Post([FromBody] TriggerRequest triggerRequest)
        {
        }

        // PUT api/triggers
        [HttpPut]
        public void Put([FromBody] TriggerRequest triggerRequest)
        {
        }

        // DELETE api/triggers/5
        [HttpDelete("{triggerId}")]
        public void Delete(int triggerId)
        {
        }
    }
}
