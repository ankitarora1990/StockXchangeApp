using System;
using System.Runtime.Serialization;

namespace TradingAccount.Service.Model
{
    [DataContract]
    public class StockPriceEntry
    {        
        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }
    }
}
