namespace Solid_Principles.Services.Discount
{
    public class StudentDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal total)
        {
            return total * 0.90m;
        }
    }
}