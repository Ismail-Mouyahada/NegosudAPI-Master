using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace NegoSudAPI.Mail
{
    public class SendMail
    {

        public void SendIt(string toAddress, string subject, string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("client-service@negosud.fr");
            message.To.Add(new MailAddress(toAddress));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = body;
            smtp.Port = 2525;
            smtp.Host = "sandbox.smtp.mailtrap.io";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("6af039d0b778fd", "7d7de1147afa65");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

    }
}