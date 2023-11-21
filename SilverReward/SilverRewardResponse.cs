using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class SilverRewardResponse
    {
        public decimal? SilverAvailablePts { get; set; }
        public decimal? SilverConsumedPts { get; set; }
        public decimal? SilverExpiringPts { get; set; }
        public decimal? SilverPendingPts { get; set; }
        public DateTime? SilverExpiringDate { get; set; }
    }
}
