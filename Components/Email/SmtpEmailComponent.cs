
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TGCLoyaltyApp.Core.Components.Abstracts;
using System.Net;
using System.Net.Http;

namespace TGCLoyaltyApp.Core.Components
{
    public class SmtpEmailComponent : IEmailService
    {
        private readonly MailSettings _mailSettings;
        public SmtpEmailComponent(IOptions<MailSettings> mailSettingsOptions)
        {
            _mailSettings = mailSettingsOptions.Value;
        }

        public bool SendMail(MailData mailData)
        {
            try
            {
                    //MailboxAddress emailFrom = new MailboxAddress(_mailSettings.SenderName, _mailSettings.SenderEmail);
                    //MailboxAddress emailTo = new MailboxAddress(mailData.EmailToName, mailData.EmailToId);
                        MailMessage mailMessage = new MailMessage(_mailSettings.SenderEmail, mailData.EmailToId);
                        mailMessage.Subject = mailData.EmailSubject;
                        mailMessage.Body = mailData.EmailBody;
                        mailMessage.IsBodyHtml = true;
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Host = _mailSettings.Host;
                        smtpClient.Port = _mailSettings.Port;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(_mailSettings.SenderEmail, _mailSettings.Password);
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);
                    
                

                return true;
            }
            catch (Exception ex)
            {
                // Exception Details
                return false;
            }
        }
    }
    //public class Message
    //{
    //    public List<MailboxAddress> To { get; set; }
    //    public string Subject { get; set; }
    //    public string Content { get; set; }
    //    public Message(IEnumerable<string> to, string subject, string content)
    //    {
    //        To = new List<MailboxAddress>();
    //        Subject = subject;
    //        Content = content;
    //    }
    //}
    public class MailSettings
    {
        public string Host { get; set; }
        public string Key { get; set; }
        public int Port { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class MailData
    {
        public string EmailToId { get; set; }
        public string EmailToName { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
    }
}
