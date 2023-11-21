using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentRewardsExcelResponse : ResponseBase
    {
        public StudentRewardsExcelResponse()
        {

        }
        public List<StudentRewardsResponse> studentRewardResponse { get; set; }
    }
}
