using System;
using System.Windows.Forms;
using Solid_Principles.Repositories;
using Solid_Principles.Services;

namespace Solid_Principles
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString =
                "Server=localhost;" +
                "Database=Orders;" +
                "Trusted_Connection=True;";

            IOrderRepository repository =
                new SqlOrderRepository(connectionString);

            IInvoiceEmailer emailer =
                new InvoiceEmailer();

            IOrderPrinter printer =
                new OrderPrinter();

            OrderCalculator calculator =
                new OrderCalculator();

            Application.Run(
                new Form1(
                    repository,
                    emailer,
                    printer,
                    calculator));
        }
    }
}