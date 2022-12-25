using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLoser2000.Models.Interfaces
{
    public interface IPortfolio
    {
        public List<ICurrentPostition> Postitions { get; }
    }
}
