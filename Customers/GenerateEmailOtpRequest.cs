using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GenerateEmailOtpRequest
    {
        public GenerateEmailOtpRequest() { }
        public int CustomerId { get; set; }
    }
}
