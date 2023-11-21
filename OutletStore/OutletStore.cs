using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class OutletStore
    {
        public OutletStore() { }
        public int Id { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
    }
    public class OutletStoreValidator : AbstractValidator<OutletStore>
    {
        public OutletStoreValidator()
        {
            RuleFor(x => x.StoreCode).NotEmpty();
            RuleFor(x => x.StoreName).NotEmpty();
        }
    }
}