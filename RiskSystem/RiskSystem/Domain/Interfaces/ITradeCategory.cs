using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystem.Domain.Interfaces
{
    public interface ITradeCategory
    {
        string Name { get; }
        bool IsInCategory(ITrade trade);
    }
}
