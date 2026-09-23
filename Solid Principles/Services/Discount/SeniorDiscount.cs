namespace Solid_Principles.Services.Discount
{
    public class SeniorDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total)
        {
            return total * 0.85m;
        }
    }
}