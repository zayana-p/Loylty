using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("storelocations", Schema = "loyalty")]
    public class StoreLocation : EntityBase
    {
        public StoreLocation() 
        {
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool? IsDirect { get; set; }
        public int StoreId { get; set; }
        [MaxLength(15)]
        public string Mobile { get; set; }
        public string StoreType { get; set; }
        public string? StoreImage { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<StorePromotion> StorePromotions { get; set; }
        public virtual ICollection<SilverReward> SilverRewards { get; set; }
        public virtual ICollection<ProductTypeLocation> ProductTypeLocation { get; set; }


    }
}
