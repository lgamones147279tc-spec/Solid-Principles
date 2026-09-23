using System.Windows.Forms;

namespace Solid_Principles.Services
{
    public class OrderPrinter : IOrderPrinter
    {
        public void Print(string email, decimal total)
        {
            MessageBox.Show(
                $"Invoice for {email}: {total:C}");
        }
    }
}