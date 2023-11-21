using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGCLoyaltyApp.Entities;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class CreateAddressResponse : ResponseBase
    {
        public CreateAddressResponse() { }
        public Address? Address { get; set; }
    }
}
