using MoneyLoser2000.Models.Interfaces;
using MoneyLoser2000.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpaca.Markets;

namespace MoneyLoser2000.Services.Alpaca
{
    public class AlpacaTradeService : ITradeService
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
