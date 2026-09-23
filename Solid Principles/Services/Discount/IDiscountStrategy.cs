namespace Solid_Principles.Services.Discount
{
    public interface IDiscountStrategy
    {
        decimal Apply(decimal total);
    }
}