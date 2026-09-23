namespace Solid_Principles.Services
{
    public interface IInvoiceEmailer
    {
        void Send(string email, decimal total);
    }
}