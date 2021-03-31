using System;
using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public class TradeRequest
    {
        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public double SuggestedPrice { get; set; }

        [DataMember]
        public TradeType TradeType { get; set; }
    }
}
