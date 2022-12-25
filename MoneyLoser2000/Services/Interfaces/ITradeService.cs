using MoneyLoser2000.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLoser2000.Services.Interfaces
{
    public interface ITradeService
    {
        public bool PlaceLongStockTrade(IStockTrade trade);
        public bool PlaceShortStockTrade(IStockTrade trade);

    }
}
