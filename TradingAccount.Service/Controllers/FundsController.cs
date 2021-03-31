using Microsoft.AspNetCore.Mvc;
using TradingAccount.Service.Model;

namespace TradingAccount.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {

        // POST api/funds/add
        [HttpPost("add")]
        public void AddFunds([FromBody] FundRequest fundRequest)
        {
        }

        // POST api/funds/withdraw
        [HttpPost("withdraw")]
        public void WithdrawFunds([FromBody] FundRequest fundRequest)
        {
        }

        // GET api/funds/view-transactons
        [HttpGet("view-transactions")]
        public ActionResult<CustomerLedger> ViewTransactions()
        {
            return new CustomerLedger()
            {
                CustomerEmail = "testaccount@outlook.com",
                AccountBalance = 70,
                Transactions = null
            };
            //return new string[] { "Add $100", "Add $30", "Withdraw $60", "Balance $70" };
        }
    }
}
