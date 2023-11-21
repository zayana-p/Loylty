using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class StudentEnrollmentExcelRequest
    {
        public StudentEnrollmentExcelRequest()
        {

        }
        public List<StudentEnrollmentRequest> studentEnrollment { get; set; }
    }
}
