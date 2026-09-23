namespace Solid_Principles.Services.Discount
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total)
        {
            return total;
        }
    }
}