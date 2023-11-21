using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class PianoServiceType
    {
        public PianoServiceType() { }
        public int Id { get; set; }
        public string? Code { get; set; }
        public string Model { get; set; }
        public IEnumerable<PianoServiceCost> PianoServiceCost { get; set; }
    }
    public class PianoServiceTypeValidator : AbstractValidator<PianoServiceType>
    {
        public PianoServiceTypeValidator()
        {
            RuleFor(x => x.Model).NotEmpty();
        }
    }
}
