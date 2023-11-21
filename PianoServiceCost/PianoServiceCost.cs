using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class PianoServiceCost
    {
        public PianoServiceCost() { }
        public int Id { get; set; }
        public int PianoModelId { get; set; }
        public int EmiratesId { get; set; }
        public string EmiratesName { get; set; }
        public double MinServiceAmount { get; set; }
        public double MaxServiceAmount { get; set; }
    }
}
