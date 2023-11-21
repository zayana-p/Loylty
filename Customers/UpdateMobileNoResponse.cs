using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdateMobileNoResponse : ResponseBase
    {
        public UpdateMobileNoResponse()
        {

        }
        public Customer? Customer { get; set; }
    }
}
