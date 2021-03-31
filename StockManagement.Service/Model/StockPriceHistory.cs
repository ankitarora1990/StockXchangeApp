using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StockManagementService.Service.Model
{
    [DataContract]
    public class StockPriceHistory
    {
        [DataMember]
        public string StockCode { get; set; }

        [DataMember]
        public IDictionary<DateTime, double> PriceHistory { get; set; }

    }
}