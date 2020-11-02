using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal abstract class DiscountCard
    {
        private string owner;

        public float Turnover { get; }

        public float PurchaseValue { get; }

        public abstract float DiscountRate { get; set; }

        public DiscountCard(float turnover, float purchaseValue)
        {
            Turnover = (turnover >= 0) ? turnover : throw new ArgumentException("Turnover can't have negative value");
            PurchaseValue = (purchaseValue >= 0) ? purchaseValue : throw new ArgumentException("Purchase value can't be negative");
        }

        private float CalculateDiscount()
        {
            return (DiscountRate / 100) * PurchaseValue;
        }

        private float CalculateTotal()
        {
            return PurchaseValue - CalculateDiscount();
        }

        public void PrintOutput()
        {
            Console.WriteLine($"  a. Mock data: turnover ${Turnover}, purchase value ${PurchaseValue}");
            Console.WriteLine($"  b. Output:");
            Console.WriteLine();
            Console.WriteLine($"  \u25e6 Purchase value: ${PurchaseValue:f2}");
            Console.WriteLine();
            Console.WriteLine($"  \u25e6 Discount rate: {CalculateDiscountRate():f1}%");
            Console.WriteLine();
            Console.WriteLine($"  \u25e6 Discount: ${CalculateDiscount():f2}");
            Console.WriteLine();
            Console.WriteLine($"  \u25e6 Total: ${CalculateTotal():f2}");
            Console.WriteLine("============================================");
            Console.WriteLine();
        }

        public abstract float CalculateDiscountRate();
    }
}