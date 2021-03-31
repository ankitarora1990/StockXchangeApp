using System;
using System.Runtime.Serialization;

namespace StockManagementService.Service.Model
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
