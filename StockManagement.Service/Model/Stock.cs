using System;
using System.Runtime.Serialization;

namespace StockManagementService.Service.Model
{
    [DataContract]
    public class Stock
    {
        [DataMember]
        public int StockId { get; set; }
        
        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double LatestPrice { get; set; }
    }
}
