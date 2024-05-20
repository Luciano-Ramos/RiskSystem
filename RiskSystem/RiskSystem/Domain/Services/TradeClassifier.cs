using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskSystem.Domain.Interfaces;

namespace RiskSystem.Domain.Services
{
    public class TradeClassifier
    {
        private List<ITradeCategory> categories = new List<ITradeCategory>();

        public TradeClassifier(params ITradeCategory[] categories)
        {
            this.categories.AddRange(categories);
        }

        public string ClassifyTrade(ITrade trade)
        {
            foreach (var category in categories)
            {
                if (category.IsInCategory(trade))
                {
                    return category.Name;
                }
            }
            return "UNCLASSIFIED";
        }
    }
}
