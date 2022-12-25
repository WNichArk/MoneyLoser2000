using MoneyLoser2000.Models.Enums;
using MoneyLoser2000.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLoser2000.Models.DefaultImplementation
{
    public class DefaultStockTrade : IStockTrade
    {
        public string Symbol { get; set; }
        public TradeSide TradeSide { get; set; }
        public OrderType OrderType { get; set; }
        public TimeInForce TimeInForce { get; set; }
        public Status Status { get; set; }
        public bool BrokerTakeProfitStopLoss { get; set; }
        public decimal LimitPrice { get; set; }
        public decimal? TakeProfitPrice { get; set; }
        public decimal? StopLossPrice { get; set; }
        public decimal? FulfilledPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
