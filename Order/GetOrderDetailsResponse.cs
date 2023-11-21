using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetOrderDetailsResponse : ResponseBase
    {
        public GetOrderDetailsResponse() { }
        public Order order { get; set; }
    }
}
