using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentValidationResponse : ResponseBase
    {
        public StudentValidationResponse()
        {

        }
        public List<StudentEnrollmentResponse> studentResponse { get; set; }
    }
}
