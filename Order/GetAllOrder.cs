using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetAllOrder : ResponseBase
    {
        public GetAllOrder() { }
        public List<Order> Orders { get; set; }
    }
}
