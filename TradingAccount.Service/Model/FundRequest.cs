using System;
using System.Runtime.Serialization;

namespace TradingAccount.Service.Model
{
    [DataContract]
    public class FundRequest
    {
        [DataMember]
        public int CustomerId { get; set; }
        
        [DataMember]
        public Transaction Transaction { get; set; }
    }
}
