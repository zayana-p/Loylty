using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class SilverReward
    {
        public SilverReward() { }
        public decimal PointsAwarded { get; set; }
        public decimal? PointsConsumed { get; set; }
        public decimal? PointsExpired { get; set; }
        public DateTime TxnDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int CustomerId { get; set; }
        public int StoreLocationId { get; set; }
        public string RewardType { get; set; }
        public int StoreOrderId { get; set; }
        public string StoreOrderNo { get; set; }
        public DateOnly StoreOrderDate { get; set; }
        public string StoreLocationName { get; set; }
    }
}
