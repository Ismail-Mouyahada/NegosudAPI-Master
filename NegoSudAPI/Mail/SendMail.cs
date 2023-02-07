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

        public void SendIt(string EnvoyerPar, string Sujet, string htmlFilePath,string receptionneur)
        {
            string Corps = File.ReadAllText(htmlFilePath);

            Corps = Corps.Replace("{receptionneur}", receptionneur);
            Corps = Corps.Replace("{date}", DateTime.Now.ToString("MM/dd/yyyy"));

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("client-service@negosud.fr");
            message.To.Add(new MailAddress(EnvoyerPar));
            message.Subject = Sujet;
            message.IsBodyHtml = true;
            message.Body = Corps;
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