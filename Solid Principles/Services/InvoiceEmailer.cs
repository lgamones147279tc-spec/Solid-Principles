using System.Net;
using System.Net.Mail;

namespace Solid_Principles.Services
{
    public class InvoiceEmailer : IInvoiceEmailer
    {
        public void Send(string email, decimal total)
        {
            using (SmtpClient smtp =
                   new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;

                smtp.Credentials =
                    new NetworkCredential(
                        "your-email@gmail.com",
                        "your-app-password");

                using (MailMessage mail =
                       new MailMessage(
                           "your-email@gmail.com",
                           email))
                {
                    mail.Subject = "Invoice";
                    mail.Body =
                        $"Your total is {total:C}";

                    smtp.Send(mail);
                }
            }
        }
    }
}