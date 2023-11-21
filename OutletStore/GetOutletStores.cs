using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels.OutletStores
{
    public class GetOutletStores : ResponseBase
    {
        public GetOutletStores() { }
        public List<OutletStore> outletStores { get; set; }
    }
}
