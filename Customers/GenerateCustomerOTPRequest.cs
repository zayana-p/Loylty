using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace TGCLoyaltyApp.Core.ViewModels
{
	public class GenerateCustomerOTPRequest : RequestBase
	{
		public GenerateCustomerOTPRequest()
		{
		}
		public string Mobile { get; set; }
        public string? Message { get; set; }
	}
    public class GenerateCustomerOTPRequestValidator : AbstractValidator<GenerateCustomerOTPRequest>
    {
        public GenerateCustomerOTPRequestValidator()
        {
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
        }
    }
}

