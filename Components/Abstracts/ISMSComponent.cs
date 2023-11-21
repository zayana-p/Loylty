using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.Components.Abstracts
{
    public interface ISMSComponent
    {
        Task<TResponse> SendSms<TRequest, TResponse>(string url, TRequest message);
    }
}
