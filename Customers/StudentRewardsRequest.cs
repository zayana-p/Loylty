using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentRewardsRequest
    {
        public StudentRewardsRequest()
        {

        }
        public string? EnrollmentNo { get; set; }
        public string? ReceiptNo { get; set; }
        public decimal NetAmount { get; set; }
    }
}
