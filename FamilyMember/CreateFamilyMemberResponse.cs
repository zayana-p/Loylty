using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class CreateFamilyMemberResponse : ResponseBase
    {
        public CreateFamilyMemberResponse() { }
        public FamilyMember? FamilyMember { get; set; }
    }
}
