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
    public class Address
    {
        public Address() { }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string HouseNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Landmark { get; set; }
    }
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("FullName required");
            RuleFor(x => x.HouseNo).NotEmpty().WithMessage("Houseno required");
            RuleFor(x => x.AddressLine1).NotEmpty().WithMessage("AddressLine1 required");
            RuleFor(x => x.AddressLine2).NotEmpty().WithMessage("AddressLine2 required");
            RuleFor(x => x.City).NotEmpty().WithMessage("City required");
            RuleFor(x => x.Region).NotEmpty().WithMessage("Region required");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country required");
        }
    }
}
