using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace TGCLoyaltyApp.Core.ViewModels
{
	public class ValidateCustomerOTPRequest : RequestBase

	{
		public ValidateCustomerOTPRequest()
		{
		}
		public string Mobile { get; set; }
		public int OTP { get; set; }

	}
    public class ValidateCustomerOTPRequestValidator : AbstractValidator<ValidateCustomerOTPRequest>
    {
        public ValidateCustomerOTPRequestValidator()
        {
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.OTP).NotEmpty().Must(x => x > 1000 && x < 9999).WithMessage("OTP should contain 4 digits");
        }
    }
}

