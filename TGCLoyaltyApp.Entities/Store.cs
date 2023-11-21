using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("stores", Schema = "loyalty")]
    public class Store : EntityBase
    {
        public Store()
        {
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StoreLocation> Locations { get; set; }
        public virtual ICollection<StorePromotion> StorePromotions { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
