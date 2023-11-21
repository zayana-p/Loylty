using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class PianoServiceTypeResponse : ResponseBase
    {
        public PianoServiceTypeResponse() { }
        public PianoServiceType? pianoResponse { get; set; }
    }
}
