using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace TGCLoyaltyApp.Core.ViewModels
{
	public class Customer
	{
		public Customer()
		{
		}
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CardNo { get; set; }
        public string Password { get; set; }
        public string ReferalNo { get; set; } 
        public int ReferedBy { get; set; }
        public string ReferedByName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public char CustomerType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<FamilyMember> familyMember { get; set; }
        public string CardType { get; set; }
        public string? FileUrl { get; set; }
        public bool? IsValidated { get; set; }
    }
    public class CustomerValidator : AbstractValidator<Customer> {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required").MaximumLength(30).WithMessage("First Name cannot be morethan 30 charectors");
            RuleFor(x=>x.LastName).NotEmpty().WithMessage("Last Name required").MinimumLength(1).WithMessage("Last Name should have atleast 1 charector").MaximumLength(30).WithMessage("Last Name cannot be morethan 30 charectors");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password required").MinimumLength(6).WithMessage("Password should have minumum 6 charectors").MaximumLength(15).WithMessage("Password cannot be morethan 15 charectors");
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email address is not valid");
        }
    }
}

