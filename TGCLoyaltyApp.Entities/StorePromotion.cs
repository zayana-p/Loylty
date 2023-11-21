using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("storepromotions", Schema = "loyalty")]
    public class StorePromotion : EntityBase
    {
        public StorePromotion() : base()
        {
        }
        public string ThumbnailImage { get; set; }
        public string BannerImage { get; set; }
        public DateOnly OfferValidDate { get; set; }
        public string Description { get; set; }
        public int StoreId { get; set; }
        public int? StoreLocationId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
        [ForeignKey("StoreLocationId")]
        public virtual StoreLocation? StoreLocation { get; set; }
        public bool IsAvailableInAllLocations { get; set; }
        public bool IsValid { get; set; }
    }
}
