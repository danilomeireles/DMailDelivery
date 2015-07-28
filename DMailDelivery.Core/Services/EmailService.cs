using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using DMailDelivery.Core.Entity;

namespace DMailDelivery.Core.Services
{
    public class EmailService
    {
        public Sender Sender { get; set; }
        public Email Email { get; set; }        
                
        public EmailService(Sender sender, Email email)
        {
            this.Sender = sender;
            this.Email = email;
        }
                
        public void Send()
        {
            MailMessage mail = new MailMessage(Sender.EmailAddress, Email.Recipients);
            mail.IsBodyHtml = true;
            mail.Subject = Email.Subject;
            mail.Body = Email.Message;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = Sender.SmtpServer;
            smtpClient.Port = Sender.Port;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(Sender.EmailAddress, Sender.Password);
            ServicePointManager.ServerCertificateValidationCallback = 
                delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
                { return true; };

            smtpClient.Send(mail);
        }
    }
}