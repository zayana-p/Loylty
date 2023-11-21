using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class OrderDetail
    {
        public OrderDetail() { }
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public DateTime WarrantyExpiry { get; set; }
        public string? SerialNo { get; set; }

        public int OrderId { get; set; }
    }
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.ItemType).NotEmpty();
            RuleFor(x => x.ItemCode).NotEmpty();
            RuleFor(x => x.ItemName).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty();
        }
    }
}
