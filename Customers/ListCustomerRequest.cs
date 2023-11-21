using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ListCustomerRequest : RequestBase
    {
        public ListCustomerRequest()
        {
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mobile { get; set; }
        public string? CardNo { get; set; }
        public string? CardType { get; set;}
    }
}
