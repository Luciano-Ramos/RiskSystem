using RiskSystem.Domain.Interfaces;

namespace RiskSystem.Domain.Services
{
    public  class ExpiredCategory : ITradeCategory
    {
        private DateTime referenceDate;

        public ExpiredCategory(DateTime referenceDate)
        {
            this.referenceDate = referenceDate;
        }

        public string Name => "EXPIRED";

        public bool IsInCategory(ITrade trade)
        {
            return (trade.NextPaymentDate - referenceDate).Days < -30;
        }
    }
}
