﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetMembersResponse : ResponseBase
    {
        public GetMembersResponse() { }
        public List<FamilyMember> familyMembers { get; set; }
    }
}
