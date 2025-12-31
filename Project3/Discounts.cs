using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public abstract class Discount
    {
        public string Name { get; set; }

        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }

   
    public class PercentageDiscount : Discount
    {
        public decimal Percentage { get;  set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = $"{Percentage}% Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (price <= 0 || quantity <= 0)
                return 0;

            return price * quantity * (Percentage / 100);
        }
    }

    public class FlatDiscount : Discount
    {
        public decimal FlatAmount { get;  set; }

        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
            Name = $"${FlatAmount} Flat Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity <= 0)
                return 0;

            return FlatAmount * Math.Min(quantity, 1);
        }
    }

    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50% Off";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (price <= 0 || quantity <= 1)
                return 0;

            int eligibleItems = quantity / 2;
            return (price / 2) * eligibleItems;
        }
    }

    public class NoDiscount : Discount
    {
        public NoDiscount()
        {
            Name = "No Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
