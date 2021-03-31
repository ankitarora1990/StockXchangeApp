using System;
using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public class Trade
    {

        [DataMember]
        public int TradeRequestId { get; set; }

        [DataMember]
        public double CommittedPrice { get; set; }

        [DataMember]
        public DateTime FulfilledTimeStamp { get; set; }
    }
}
