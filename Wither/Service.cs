using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wither.Controllers;

namespace Wither
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }


        public void SendEmailCustom()
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Varmilo Kboard", "joker320kingkobra25rus@gmail.com")); 
                message.To.Add(new MailboxAddress("xorekvblendere@mail.ru"));
                message.Subject = "Varmilo"; //тема сообщения
                //message.Body = new BodyBuilder() {  }.ToMessageBody();
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: red;\">Сообщение от сайта)))</div>" }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true); //587
                    client.Authenticate("joker320kingkobra25rus@gmail.com", "iqsvcrjpljgemuco");
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }
    }

}

