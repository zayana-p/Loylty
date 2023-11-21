﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class NewOrder
    {
        public NewOrder() { }
        public int Id { get; set; }
        public string StoreLocationCode { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerMobile { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionTitle { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? RedeemedPoints { get; set; }
        public decimal? SilverRedeemedPoints { get; set; }
        public decimal? GiftRewards { get; set; }
        public IEnumerable<NewOrderDetail> OrderDetail { get; set; }
    }
    public class NewOrderValidator : AbstractValidator<NewOrder>
    {
        public NewOrderValidator()
        {
            RuleFor(x => x.OrderNo).NotEmpty();
            RuleFor(x => x.CustomerMobile).NotEmpty().WithMessage("Mobile required").Matches(new Regex(@"^(?:00971|\+971|0)?(?:50|51|52|55|56|58|2|3|4|6|7|9)\d{7}$")).WithMessage("PhoneNumber not valid");
            RuleFor(x => x.NetAmount).NotEmpty();
        }
    }
}
