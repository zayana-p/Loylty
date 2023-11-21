﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class GetCustomerRequest : RequestBase
    {
        public GetCustomerRequest()
        {
        }
        public string Mobile { get; set; }
    }
    public class GetCustomerRequestValidator : AbstractValidator<GetCustomerRequest>
    {
        public GetCustomerRequestValidator()
        {
            RuleFor(x => x.Mobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
        }
    }
}
