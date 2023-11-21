using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class CreateOrderResponse : ResponseBase
    {
        public CreateOrderResponse() { }
        public Order? orderResponse { get; set; }
        public int pointsEarned { get; set; }
        public int pointsConsumed { get; set; }

    }
}
