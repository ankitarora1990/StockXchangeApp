using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TradingAccount.Service.Model
{
    [DataContract]
    public class CustomerLedger
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public double AccountBalance { get; set; }

        [DataMember]
        public IList<Transaction> Transactions { get; set;}

}
}