using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        // testing with papercut SMTP v6.2.0

        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body );
        }
        public static void SendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(ConfigurationManager.AppSettings["senderDisplayName"], ConfigurationManager.AppSettings["senderEmail"]));

            foreach (string email in to)
            {
                message.To.Add(new MailboxAddress("", email)); 
            }

            foreach (string email in bcc)
            {
                message.Bcc.Add(new MailboxAddress("", email));
            }

            message.Subject = subject;

            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = body;
            message.Body = builder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect(ConfigurationManager.AppSettings["smtpHost"], Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]), false);
                //client.Authenticate(ConfigurationManager.AppSettings["smtpUserName"], ConfigurationManager.AppSettings["smtpPassword"]);
                client.Send(message);
                client.Disconnect(true);
            }

        }
    }
}        
