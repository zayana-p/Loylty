using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class EmailOtpRequest
    {
        public EmailOtpRequest() { }
        public string Email { get; set; }
        public int EmailOTP { get; set; }
    }
    public class EmailOtpRequestValidator : AbstractValidator<EmailOtpRequest>
    {
        public EmailOtpRequestValidator()
        {
            RuleFor(x => x.EmailOTP).NotEmpty().WithMessage("Otp is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email address is not valid or provided. Please try adding a valid email and try again").EmailAddress().WithMessage("Email address is not valid");
        }
    }
}

