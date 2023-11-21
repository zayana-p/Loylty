using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetPianoServiceTypes : ResponseBase
    {
        public GetPianoServiceTypes() { }
        public List<PianoServiceType> pianoServices { get; set; }
    }
}
