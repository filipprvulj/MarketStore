using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class SilverCard : DiscountCard
    {
        public SilverCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {
        }

        public override float DiscountRate { get; set; } = 2.0f;

        public override float CalculateDiscountRate()
        {
            if (Turnover > 300)
            {
                DiscountRate = 3.5f;
            }

            return DiscountRate;
        }
    }
}