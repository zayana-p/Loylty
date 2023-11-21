using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("reward", Schema = "loyalty")]
    public class Reward : EntityBase
    {
        public Reward() : base()
        {
        }
       
        public decimal PointsAwarded { get; set; }
        public decimal? PointsConsumed { get; set; }
        public decimal? PointsExpired { get; set; }
        public DateTime TxnDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int CustomerId { get; set; }
        public int StoreLocationId { get; set; }
        public string RewardType { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("StoreLocationId")]
        public virtual StoreLocation StoreLocation { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }


    }
}
