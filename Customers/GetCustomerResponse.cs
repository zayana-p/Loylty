using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetCustomerResponse : ResponseBase
    {
        public GetCustomerResponse() : base()
        {
        }
        public Customer? Customer { get; set; }
    }
}
