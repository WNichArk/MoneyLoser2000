using MoneyLoser2000.Models.InteractiveBrokers;
using MoneyLoser2000.Models.Interfaces;
using MoneyLoser2000.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSharp.InteractiveBrokers;

namespace MoneyLoser2000.Services
{
    public class InteractiveBrokersTradeService : ITradeService
    {
        public bool PlaceLongStockTrade(IStockTrade trade)
        {
            throw new NotImplementedException();
        }

        public bool PlaceShortStockTrade(IStockTrade trade)
        {
            throw new NotImplementedException();
        }
    }
}
