using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdateCustomerResponse : ResponseBase
    {
        public UpdateCustomerResponse()
        {

        }
        public Customer? Customer { get; set; }
    }
}
