namespace Solid_Principles.Services.Discount
{
    public class BlackFridayDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total)
        {
            return total * 0.70m;
        }
    }
}