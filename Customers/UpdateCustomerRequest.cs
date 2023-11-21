using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdateCustomerRequest : RequestBase
    {
        public UpdateCustomerRequest()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required").MaximumLength(30).WithMessage("First Name cannot be morethan 30 charactors");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required").MinimumLength(1).WithMessage("Last Name should have atleast 1 charactor").MaximumLength(30).WithMessage("Last Name cannot be morethan 30 charectors");         
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email required").EmailAddress().WithMessage("Email address is not valid");
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("Date Of Birth required");
        }
    }
}
