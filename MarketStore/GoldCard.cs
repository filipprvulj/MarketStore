using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class GoldCard : DiscountCard
    {
        public GoldCard(float turnover, float purchaseValue) : base(turnover, purchaseValue)
        {
        }

        public override float DiscountRate { get; set; } = 2.0f;

        public override float CalculateDiscountRate()
        {
            if (Turnover >= 100)
            {
                DiscountRate += Turnover / 100;

                if (DiscountRate > 10.0f)
                {
                    DiscountRate = 10.0f;
                }
            }

            return DiscountRate;
        }
    }
}