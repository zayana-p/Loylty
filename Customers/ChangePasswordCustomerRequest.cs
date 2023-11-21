using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ChangePasswordCustomerRequest : RequestBase
    {
        public ChangePasswordCustomerRequest() { }
        public string Mobile { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }

    }
    public class ChangePasswordCustomerRequestValidator : AbstractValidator<ChangePasswordCustomerRequest>
    {
        public ChangePasswordCustomerRequestValidator()
        {
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Password required").MinimumLength(6).WithMessage("Password should have minumum 6 charectors").MaximumLength(15).WithMessage("Password cannot be morethan 15 charectors");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Password required").MinimumLength(6).WithMessage("Password should have minumum 6 charectors").MaximumLength(15).WithMessage("Password cannot be morethan 15 charectors");
        }
    }
}

