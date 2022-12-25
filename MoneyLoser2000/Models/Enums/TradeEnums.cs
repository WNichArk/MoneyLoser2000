using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLoser2000.Models.Enums
{
    public enum TradeSide
    {
        BuyToOpen = 0,
        SellToOpen = 1
    }

    public enum OrderType
    {
        MarketOrder = 0,
        LimitOrder = 1
    }

    public enum TimeInForce
    {
        Day = 0,
        GoodTilCancelled = 1
    }

    public enum Status
    {
        Queued = 0,
        Place = 1,
        Fulfilled = 2,
        Cancelled = 3
    }
}
