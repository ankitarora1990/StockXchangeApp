using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TradingAccount.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {

        // POST api/funds/add
        [HttpPost("add")]
        public void AddFunds([FromBody] string value)
        {
        }

        // POST api/funds/withdraw
        [HttpPost("withdraw")]
        public void WithdrawFunds([FromBody] string value)
        {
        }

        // GET api/funds/view-transactons
        [HttpGet("view-transactions")]
        public ActionResult<IEnumerable<string>> ViewTransactions()
        {
            return new string[] { "Add $100", "Add $30", "Withdraw $60", "Balance $70" };
        }
    }
}
