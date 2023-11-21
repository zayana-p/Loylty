using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels.Customers
{
    public class GetStudentResponse : ResponseBase
    {
        public GetStudentResponse() : base()
        {
        }
        public decimal? GoldPoints { get; set; }
        public decimal? SilverPoints { get; set; }
        public string StudentName { get; set; }
        public string CardNumber { get; set; }

    }
}
