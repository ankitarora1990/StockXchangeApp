using System;
using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public class Trigger
    {

        [DataMember]
        public int? TriggerId { get; set; }

        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public double RequestedPrice { get; set; }

        [DataMember]
        public TradeType TradeType { get; set; }

        [DataMember]
        public DateTime RequestedTimeStamp { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

    }
}
