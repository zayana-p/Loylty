using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ListCustomerResponse : ResponseBase
    {
        public ListCustomerResponse()
        {
        }
        public List<Customer>? customers { get; set; }
        public int UserCount { get; set; }
    }
}
