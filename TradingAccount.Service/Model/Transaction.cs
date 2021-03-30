using System;
using System.Runtime.Serialization;

namespace TradingAccount.Service.Model
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public TransactionType TransactionType { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        public string Notes { get; set; }
    }
}
