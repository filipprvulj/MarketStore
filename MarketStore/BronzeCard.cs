using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class BronzeCard : DiscountCard
    {
        public BronzeCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {
        }

        public override float DiscountRate { get; set; } = 0.0f;

        public override float CalculateDiscountRate()
        {
            if (Turnover >= 100 && Turnover <= 300)
            {
                DiscountRate = 1.0f;
            }
            else if (Turnover > 300)
            {
                DiscountRate = 2.5f;
            }

            return DiscountRate;
        }
    }
}