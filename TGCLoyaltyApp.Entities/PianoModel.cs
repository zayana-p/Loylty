using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    
    [Table("pianomodels", Schema = "loyalty")]
    public class PianoModel : EntityBase
    {
        public PianoModel() : base()
        {
        }
        public string? Code { get; set; }
        public string Model { get; set; }
        public double ServiceAmount { get; set; }
        public virtual ICollection<PianoServiceCost> PianoServiceCosts { get; set; }
    }
}
