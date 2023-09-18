using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace LeaveManagment.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int port;
        private string fromEmailAddress;

        public EmailSender(string smtpServer, int port, string fromEmailAddress)
        {
            this.smtpServer = smtpServer;
            this.port = port;
            this.fromEmailAddress = fromEmailAddress;
        }  

        public  Task SendEmailAsync(string email, string subject, string htmlMessage) // vo delot za register e voa SendEmailAsync
        {

            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage, // html message e zaradi <a href /a>
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, port);
            client.Send(message);


            return Task.CompletedTask;








           


            //client.Send(message);

          //  return Task.CompletedTask;
            
            
        }
    }
}
