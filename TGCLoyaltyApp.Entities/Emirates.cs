using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("emirates", Schema = "loyalty")]
    public class Emirates : EntityBase
    {
        public Emirates()
        {
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PianoServiceCost> PianoServiceCosts { get; set; }
    }
}
