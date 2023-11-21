using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ListServiceTypeResponse : ResponseBase
    {
        public ListServiceTypeResponse() { }
        public List<ServiceType> serviceType { get; set; }
    }
}
