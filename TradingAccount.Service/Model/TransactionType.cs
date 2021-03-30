using System.Runtime.Serialization;

namespace TradingAccount.Service.Model
{
    [DataContract]
    public enum TransactionType
    {
        [EnumMember]
        Credit = 1,

        [EnumMember]
        Debit = 2
    }
}
