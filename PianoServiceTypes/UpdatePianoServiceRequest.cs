using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdatePianoServiceRequest
    {
        public UpdatePianoServiceRequest() { }
        public int Id { get; set; }
        public string? Code { get; set; }
        public string Model { get; set; }
        public IEnumerable<PianoServiceCost> PianoServiceCost { get; set; }
    }
}
