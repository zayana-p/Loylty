using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("orders", Schema = "loyalty")]
    public class Order : EntityBase
    {
        public Order() : base()
        { 
        }
        public string StoreLocationCode { get; set; }
        public string OrderNo { get; set;}
        public DateTime OrderDate { get; set; }
        public string CustomerMobile { get; set; }
        public decimal NetAmount { get; set; }
        public int? CustomerId { get; set; }
        public int StoreLocationId { get; set; }
        public decimal? RedeemedPoints { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionTitle { get; set; }
        public decimal? SilverRedeemedPoints { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("StoreLocationId")]
        public virtual StoreLocation StoreLocation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        //public virtual ICollection<SilverReward> SilverRewards { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }



    }
}
