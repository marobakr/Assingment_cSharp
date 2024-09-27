using Mvc.Demo.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace Mvc03.Demo.PL.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            /* Mail Server: gmail.com */
            /*Protocol : smtp [Simple Mail Transfer Protocol]*/
            /*Port : 587*/
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("marobakr03@gmail.com", "kmggkhqrqcbfghjt");
                client.Send("marobakr03@gmail.com", email.To, email.Subject, email.Body);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"SMTP Exception: {ex.Message}");
                throw;
            }

        }
    }
}
/*kmggkhqrqcbfghjt*/