using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class PushNotification
    {
        public PushNotification() { }
        public int CustomerId { get; set; }
        public string DeviceType { get; set; }
        public string Token { get; set; }
    }
}
