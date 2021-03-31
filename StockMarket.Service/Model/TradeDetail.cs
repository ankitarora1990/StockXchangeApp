using System;
using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public class TradeDetail
    {
        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public double CommittedPrice { get; set; }

        [DataMember]
        public TradeType TradeType { get; set; }

        [DataMember]
        public DateTime FulfilledTimeStamp { get; set; }

    }
}
