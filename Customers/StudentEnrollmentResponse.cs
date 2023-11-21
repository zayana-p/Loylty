using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentEnrollmentResponse : ResponseBase
    {
        public StudentEnrollmentResponse()
        {

        }
        public string? EnrollmentNo { get; set; }
    }
}
