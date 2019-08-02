using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MyTestingProject.Notificatin
{
    public class EmailAppService : IEmailAppService
    {
        private readonly IConfiguration _configuration;
        public EmailAppService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail()
        {
            var subject = "Testni mail";
            var message = "Ovo je poruka sa mog maila";
            var email = "dejan.jaredic@bild-studio.net";
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _configuration["Email:Email"],
                    Password = _configuration["Email:Password"]
                };
                
                client.Credentials = credential;
                client.Host = _configuration["Email:Host"];
                client.Port = int.Parse(_configuration["Email:Port"]);
                client.EnableSsl = true;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress(_configuration["Email:Email"]);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }


    }
}
