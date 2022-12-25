using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLoser2000.Models
{
    public interface ICurrentPostition
    {
        public string Symbol { get; set; }
        public decimal CostBasis { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Quantity { get; set; }

    }
}
