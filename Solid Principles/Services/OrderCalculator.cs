using System.Collections.Generic;
using System.Linq;
using Solid_Principles.Services.Discount;

namespace Solid_Principles.Services
{
    public class OrderCalculator
    {
        public decimal Calculate(
            IEnumerable<(decimal Price, int Quantity)> items,
            IDiscountStrategy discountStrategy)
        {
            decimal total = items.Sum(
                item => item.Price * item.Quantity);

            return discountStrategy.Apply(total);
        }
    }
}