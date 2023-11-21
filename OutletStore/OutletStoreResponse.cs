using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class OutletStoreResponse : ResponseBase
    {
        public OutletStoreResponse() { }
        public OutletStore? outletStoreResponse { get; set; }
    }
}
