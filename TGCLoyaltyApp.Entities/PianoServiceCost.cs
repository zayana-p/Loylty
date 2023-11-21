using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("pianoservicecosts", Schema = "loyalty")]
    public class PianoServiceCost : EntityBase
    {
        public PianoServiceCost()
        {
        }
        public int PianoModelId { get; set; }
        public int EmiratesId { get; set; }
        public double MinServiceAmount { get; set; }
        public double MaxServiceAmount { get; set; }
        [ForeignKey("PianoModelId")]
        public virtual PianoModel PianoModel { get; set; }
        [ForeignKey("EmiratesId")]
        public virtual Emirates Emirates { get; set; }
    }
}
