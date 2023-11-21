using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGCLoyaltyApp.Core.Components.Abstracts;

namespace TGCLoyaltyApp.Core.Components
{
    public class SynaspseSMSComponent : ISMSComponent
    {
        public SynaspseSMSComponent()
        {

        }
        public async Task<TResponse> SendSms<TRequest, TResponse>(string url, TRequest message)
        {
            var cont = JsonConvert.SerializeObject(message);
            var stringContent = new StringContent(JsonConvert.SerializeObject(message), Encoding.UTF8, "application/json");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var httpClient = new HttpClient(clientHandler))
            {
                //var url = GetHost() + path;
                var response = await httpClient.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content != null ? await response.Content.ReadAsStringAsync() : null;

                    return JsonConvert.DeserializeObject<TResponse>(responseContent);
                }
                else
                {
                    var responseContent = response.Content != null ? await response.Content.ReadAsStringAsync() : null;
                    //var error = JsonConvert.DeserializeObject<ErrorDetails>(responseContent);
                    throw new Exception();
                }

            }
        }

    }

    public class SynapseSMSRequest
    {
        public string userName { get; set; }
        public int priority { get; set; }
        public string referenceId { get; set; }
        public object dlrUrl { get; set; }
        public int msgType { get; set; }
        public string senderId { get; set; }
        public string message { get; set; }
        public MobileNumbers mobileNumbers { get; set; }
        public string password { get; set; }
    }
    public class MessageParam
    {
        public string mobileNumber { get; set; }
    }

    public class MobileNumbers
    {
        public List<MessageParam> messageParams { get; set; }
    }
    public class SynapseSMSResponse
    {
        public string result { get; set; }
        public string referenceId { get; set; }
        public string msgId { get; set; }
        public string mobileNumber { get; set; }
        public string status { get; set; }
        public DateTime deliveryTime { get; set; }
    }
}
