using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class CustomerLoginRequest : RequestBase
    {
        public CustomerLoginRequest()
        {
        }
        public string Mobile { get; set; }
        public string Password { get; set; }
    }
    public class CustomerLoginRequestValidator : AbstractValidator<CustomerLoginRequest>
    {
        public CustomerLoginRequestValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password required").MinimumLength(6).WithMessage("Password should have minumum 6 charectors").MaximumLength(15).WithMessage("Password cannot be morethan 15 charectors");
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
        }
    }
}

