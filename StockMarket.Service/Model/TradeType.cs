using System.Runtime.Serialization;

namespace StockMarket.Service.Model
{
    [DataContract]
    public enum TradeType
    {
        [EnumMember]
        Buy = 1,

        [EnumMember]
        Sell = 2
    }
}
