using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdateMobileNoRequest : RequestBase
    {
        public UpdateMobileNoRequest() { }
        public string OldMobile { get; set; }
        public int OTP { get; set; }
        public string NewMobile { get; set; }
        public string Email { get; set; }
    }
    public class UpdateMobileNoRequestValidator : AbstractValidator<UpdateMobileNoRequest>
    {
        public UpdateMobileNoRequestValidator()
        {
            RuleFor(x => x.OldMobile).Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.OTP).NotEmpty().Must(x => x > 1000 && x < 9999).WithMessage("OTP should contain 4 digits");
            RuleFor(x => x.NewMobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email address is not valid or provided. Please try adding a valid email and try again").EmailAddress().WithMessage("Email address is not valid");
        }
    }
}
