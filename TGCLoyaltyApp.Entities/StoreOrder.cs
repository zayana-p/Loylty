using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("storeorders", Schema = "loyalty")]
    public class StoreOrder : EntityBase
    {
        public StoreOrder() : base()
        {
        }
        //public string StoreLocationCode { get; set; }
        public string OutletStoreCode { get; set; }

        public string InvoiceNo { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal ItemPrice { get; set; }
        public int CustomerId { get; set; }
        public int OutletStoreId { get; set; }
        public string ItemName { get; set; }
        public string? SerialNo { get; set; }
        public string? ItemDescription { get; set; }
        public string? InvoiceUrl { get; set; }
        public DateTime? WarrantyExpiry { get; set; }
        public string? ImageHeight { get; set; }
        public string? ImageWidth { get; set; }
        public string? Status { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("OutletStoreId")]
        public virtual OutletStore OutletStore { get; set; }
        public virtual ICollection<SilverReward> SilverRewards { get; set; }
    }
}
