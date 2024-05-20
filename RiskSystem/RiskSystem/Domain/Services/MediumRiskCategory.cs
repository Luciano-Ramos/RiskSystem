using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskSystem.Domain.Interfaces;

namespace RiskSystem.Domain.Services
{
    public class MediumRiskCategory : ITradeCategory
    {
        public string Name => "MEDIUMRISK";

        public bool IsInCategory(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Public";
        }
    }
}
