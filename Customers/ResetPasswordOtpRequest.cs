using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ResetPasswordOtpRequest : RequestBase
    {
        public ResetPasswordOtpRequest() { }
        public string Mobile { get; set; }
        public int PasswordOTP { get; set; }
    }
    public class ResetPasswordOtpRequestValidator : AbstractValidator<ResetPasswordOtpRequest>
    {
        public ResetPasswordOtpRequestValidator()
        {
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.PasswordOTP).NotEmpty().Must(x => x > 1000 && x < 9999).WithMessage("OTP should contain 4 digits");
        }
    }
}
