using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GenerateEmailOTPResponse : ResponseBase
    {
        public GenerateEmailOTPResponse() { }
        public bool IsSend { get; set; }
    }
}
