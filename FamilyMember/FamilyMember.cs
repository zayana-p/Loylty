using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class FamilyMember
    {
        public FamilyMember() { }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? StudentEnrollmentNo { get; set; }
        public string? Relationship { get; set; }
    }
    public class FamilyMemberValidator : AbstractValidator<FamilyMember>
    {
        public FamilyMemberValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required").MaximumLength(30).WithMessage("First Name cannot be morethan 30 charectors");
            RuleFor(x => x.StudentEnrollmentNo).NotEmpty().WithMessage("StudentEnrollmentNo is required");
           
        }
    }
}
