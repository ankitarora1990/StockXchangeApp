using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockManagementService.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StockManagementController : ControllerBase
    {
        // GET api/stocks
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "AAPL", "MSFT", "TSLA" };
        }

        // GET api/stocks/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "AAPL";
        }

        // POST api/stocks
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/stocks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/stocks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}