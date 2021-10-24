using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wither
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }

        //MailKit.Net.Smtp.SmtpClient
        public void SendEmailCustom()
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Varmilo Kboard", "joker320kingkobra25rus@gmail.com")); //отправитель сообщения
                message.To.Add(new MailboxAddress("xorekvblendere@mail.ru")); //адресат сообщения
                message.Subject = "Varmilo"; //тема сообщения
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: red;\">Сообщение от сайта)))</div>" }.ToMessageBody();

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true); //либо использум порт 465     //587
                    client.Authenticate("joker320kingkobra25rus@gmail.com", "iqsvcrjpljgemuco"); //логин-пароль от аккаунта
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

