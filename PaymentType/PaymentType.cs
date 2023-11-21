using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public  class PaymentType: ResponseBase
    {
        public PaymentType() { }
        public int Id { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
    }
}
