using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.Components.Abstracts
{
    public interface IEmailService
    {
        bool SendMail(MailData mailData);
    }
}
