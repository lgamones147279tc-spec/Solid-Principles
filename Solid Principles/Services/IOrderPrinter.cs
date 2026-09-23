namespace Solid_Principles.Services
{
    public interface IOrderPrinter
    {
        void Print(string email, decimal total);
    }
}