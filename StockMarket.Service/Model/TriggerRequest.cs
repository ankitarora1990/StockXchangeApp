using System;
using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public class TriggerRequest
    {

        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public Trigger Trigger { get; set; }
    }
}
