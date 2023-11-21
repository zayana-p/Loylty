using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class UpdateOutletStoreRequest
    {
        public UpdateOutletStoreRequest() { }
        public int Id { get; set; }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
    }
}
