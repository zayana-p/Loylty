using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class DeleteCustomerRequest :RequestBase
    {
        public DeleteCustomerRequest()
        {
        }
        public int? Id { get; set; }
        public bool IsActive { get; set; }

    }
}
