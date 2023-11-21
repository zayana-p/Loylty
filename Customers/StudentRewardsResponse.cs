using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentRewardsResponse : ResponseBase
    {
        public StudentRewardsResponse()
        {

        }
        public string? EnrollmentNo { get; set; }
    }
}
